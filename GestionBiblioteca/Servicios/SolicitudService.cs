using GestionBiblioteca.Models;
using System;
using System.IO;
using System.Linq;
using GestionBiblioteca.Estructuras.Colas; 

namespace GestionBiblioteca.Servicios
{
    internal class SolicitudService
    {
        private Solicitud[] solicitudes;
        private ColaSolicitud colaSolicitudes; 

        public SolicitudService()
        {
            solicitudes = CargarSolicitudes();
            colaSolicitudes = new ColaSolicitud(); 
        }

        public Solicitud[] CargarSolicitudes()
        {
            string archivoRuta = @"Data\Solicitudes.txt";
            var listaTemporal = new Solicitud[0];

            if (File.Exists(archivoRuta))
            {
                string[] lineas = File.ReadAllLines(archivoRuta);
                listaTemporal = new Solicitud[lineas.Length];

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(',');

                    var solicitud = new Solicitud
                    {
                        Id = int.Parse(campos[0]),
                        Usuario = new Usuario { Id = int.Parse(campos[1]) },
                        Libro = new Libro { Id = int.Parse(campos[2]) },
                        FechaSolicitud = DateTime.Parse(campos[3]),
                        EstaAtendida = bool.Parse(campos[4]),
                        FechaAtendida = campos[5] == "null" ? (DateTime?)null : DateTime.Parse(campos[5])
                    };

                    var usuario = new UsuarioNegocioService().BuscarUsuarioPorId(solicitud.Usuario.Id);
                    if (usuario != null) solicitud.Usuario.Nombres = usuario.Nombres;
                    var libro = new LibroService().BuscarLibroPorId(solicitud.Libro.Id);
                    if (libro != null) solicitud.Libro.Titulo = libro.Titulo;

                    listaTemporal[i] = solicitud;
                }
            }

            return listaTemporal;
        }

        public void GuardarSolicitudes()
        {
            string archivoRuta = @"Data\Solicitudes.txt";
            string[] lineas = new string[solicitudes.Length];

            for (int i = 0; i < solicitudes.Length; i++)
            {
                var s = solicitudes[i];
                lineas[i] = $"{s.Id},{s.Usuario.Id},{s.Libro.Id},{s.FechaSolicitud:yyyy-MM-dd HH:mm:ss},{s.EstaAtendida},{(s.FechaAtendida.HasValue ? s.FechaAtendida.Value.ToString("o") : "null")}";
            }

            File.WriteAllLines(archivoRuta, lineas);
        }

        public void GuardarSolicitudesEnArchivo(Solicitud[] solicitudes)
        {
            string archivoRuta = @"Data\Solicitudes.txt";

            var lineas = solicitudes.Select(s =>
                $"{s.Id},{s.Usuario.Id},{s.Libro.Id},{s.FechaSolicitud:yyyy-MM-dd HH:mm:ss},{s.EstaAtendida},{(s.FechaAtendida.HasValue ? s.FechaAtendida.Value.ToString("o") : "null")}"
            ).ToArray();

            File.WriteAllLines(archivoRuta, lineas);
        }

        public void RegistrarSolicitud(Usuario usuario, Libro libro)
        {
            foreach (var s in solicitudes)
            {
                if (s.Usuario.Id == usuario.Id && s.Libro.Id == libro.Id && !s.EstaAtendida)
                {
                    throw new InvalidOperationException("Ya existe una solicitud pendiente para este usuario y libro.");
                }
            }

            int nuevoId = solicitudes.Length > 0 ? solicitudes[solicitudes.Length - 1].Id + 1 : 1;
            var nuevaSolicitud = new Solicitud
            {
                Id = nuevoId,
                Usuario = usuario,
                Libro = libro,
                FechaSolicitud = DateTime.Now,
                EstaAtendida = false
            };

            // Agregar la nueva solicitud a la cola
            colaSolicitudes.Enqueue(nuevaSolicitud);

            Array.Resize(ref solicitudes, solicitudes.Length + 1);
            solicitudes[solicitudes.Length - 1] = nuevaSolicitud;

            GuardarSolicitudes();
        }

        // Método para procesar la siguiente solicitud en la cola
        public Solicitud ProcesarSiguienteSolicitud()
        {
            if (colaSolicitudes.EstaVacia())
            {
                throw new InvalidOperationException("No hay solicitudes en la cola para verificar el proceso.");
            }

            return colaSolicitudes.Dequeue();
        }

        public Solicitud[] ObtenerSolicitudesPendientesPorLibro(int idLibro)
        {
            var solicitudesFiltradas = new Solicitud[0];
            foreach (var s in solicitudes)
            {
                if (s.Libro.Id == idLibro && !s.EstaAtendida)
                {
                    Array.Resize(ref solicitudesFiltradas, solicitudesFiltradas.Length + 1);
                    solicitudesFiltradas[solicitudesFiltradas.Length - 1] = s; 
                }
            }
            return solicitudesFiltradas;
        }
    }
}












