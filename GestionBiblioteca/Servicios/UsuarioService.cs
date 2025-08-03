using GestionBiblioteca.Estructuras.Usuarios;
using GestionBiblioteca.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace GestionBiblioteca.Servicios
{
    // Servicio encargado de gestionar las operaciones relacionadas con usuarios: 
    // agregar, validar credenciales y persistir datos.
    public class UsuarioService
    {
        // Lista enlazada para almacenar usuarios en memoria.
        public ListaUsuarios listaUsuarios;

        public UsuarioService()
        {
            // Inicializa la lista de usuarios
            listaUsuarios = new ListaUsuarios();

        }

        // Agrega un nuevo usuario tanto a la lista en memoria como a un archivo de texto.
        public void AgregarUsuario(UsuarioSistema usuario)
        {   // Añade el usuario a la lista enlazada.
            listaUsuarios.AgregarUsuario(usuario);
            // Persiste el usuario en un archivo.
            GuardarUsuarioEnArchivo(usuario);
        }

        private void GuardarUsuarioEnArchivo(UsuarioSistema usuario)
        {
            string archivoRuta = @"Data\UsuarioSistema.txt";
            string linea = $"{usuario.Id},{usuario.Numero},{usuario.Nombres},{usuario.apellido_paterno},{usuario.apellido_materno},{usuario.Correo},{usuario.NumeroContacto},{usuario.FechaRegistro},{usuario.UsuarioSistemaNombre},{usuario.Contrasena},{usuario.EsEmpleado},{usuario.EstadoEmpleado}";
            Directory.CreateDirectory(Path.GetDirectoryName(archivoRuta));
            File.AppendAllText(archivoRuta, linea + Environment.NewLine);
        }

 

        // Valida las credenciales comparando con los datos en memoria y en el archivo
        public bool ValidarCredenciales(string usuarioNombre, string contrasena)
        {
            NodoUsuario actual = listaUsuarios.cabeza;

            while (actual != null)
            {
                if (actual.Usuario.UsuarioSistemaNombre == usuarioNombre && actual.Usuario.Contrasena == contrasena)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }

            return ValidarCredencialesEnArchivo(usuarioNombre, contrasena);
        }
        // Valida las credenciales en el archivo de texto
        private bool ValidarCredencialesEnArchivo(string usuarioNombre, string contrasena)
        {
            string archivoRuta = @"Data\UsuarioSistema.txt";

            if (!File.Exists(archivoRuta))
            {
                return false;
            }
            string[] lineas = File.ReadAllLines(archivoRuta);
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');
                string usuarioArchivo = campos[8];
                string contrasenaArchivo = campos[9];

                if (usuarioArchivo == usuarioNombre && contrasenaArchivo == contrasena)
                {
                    return true;
                }
            }
            return false;
        }

        public int ObtenerNuevoId()
        {
            string archivoRuta = @"Data\UsuarioSistema.txt";
            if (!File.Exists(archivoRuta))
            {
                return 1;
            }
            string[] lineas = File.ReadAllLines(archivoRuta);
            if (lineas.Length == 0)
            {
                return 1;
            }
            string ultimaLinea = lineas[lineas.Length - 1];
            string[] campos = ultimaLinea.Split(',');
            int ultimoId = int.Parse(campos[0]);
            return ultimoId + 1;
        }
    }
}
