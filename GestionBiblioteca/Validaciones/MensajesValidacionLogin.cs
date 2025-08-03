using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Validaciones
{
    public static class MensajesValidacionLogin
    {
        public static string UsuarioYContrasenaVacios()
        {
            return "Ingrese su usuario y contraseña.";
        }

        public static string UsuarioVacio()
        {
            return "Ingrese su usuario.";
        }

        public static string ContrasenaVacia()
        {
            return "Ingrese su contraseña.";
        }

        public static string CredencialesInvalidas()
        {
            return "Credenciales inválidas.Inténtelo de nuevo.";
        }
    }

}
