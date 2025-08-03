using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    internal class Solicitud
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaSolicitud { get; set; } = DateTime.Now; // Fecha actual por defecto
                                                                     //Cuando se crea el prestamo que agarre la del sistema la fecha 
        public bool EstaAtendida { get; set; } = false; 
        public DateTime? FechaAtendida { get; set; } = null;

        public string NombreUsuario => Usuario?.Nombres; 
        public string TituloLibro => Libro?.Titulo;

        public void MarcarComoAtendida()
        {
            EstaAtendida = true;
            FechaAtendida = DateTime.Now; 
        }
    }
}
