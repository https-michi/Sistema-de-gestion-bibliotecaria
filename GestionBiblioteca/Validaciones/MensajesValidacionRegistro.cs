using System.Text.RegularExpressions;

namespace GestionBiblioteca.Validaciones
{
    public static class MensajesValidacionRegistro
    {
        public static string UsuarioYContrasenaVacios() =>
            "Ingrese el nombre de usuario y la contraseña.";

        public static string UsuarioVacio() =>
            "Ingrese un nombre de usuario.";

        public static string ContrasenaVacia() =>
            "Ingrese una contraseña.";

        public static string ContrasenaCorta() =>
            "La contraseña debe tener + 5 caracteres.";

        public static string DniVacio() =>
            "Por favor, ingrese un DNI.";

        public static string DniInvalido() =>
            "El DNI debe contener 8 números.";

        public static string CorreoVacio() =>
            "Ingrese un correo electrónico.";

        public static string CorreoInvalido() =>
            "Ingrese un correo válido.";

        public static string NumeroContactoVacio() =>
            "Ingrese un número de contacto.";

        public static string NumeroContactoInvalido() =>
            "El número debe contener 9 digitos.";

        public static string ValidarCampos(string usuarioNombre, string contrasena, string dni, string correo, string numeroContacto)
        {
            string errores = "";

            if (string.IsNullOrEmpty(usuarioNombre))
                errores += UsuarioVacio() + "\n";

            if (string.IsNullOrEmpty(contrasena))
                errores += ContrasenaVacia() + "\n";
            else if (contrasena.Length < 5)
                errores += ContrasenaCorta() + "\n";

            if (string.IsNullOrEmpty(dni))
                errores += DniVacio() + "\n";
            else if (!Regex.IsMatch(dni, @"^\d{8}$"))
                errores += DniInvalido() + "\n";

            if (string.IsNullOrEmpty(correo))
                errores += CorreoVacio() + "\n";
            else if (!Regex.IsMatch(correo, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
                errores += CorreoInvalido() + "\n";

            if (string.IsNullOrEmpty(numeroContacto))
                errores += NumeroContactoVacio() + "\n";
            else if (!Regex.IsMatch(numeroContacto, @"^\d{9}$"))
                errores += NumeroContactoInvalido() + "\n";

            return errores;
        }
    }
}
