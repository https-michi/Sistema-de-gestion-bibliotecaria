using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Estructuras.Colas
{
    internal class NodoSolicitud
    {
        public Solicitud Solicitud { get; set; }
        public NodoSolicitud Siguiente { get; set; }

        public NodoSolicitud(Solicitud solicitud)
        {
            Solicitud = solicitud;
            Siguiente = null;
        }
    }
}
