using System;

namespace GestionBiblioteca.Models
{
    public class UsuarioNegocio : Usuario
    {
        public string TipoUsuario { get; set; }
        //public string NumeroContacto { get; set; }
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Nombres { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public string NumeroContacto { get; set; }
    }


    public class UsuarioSistema : Usuario
    {
        public string UsuarioSistemaNombre { get; set; }
        public string Contrasena { get; set; }
        public bool EsEmpleado { get; set; }
        public EstadoEmpleado EstadoEmpleado { get; set; } = EstadoEmpleado.Activo;
    }


    public enum EstadoEmpleado
    {
        Activo,
        Inactivo
    }

    /*
    public class Usuario
    {
        public int Id { get; set; }
        public string numero { get; set; } 
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string usuario { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; } 
        public bool esEmpleado { get; set; }
        public bool estadoEmpleado { get; set; } 
        public string fechaRegistro { get; set; }

    }*/
}
