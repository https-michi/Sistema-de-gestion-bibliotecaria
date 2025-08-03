using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Estructuras.Colas
{
    internal class ColaSolicitud
    {
        private NodoSolicitud primero;
        private NodoSolicitud ultimo;

        public ColaSolicitud()
        {
            primero = null;
            ultimo = null;
        }

        // Método para agregar una solicitud a la cola
        public void Enqueue(Solicitud solicitud)
        {
            NodoSolicitud nuevoNodo = new NodoSolicitud(solicitud);
            if (ultimo == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                ultimo.Siguiente = nuevoNodo;
                ultimo = nuevoNodo;
            }
        }

        // Método para eliminar y retornar la solicitud al frente de la cola
        public Solicitud Dequeue()
        {
            if (primero == null)
                throw new InvalidOperationException("La cola está vacía.");

            Solicitud solicitud = primero.Solicitud;
            primero = primero.Siguiente;

            if (primero == null)
                ultimo = null;

            return solicitud;
        }

        // Método para verificar si la cola está vacía
        public bool EstaVacia()
        {
            return primero == null;
        }

        // Método para ver la solicitud en el frente de la cola sin eliminarla
        public Solicitud Peek()
        {
            if (primero == null)
                throw new InvalidOperationException("La cola está vacía.");

            return primero.Solicitud;
        }
    }
}
