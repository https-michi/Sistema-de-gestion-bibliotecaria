using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; } 
        //public ListaLibros Libros { get; set; } // Relación con libros usando lista enlazada

        public Categoria()
        {
           // Libros = new ListaLibros();
        }
    }

}
