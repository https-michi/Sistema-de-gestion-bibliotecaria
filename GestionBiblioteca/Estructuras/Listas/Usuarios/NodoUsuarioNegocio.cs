using GestionBiblioteca.Models;

namespace GestionBiblioteca.Estructuras.Usuarios
{

    public class NodoUsuarioNegocio
    {
        public UsuarioNegocio Usuario { get; set; }
        public NodoUsuarioNegocio Siguiente { get; set; }

        public NodoUsuarioNegocio(UsuarioNegocio usuario)
        {
            Usuario = usuario;
            Siguiente = null;
        }
    }
}