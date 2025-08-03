using GestionBiblioteca.Models;

namespace GestionBiblioteca.Estructuras.Usuarios
{
    // Clase que representa un nodo en la lista enlazada de usuarios.
    // Cada nodo contiene un objeto UsuarioSistema y una referencia al siguiente nodo.
    public class NodoUsuario
    {
        public UsuarioSistema Usuario { get; set; } 
        public NodoUsuario Siguiente { get; set; } 

        public NodoUsuario(UsuarioSistema usuario)
        {
            Usuario = usuario;
            Siguiente = null; 
        }
    }
}
