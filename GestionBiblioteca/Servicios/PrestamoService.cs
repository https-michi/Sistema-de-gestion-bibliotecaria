
using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Servicios
{
    internal class PrestamoService
    {
        private PilaPrestamos pilaPrestamos;
        public PrestamoService()
        {
            pilaPrestamos = new PilaPrestamos(); 
        }

        public bool AgregarPrestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            Libro libroActual = ObtenerLibroPorId(libro.Id);
            if (libroActual == null)
            {
                Console.WriteLine("El libro no se encontró.");
                return false;
            }
            Console.WriteLine($"Estado del libro '{libroActual.Titulo}': {libroActual.Disponible}");

            if (!libroActual.Disponible)
            {
                Console.WriteLine("El libro no está disponible para préstamo.");
                return false;
            }
            libroActual.Disponible = false;
            ActualizarLibroEnArchivo(libroActual);
            decimal multas = 0;
            DateTime fechaActual = DateTime.Now;
            if (fechaActual > fechaDevolucion)
            {
                multas = CalcularMulta(fechaDevolucion, false, fechaActual);
            }
            Prestamo nuevoPrestamo = new Prestamo
            {
                Id = ObtenerNuevoIdPrestamo(),
                Usuario = usuario,
                Libro = libroActual,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion,
                EstaDevuelto = false,
                Multas = multas
            };
            pilaPrestamos.Push(nuevoPrestamo);

            string archivoRuta = @"Data\Prestamo.txt";
            string prestamoString = $"{nuevoPrestamo.Id},{nuevoPrestamo.Usuario.Id},{nuevoPrestamo.Libro.Id},{nuevoPrestamo.FechaPrestamo},{nuevoPrestamo.FechaDevolucion},{nuevoPrestamo.EstaDevuelto},{nuevoPrestamo.Multas}";
            File.AppendAllLines(archivoRuta, new[] { prestamoString });

            return true;
        }
        public bool DeshacerUltimoPrestamo()
        {
            if (pilaPrestamos.EstaVacia())
            {
                Console.WriteLine("No hay préstamos para deshacer.");
                return false;
            }

            Prestamo prestamoAEliminar = pilaPrestamos.Pop();

            if (prestamoAEliminar == null)
            {
                Console.WriteLine("No se pudo obtener el préstamo a eliminar.");
                return false;
            }

            Libro libro = ObtenerLibroPorId(prestamoAEliminar.Libro.Id);
            if (libro != null)
            {
                libro.Disponible = true; 
                ActualizarLibroEnArchivo(libro); 
            }

            EliminarPrestamoDelArchivo(prestamoAEliminar.Id);

            Console.WriteLine($"Préstamo de '{prestamoAEliminar.Libro.Titulo}' deshecho.");
            return true;
        }

        private void EliminarPrestamoDelArchivo(int idPrestamo)
        {
            try
            {
                var prestamos = CargarListaPrestamosDesdeArchivo(); 
                var prestamosActualizados = prestamos.Where(p => p.Id != idPrestamo).ToArray(); 
                GuardarPrestamosEnArchivo(prestamosActualizados); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el préstamo del archivo: {ex.Message}");
            }
        }

        public Usuario[] BuscarUsuariosPorNombre(string nombre)
        {
            Usuario[] usuariosEncontrados = new Usuario[100];
            int index = 0;
            string archivoRuta = @"Data\UsuarioNegocio.txt";

            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');

                    if (campos[2].IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Usuario usuario = new Usuario
                        {
                            Id = int.Parse(campos[0]),
                            Numero = campos[1],
                            Nombres = campos[2]
                        };
                        usuariosEncontrados[index++] = usuario;
                    }
                }
            }

            Usuario[] usuariosFinales = new Usuario[index];
            Array.Copy(usuariosEncontrados, usuariosFinales, index);
            return usuariosFinales;
        }
        public Libro[] BuscarLibrosPorTitulo(string titulo)
        {
            Libro[] librosEncontrados = new Libro[100];
            int index = 0;
            string archivoRuta = @"Data\Libro.txt";

            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');

                    if (campos[1].IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Libro libro = new Libro
                        {
                            Id = int.Parse(campos[0]),
                            Titulo = campos[1]
                        };
                        librosEncontrados[index++] = libro;
                    }
                }
            }

            Libro[] librosFinales = new Libro[index];
            Array.Copy(librosEncontrados, librosFinales, index);
            return librosFinales;
        }
        public Libro ObtenerLibroPorId(int idLibro)
        {
            string archivoRuta = @"Data\Libro.txt";
            if (!File.Exists(archivoRuta))
            {
                return null;
            }

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');
                if (int.Parse(campos[0]) == idLibro)
                {
                    return new Libro
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
                }
            }

            return null;
        }


        public decimal CalcularMulta(DateTime fechaDevolucion, bool estaDevuelto, DateTime fechaActual)
        {
            if (estaDevuelto)
            {
                return 0;
            }

            if (fechaActual > fechaDevolucion)
            {
                int diasDeRetraso = (fechaActual - fechaDevolucion).Days;
                decimal multa = diasDeRetraso * 3m;

                return multa;
            }

            return 0;
        }

        private void ActualizarLibroEnArchivo(Libro libro)
        {
            var libros = CargarListaLibrosDesdeArchivo(); 
            var libroActualizado = libros.FirstOrDefault(l => l.Id == libro.Id);
            if (libroActualizado != null)
            {
                libroActualizado.Disponible = libro.Disponible;
                Console.WriteLine($"Actualizando disponibilidad del libro '{libro.Titulo}' a {libro.Disponible}");
            }
            else
            {
                Console.WriteLine("No se encontró el libro para actualizar.");
            }
            GuardarLibrosEnArchivo(libros); 
        }

        public Libro[] CargarListaLibrosDesdeArchivo()
        {
            Libro[] libros = new Libro[100];
            int index = 0;
            string archivoRuta = @"Data\Libro.txt";
            if (!File.Exists(archivoRuta)) return new Libro[0]; 

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (var linea in lineas)
            {
                var campos = linea.Split(',');
                if (campos.Length == 12)
                {
                    Libro libro = new Libro
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
                    Console.WriteLine($"Cargando libro: {libro.Titulo}, Disponible: {libro.Disponible}");
                    libros[index++] = libro; 
                }
            }

            Libro[] librosFinales = new Libro[index];
            Array.Copy(libros, librosFinales, index);
            return librosFinales;
        }

        public void GuardarLibrosEnArchivo(Libro[] libros)
        {
            string[] lineas = new string[libros.Length]; 
            for (int i = 0; i < libros.Length; i++)
            {
                var libro = libros[i];
                string linea = $"{libro.Id},{libro.Titulo},{libro.ISBN},{libro.Editorial},{libro.Edicion},{libro.FechaPublicacion:yyyy-MM-dd},{libro.NumeroCopias},{libro.UbicacionFisica},{libro.Disponible},{libro.FechaRegistro:yyyy-MM-dd HH:mm:ss},{libro.Autor.Id},{libro.Categoria.Id}";
                lineas[i] = linea; 
            }
            File.WriteAllLines(@"Data\Libro.txt", lineas); 
        }

        public int ObtenerNuevoIdPrestamo()
        {
            string archivoRuta = @"Data\Prestamo.txt";
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

        public Prestamo[] CargarListaPrestamosDesdeArchivo()
        {
            Prestamo[] prestamos = new Prestamo[100]; 
            int index = 0;
            string archivoRuta = @"Data\Prestamo.txt";
            if (!File.Exists(archivoRuta)) return prestamos;

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (var linea in lineas)
            {
                var campos = linea.Split(',');
                if (campos.Length == 7)
                {
                    Prestamo prestamo = new Prestamo
                    {
                        Id = int.Parse(campos[0]),
                        Usuario = new Usuario { Id = int.Parse(campos[1]) },
                        Libro = new Libro { Id = int.Parse(campos[2]) },
                        FechaPrestamo = DateTime.Parse(campos[3]),
                        FechaDevolucion = DateTime.Parse(campos[4]),
                        EstaDevuelto = bool.Parse(campos[5]),
                        Multas = decimal.Parse(campos[6])
                    };
                    if (!prestamo.EstaDevuelto)
                    {
                        prestamo.Multas = CalcularMulta(prestamo.FechaDevolucion, prestamo.EstaDevuelto, DateTime.Now);
                    }
                    UsuarioNegocioService usuarioNegocioService = new UsuarioNegocioService();
                    Usuario usuario = usuarioNegocioService.BuscarUsuarioPorId(prestamo.Usuario.Id);
                    if (usuario != null)
                    {
                        prestamo.Usuario.Nombres = usuario.Nombres;
                        Console.WriteLine("Usuario cargado: " + usuario.Nombres);

                    }
                    else
                    {
                        Console.WriteLine("Usuario no encontrado para ID: " + prestamo.Usuario.Id);
                    }
                    LibroService libroService = new LibroService();
                    Libro libro = libroService.BuscarLibroPorId(prestamo.Libro.Id);
                    if (libro != null)
                    {
                        prestamo.Libro.Titulo = libro.Titulo;
                        Console.WriteLine("Libro cargado: " + libro.Titulo);

                    }
                    else
                    {
                        Console.WriteLine("Libro no encontrado para ID: " + prestamo.Libro.Id);
                    }
                    prestamos[index++] = prestamo; 
                }
            }

            Prestamo[] prestamosFinales = new Prestamo[index];
            Array.Copy(prestamos, prestamosFinales, index);
            return prestamosFinales;
        }
        public void GuardarPrestamosEnArchivo(Prestamo[] prestamos)
        {
            string[] lineas = new string[prestamos.Length];
            for (int i = 0; i < prestamos.Length; i++)
            {
                var prestamo = prestamos[i];
                lineas[i] = $"{prestamo.Id},{prestamo.Usuario.Id},{prestamo.Libro.Id},{prestamo.FechaPrestamo:yyyy-MM-dd HH:mm:ss},{prestamo.FechaDevolucion:yyyy-MM-dd HH:mm:ss},{prestamo.EstaDevuelto},{prestamo.Multas:F2}";
            }
            File.WriteAllLines(@"Data\Prestamo.txt", lineas);
        }

        public Prestamo ObtenerPrestamoPorId(int idPrestamo)
        {
            string archivoRuta = @"Data\Prestamo.txt";
            if (!File.Exists(archivoRuta))
            {
                return null;
            }

            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');
                int id = int.Parse(campos[0]);

                if (id == idPrestamo)
                {
                    return new Prestamo
                    {
                        Id = id,
                        Usuario = new Usuario { Id = int.Parse(campos[1]) },
                        Libro = new Libro { Id = int.Parse(campos[2]) },
                        FechaPrestamo = DateTime.Parse(campos[3]),
                        FechaDevolucion = DateTime.Parse(campos[4]),
                        EstaDevuelto = bool.Parse(campos[5]),
                        Multas = decimal.Parse(campos[6])
                    };
                }
            }

            return null;
        }


        public UsuarioNegocio[] ObtenerTopUsuariosConMasLibrosDevueltos(int topN)
        {
            var prestamos = CargarListaPrestamosDesdeArchivo();

            if (prestamos == null || !prestamos.Any())
            {
                Console.WriteLine("No se encontraron préstamos o el archivo está vacío.");
                return Array.Empty<UsuarioNegocio>();
            }

            var usuariosDevueltos = prestamos
                .Where(p => p != null && p.EstaDevuelto && p.Usuario != null) // Validaciones de nulos
                .GroupBy(p => p.Usuario.Id)
                .Select(g => new
                {
                    UsuarioId = g.Key,
                    CantidadLibrosDevueltos = g.Count()
                })
                .OrderByDescending(u => u.CantidadLibrosDevueltos)
                .Take(topN)
                .ToList();

            UsuarioNegocio[] usuarios = new UsuarioNegocio[usuariosDevueltos.Count];
            int index = 0;

            foreach (var usuarioDevuelto in usuariosDevueltos)
            {
                var usuario = new UsuarioNegocioService().BuscarUsuarioPorId(usuarioDevuelto.UsuarioId);
                if (usuario != null)
                {
                    usuarios[index++] = usuario;
                }
                else
                {
                    Console.WriteLine($"Usuario con ID {usuarioDevuelto.UsuarioId} no encontrado.");
                }
            }

            return usuarios.Where(u => u != null).ToArray();
        }



    }
}
