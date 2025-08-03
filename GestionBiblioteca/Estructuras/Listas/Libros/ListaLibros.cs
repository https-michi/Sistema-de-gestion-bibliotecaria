using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Estructuras.Libros
{
    public class ListaLibros
    {
        public NodoLibro cabeza;

        public ListaLibros()
        {
            cabeza = null;
        }
        public Libro BuscarLibroPorId(int id)
        {
            NodoLibro actual = cabeza;
            while (actual != null)
            {
                if (actual.Libro.Id == id)
                {
                    return actual.Libro;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void AgregarLibro(Libro libro)
        {
            NodoLibro nuevoNodo = new NodoLibro(libro);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoLibro actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }


        public void MostrarLibros()
        {
            NodoLibro actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine($"Título: {actual.Libro.Titulo}, ISBN: {actual.Libro.ISBN}");
                actual = actual.Siguiente;
            }
        }



        public Libro BuscarLibroPorTitulo(string titulo)
        {
            NodoLibro actual = cabeza;

            while (actual != null)
            {
                if (actual.Libro.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0) return actual.Libro;
                actual = actual.Siguiente;
            }

            return null;
        }
    }
}