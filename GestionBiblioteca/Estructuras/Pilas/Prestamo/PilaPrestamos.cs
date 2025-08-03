using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Models
{
    internal class PilaPrestamos
    {
        private NodoPrestamo cima;

        public PilaPrestamos()
        {
            cima = null;
        }

        // Agregar un préstamo a la pila
        public void Push(Prestamo prestamo)
        {
            NodoPrestamo nuevoNodo = new NodoPrestamo(prestamo);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
        }

        // Quitar el préstamo de la cima de la pila
        public Prestamo Pop()
        {
            if (cima == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            Prestamo prestamo = cima.Prestamo;
            cima = cima.Siguiente;
            return prestamo;
        }

        // Obtener el préstamo en la cima sin quitarlo
        public Prestamo Peek()
        {
            if (cima == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            return cima.Prestamo;
        }

        // Verificar si la pila está vacía
        public bool EstaVacia()
        {
            return cima == null;
        }
    }
}