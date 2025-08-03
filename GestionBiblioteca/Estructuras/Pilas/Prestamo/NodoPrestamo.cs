using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    internal class NodoPrestamo
    {
        public Prestamo Prestamo { get; set; }
        public NodoPrestamo Siguiente { get; set; }

        public NodoPrestamo(Prestamo prestamo)
        {
            Prestamo = prestamo;
            Siguiente = null;
        }
    }
}