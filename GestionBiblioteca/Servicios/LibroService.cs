using GestionBiblioteca.Estructuras.Libros;
using GestionBiblioteca.Models;
using System;
using System.IO;
using System.Linq;

namespace GestionBiblioteca.Servicios
{
    public class LibroService
    {
        private ListaLibros listaLibros;
        private AutorService autorService;

        // Constructor que inicializa la lista de libros y carga los datos desde el archivo
        public LibroService()
        {
            listaLibros = new ListaLibros();
            CargarLibrosEnListaDesdeArchivo();
        }

        //------------------------------------------------------------------------------------------------
        // Agrega un nuevo libro a la lista y lo guarda en el archivo
        // Lanza una excepción si el libro ya existe
        public void AgregarLibro(Libro libro)
        {
            if (LibroExiste(libro.ISBN))
            {
                throw new InvalidOperationException("El libro ya esta registrado con esa ISBN.");
            }
            listaLibros.AgregarLibro(libro);
            GuardarLibroEnArchivo(libro);
        }

        // Guarda un libro específico en el archivo
        private void GuardarLibroEnArchivo(Libro libro)
        {
            string archivoRuta = @"Data\Libro.txt";
            string linea = $"{libro.Id},{libro.Titulo},{libro.ISBN},{libro.Editorial},{libro.Edicion},{libro.FechaPublicacion:yyyy-MM-dd},{libro.NumeroCopias},{libro.UbicacionFisica},{libro.Disponible},{libro.FechaRegistro:yyyy-MM-dd HH:mm:ss},{libro.Autor.Id},{libro.Categoria.Id}";
            Directory.CreateDirectory(Path.GetDirectoryName(archivoRuta));
            File.AppendAllText(archivoRuta, linea + Environment.NewLine);
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        // Verifica si un libro existe en la lista enlazada o en el archivo
        public bool LibroExiste(string isbn)
        {
            NodoLibro actual = listaLibros.cabeza;
            while (actual != null)
            {
                if (actual.Libro.ISBN == isbn)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return LibroExisteEnArchivo(isbn);
        }

        // Verifica si un libro existe en el archivo
        private bool LibroExisteEnArchivo(string isbn)
        {
            Libro[] libros = CargarLibrosDesdeArchivo();
            return libros.Any(libro => libro.ISBN == isbn);
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        // Busca un libro por su ID en la lista enlazada o en el archivo
        public Libro BuscarLibroPorId(int id)
        {
            // Primero busca en la lista enlazada
            Libro libroEncontrado = listaLibros.BuscarLibroPorId(id);
            if (libroEncontrado != null)
            {
                return libroEncontrado;
            }
            // Si no se encuentra, buscar en el archivo
            return BuscarLibroPorIdEnArchivo(id);
        }

        // Busca un libro por su ID en el archivo
        private Libro BuscarLibroPorIdEnArchivo(int id)
        {
            Libro[] libros = CargarLibrosDesdeArchivo();
            return libros.FirstOrDefault(libro => libro.Id == id);
        }
        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        // Carga los libros desde el archivo y los agrega a la lista enlazada
        public void CargarLibrosEnListaDesdeArchivo()
        {
            Libro[] libros = CargarLibrosDesdeArchivo();
            foreach (var libro in libros)
            {
                listaLibros.AgregarLibro(libro);
            }
        }

        // Carga los libros desde un archivo de texto
        public Libro[] CargarLibrosDesdeArchivo()
        {
            string archivoRuta = @"Data\Libro.txt";
            if (!File.Exists(archivoRuta)) return new Libro[0];

            string[] lineas = File.ReadAllLines(archivoRuta);
            Libro[] libros = new Libro[lineas.Length];

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');

                if (campos.Length == 12)
                {
                    var libro = new Libro
                    {
                        Id = int.Parse(campos[0]),
                        Titulo = campos[1],
                        ISBN = campos[2],
                        Editorial = campos[3],
                        Edicion = campos[4],
                        FechaPublicacion = DateTime.Parse(campos[5]),
                        NumeroCopias = campos[6],
                        UbicacionFisica = campos[7],
                        Disponible = bool.Parse(campos[8]),
                        FechaRegistro = DateTime.Parse(campos[9]),
                        Autor = new Autor { Id = int.Parse(campos[10]) },
                        Categoria = new Categoria { Id = int.Parse(campos[11]) }
                    };

                    AutorService autorService = new AutorService();
                    Autor autor = autorService.BuscarAutorPorId(libro.Autor.Id);
                    if (autor != null)
                    {
                        libro.Autor.Nombre = autor.Nombre;
                    }

                    CategoriaService categoriaService = new CategoriaService();
                    Categoria categoria = categoriaService.BuscarCategoriaPorId(libro.Categoria.Id);
                    if (categoria != null)
                    {
                        libro.Categoria.Nombre = categoria.Nombre;
                    }

                    libros[i] = libro;
                }
            }

            return libros;
        }

        //------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------
        // Guarda todos los libros en el archivo, sobrescribiendo el contenido
        public void GuardarLibrosEnArchivo(Libro[] libros)
        {
            string[] lineas = new string[libros.Length];
            for (int i = 0; i < libros.Length; i++)
            {
                var libro = libros[i];
                lineas[i] = $"{libro.Id},{libro.Titulo},{libro.ISBN},{libro.Editorial},{libro.Edicion},{libro.FechaPublicacion:yyyy-MM-dd},{libro.NumeroCopias},{libro.UbicacionFisica},{libro.Disponible},{libro.FechaRegistro:yyyy-MM-dd HH:mm:ss},{libro.Autor.Id},{libro.Categoria.Id}";
            }
            File.WriteAllLines(@"Data\Libro.txt", lineas);
        }


        public void ActualizarLibroEnArchivo(Libro libroActualizado)
        {
            Libro[] libros = CargarLibrosDesdeArchivo();

            var libro = libros.FirstOrDefault(l => l.Id == libroActualizado.Id);

            if (libro != null)
            {
                libro.Disponible = libroActualizado.Disponible;
                libro.Titulo = libroActualizado.Titulo;
            }
            string[] lineas = libros.Select(l => $"{l.Id},{l.Titulo},{l.ISBN},{l.Editorial},{l.Edicion},{l.FechaPublicacion:yyyy-MM-dd},{l.NumeroCopias},{l.UbicacionFisica},{l.Disponible},{l.FechaRegistro:yyyy-MM-dd HH:mm:ss},{l.Autor?.Id},{l.Categoria?.Id}").ToArray();
            File.WriteAllLines(@"Data\Libro.txt", lineas);
        }

        //------------------------------------------------------------------------------------------------
        // Obtiene un nuevo ID único para un libro
        public int ObtenerNuevoId()
        {
            string archivoRuta = @"Data\Libro.txt";
            if (!File.Exists(archivoRuta))
            {
                return 1;
            }
            string[] lineas = File.ReadAllLines(archivoRuta);
            if (lineas.Length == 0)
            {
                return 1;
            }
            string ultimaLinea = lineas[lineas.Length - 1];
            string[] campos = ultimaLinea.Split(',');
            int ultimoId = int.Parse(campos[0]);
            return ultimoId + 1;
        }
        //------------------------------------------------------------------------------------------------
    }
}
