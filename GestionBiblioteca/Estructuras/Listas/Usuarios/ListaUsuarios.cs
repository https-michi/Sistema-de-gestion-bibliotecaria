using GestionBiblioteca.Models;
using System;

namespace GestionBiblioteca.Estructuras.Usuarios
{
    // Estructura de lista enlazada para almacenar los usuarios en memoria.
    public class ListaUsuarios
    {
        public NodoUsuario cabeza;


        public ListaUsuarios()
        {
            cabeza = null;
        }

        public void AgregarUsuario(UsuarioSistema usuario)
        {
            NodoUsuario nuevoNodo = new NodoUsuario(usuario);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoUsuario actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        public void MostrarUsuarios()
        {
            NodoUsuario actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine($"ID: {actual.Usuario.Id}, Usuario: {actual.Usuario.UsuarioSistemaNombre}");
                actual = actual.Siguiente;
            }
        }
    }
}
