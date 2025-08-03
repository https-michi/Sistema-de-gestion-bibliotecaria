using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Estructuras.Categorias
{
    public class NodoCategoria
    {
        public Categoria Categoria { get; set; } 
        public NodoCategoria Siguiente { get; set; } 

        public NodoCategoria(Categoria categoria)
        {
            Categoria = categoria;
            Siguiente = null; 
        }
    }
}
