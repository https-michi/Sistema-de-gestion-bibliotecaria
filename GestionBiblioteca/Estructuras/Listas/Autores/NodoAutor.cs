using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Estructuras.Autores
{
    public class NodoAutor
    {
        public Autor Autor { get; set; } 
        public NodoAutor Siguiente { get; set; } 

        public NodoAutor(Autor autor)
        {
            Autor = autor;
            Siguiente = null; 
        }
    }
}
