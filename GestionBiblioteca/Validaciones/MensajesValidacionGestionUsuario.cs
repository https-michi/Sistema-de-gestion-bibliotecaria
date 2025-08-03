using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Validaciones
{
    public static class MensajesValidacionGestionUsuario
    {
        public static string CamposVacios() =>
            "Por favor, complete todos los campos.";

        public static string UsuarioNoEncontrado() =>
            "Usuario no encontrado.";

        public static string UsuarioRegistradoExitosamente() =>
            "Usuario de negocio registrado exitosamente.";

        public static string UsuarioEditadoExitosamente() =>
            "Usuario editado exitosamente.";

        public static string UsuarioEliminadoExitosamente() =>
            "Usuario eliminado exitosamente.";

        public static string ErrorAlEliminarUsuario() =>
            "No se encontró el usuario para eliminar.";
    }

}
