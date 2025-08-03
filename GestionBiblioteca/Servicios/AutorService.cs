using GestionBiblioteca.Estructuras.Autores;
using GestionBiblioteca.Models;
using System;
using System.IO;
using System.Linq;

namespace GestionBiblioteca.Servicios
{
    public class AutorService
    {
        private ListaAutores listaAutores;

        public AutorService()
        {
            listaAutores = new ListaAutores();
            CargarAutoresDesdeArchivo();
        }

        public Autor BuscarAutorPorId(int id)
        {
            // Buscar primero en la lista en memoria
            NodoAutor actual = listaAutores.cabeza;
            while (actual != null)
            {
                if (actual.Autor.Id == id)
                {
                    return actual.Autor;
                }
                actual = actual.Siguiente;
            }

            // Si no se encuentra, buscar en el archivo
            string archivoRuta = @"Data\Autor.txt";
            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                foreach (var linea in lineas)
                {
                    var campos = linea.Split(',');
                    if (campos.Length == 5 && int.Parse(campos[0]) == id)
                    {
                        return new Autor
                        {
                            Id = int.Parse(campos[0]),
                            Nombre = campos[1],
                            Nacionalidad = campos[2],
                            FechaNacimiento = DateTime.Parse(campos[3]),
                            Biografia = campos[4]
                        };
                    }
                }
            }

            return null; // Autor no encontrado
        }

        public void AgregarAutor(Autor autor)
        {
            if (AutorExiste(autor.Nombre))
            {
                throw new InvalidOperationException("Ya existe un autor con ese nombre.");
            }

            listaAutores.AgregarAutor(autor); // Agregar el autor a la lista enlazada
            GuardarAutorEnArchivo(autor); // Guardar en el archivo
        }

        public bool AutorExiste(string nombre)
        {
            NodoAutor actual = listaAutores.cabeza;

            // Buscar en la lista enlazada
            while (actual != null)
            {
                if (actual.Autor.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                actual = actual.Siguiente;
            }

            return AutorExisteEnArchivo(nombre);
        }

        private bool AutorExisteEnArchivo(string nombre)
        {
            string archivoRuta = @"Data\Autor.txt";
            if (!File.Exists(archivoRuta)) return false;

            string[] lineas = File.ReadAllLines(archivoRuta);
            return lineas.Any(linea =>
            {
                string[] campos = linea.Split(',');
                return campos.Length >= 2 && campos[1].Equals(nombre, StringComparison.OrdinalIgnoreCase);
            });
        }


        private void GuardarAutorEnArchivo(Autor autor)
        {
            string archivoRuta = @"Data\Autor.txt";
            string linea = $"{autor.Id},{autor.Nombre},{autor.Nacionalidad},{autor.FechaNacimiento:yyyy-MM-dd},{autor.Biografia}";
            Directory.CreateDirectory(Path.GetDirectoryName(archivoRuta));
            File.AppendAllText(archivoRuta, linea + Environment.NewLine);
        }

        public int ObtenerNuevoId()
        {
            // Obtener el ID más alto en la lista enlazada
            int maxId = 0;
            NodoAutor actual = listaAutores.cabeza;
            while (actual != null)
            {
                if (actual.Autor.Id > maxId)
                {
                    maxId = actual.Autor.Id;
                }
                actual = actual.Siguiente;
            }

            // Verificar el archivo también
            string archivoRuta = @"Data\Autor.txt";
            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                foreach (string linea in lineas)
                {
                    var campos = linea.Split(',');
                    if (campos.Length > 0)
                    {
                        int id = int.Parse(campos[0]);
                        if (id > maxId)
                        {
                            maxId = id;
                        }
                    }
                }
            }

            return maxId + 1;
        }

        private void CargarAutoresDesdeArchivo()
        {
            string archivoRuta = @"Data\Autor.txt";
            if (!File.Exists(archivoRuta)) return;

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (var linea in lineas)
            {
                var campos = linea.Split(',');
                if (campos.Length == 5)
                {
                    Autor autor = new Autor
                    {
                        Id = int.Parse(campos[0]),
                        Nombre = campos[1],
                        Nacionalidad = campos[2],
                        FechaNacimiento = DateTime.Parse(campos[3]),
                        Biografia = campos[4]
                    };
                    listaAutores.AgregarAutor(autor);
                }
            }
        }

        public Autor[] BuscarAutoresPorNombre(string nombre)
        {
            // Buscar autores en la lista enlazada
            NodoAutor actual = listaAutores.cabeza;
            Autor[] autoresEncontrados = new Autor[100];
            int index = 0;

            while (actual != null)
            {
                if (actual.Autor.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    autoresEncontrados[index++] = actual.Autor;
                }
                actual = actual.Siguiente;
            }

            // Si no se encuentran resultados, verificar en el archivo
            if (index == 0)
            {
                string archivoRuta = @"Data\Autor.txt";
                if (File.Exists(archivoRuta))
                {
                    string[] lineas = File.ReadAllLines(archivoRuta);
                    foreach (string linea in lineas)
                    {
                        var campos = linea.Split(',');
                        string nombreAutor = campos[1];

                        if (nombreAutor.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Autor autor = new Autor
                            {
                                Id = int.Parse(campos[0]),
                                Nombre = campos[1],
                                Nacionalidad = campos[2],
                                FechaNacimiento = DateTime.Parse(campos[3]),
                                Biografia = campos[4]
                            };
                            autoresEncontrados[index++] = autor;
                        }
                    }
                }
            }

            Autor[] autoresFinales = new Autor[index];
            Array.Copy(autoresEncontrados, autoresFinales, index);
            return autoresFinales;
        }
    }
}
