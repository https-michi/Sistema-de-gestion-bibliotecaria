using GestionBiblioteca.Models;
using System;

namespace GestionBiblioteca.Estructuras.Autores
{
    public class ListaAutores
    {
        public NodoAutor cabeza; 

        public ListaAutores()
        {
            cabeza = null; 
        }

        public void AgregarAutor(Autor autor)
        {
            NodoAutor nuevoNodo = new NodoAutor(autor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo; 
            }
            else
            {
                NodoAutor actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente; 
                }
                actual.Siguiente = nuevoNodo; 
            }
        }

        public void MostrarAutores()
        {
            NodoAutor actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine($"ID: {actual.Autor.Id}, Nombre: {actual.Autor.Nombre}");
                actual = actual.Siguiente;
            }
        }
    }
}
