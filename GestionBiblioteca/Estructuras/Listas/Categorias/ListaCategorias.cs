using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionBiblioteca.Estructuras.Categorias
{
    public class ListaCategorias
    {
        public NodoCategoria cabeza;

        public ListaCategorias()
        {
            cabeza = null;
        }

        public void AgregarCategoria(Categoria categoria)
        {
            NodoCategoria nuevoNodo = new NodoCategoria(categoria);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoCategoria actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }
    }
}
