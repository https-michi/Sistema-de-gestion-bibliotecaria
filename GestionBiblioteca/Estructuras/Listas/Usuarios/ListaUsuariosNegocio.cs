using GestionBiblioteca.Models;
using System;

namespace GestionBiblioteca.Estructuras.Usuarios
{

    public class ListaUsuariosNegocio
    {
        public NodoUsuarioNegocio cabeza;


        public ListaUsuariosNegocio()
        {
            cabeza = null;
        }


        public void AgregarUsuario(UsuarioNegocio usuario)
        {
            NodoUsuarioNegocio nuevoNodo = new NodoUsuarioNegocio(usuario);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                NodoUsuarioNegocio actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        public void MostrarUsuarios()
        {
            NodoUsuarioNegocio actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine($"ID: {actual.Usuario.Id}, Usuario: {actual.Usuario.Nombres}");
                actual = actual.Siguiente;
            }
        }
    }
}
