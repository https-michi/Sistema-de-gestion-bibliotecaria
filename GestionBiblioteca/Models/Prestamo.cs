using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    internal class Prestamo
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; } 
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool EstaDevuelto { get; set; } //false por  defecto al agregar 
        public decimal Multas { get; set; }

        public string NombreUsuario => Usuario?.Nombres;
        public string TituloLibro => Libro?.Titulo;

        public Prestamo() { }
    }
}
