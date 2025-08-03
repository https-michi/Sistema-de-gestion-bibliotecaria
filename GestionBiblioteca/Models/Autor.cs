using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Biografia { get; set; }
        //public ListaLibros LibrosEscritos { get; set; } // Relación con libros usando lista enlazada

        public Autor()
        {
            //LibrosEscritos = new ListaLibros();
        }

    }

}
