using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Estructuras.Libros
{
    public class NodoLibro
    {
        public Libro Libro { get; set; }
        public NodoLibro Siguiente { get; set; }

        public NodoLibro(Libro libro)
        {
            Libro = libro;
            Siguiente = null;
        }
    }

}
