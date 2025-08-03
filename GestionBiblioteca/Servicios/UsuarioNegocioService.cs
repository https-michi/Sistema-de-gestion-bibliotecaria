using GestionBiblioteca.Estructuras.Usuarios;
using GestionBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Servicios
{
    public class UsuarioNegocioService
    {
        public ListaUsuariosNegocio listaUsuarios;

        // Constructor que inicializa la lista de usuarios y carga los datos desde el archivo
        public UsuarioNegocioService()
        {
            listaUsuarios = new ListaUsuariosNegocio();
            CargarUsuariosEnListaDesdeArchivo();
        }

        //------------------------------------------------------------------------------------------------
        // Agrega un nuevo usuario a la lista y lo guarda en el archivo
        // Lanza una excepción si el usuario ya existe
        public void AgregarUsuarioNegocio(UsuarioNegocio usuario)
        {

            if (UsuarioExiste(usuario.Numero, usuario.NumeroContacto))
            {
                throw new InvalidOperationException("El usuario ya está registrado.");
            }
            listaUsuarios.AgregarUsuario(usuario); 
            GuardarUsuarioNegocioEnArchivo(usuario); 
        }
        // Guarda un usuario específico en el archivo
        private void GuardarUsuarioNegocioEnArchivo(UsuarioNegocio usuario)
        {
            string archivoRuta = @"Data\UsuarioNegocio.txt";
            string linea = $"{usuario.Id},{usuario.Numero},{usuario.Nombres},{usuario.apellido_paterno},{usuario.apellido_materno},{usuario.Correo},{usuario.NumeroContacto},{usuario.FechaRegistro},{usuario.TipoUsuario}";
            Directory.CreateDirectory(Path.GetDirectoryName(archivoRuta));
            File.AppendAllText(archivoRuta, linea + Environment.NewLine);
        }
        //------------------------------------------------------------------------------------------------





        //------------------------------------------------------------------------------------------------
        // Verifica si un usuario existe en la lista enlazada o en el archivo
        public bool UsuarioExiste(string dni, string contacto)
        {
            // Verificar primero en la lista enlazada
            NodoUsuarioNegocio actual = listaUsuarios.cabeza;
            while (actual != null)
            {
                if (actual.Usuario.Numero == dni || actual.Usuario.NumeroContacto == contacto)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            // Si no está en la lista, buscar en el archivo
            return UsuarioExisteEnArchivo(dni, contacto);
        }

        // Verifica si un usuario existe en el archivo
        private bool UsuarioExisteEnArchivo(string dni, string contacto)
        {
            UsuarioNegocio[] usuarios = CargarUsuariosDesdeArchivo();
            return usuarios.Any(u => u.Numero == dni || u.NumeroContacto == contacto);
        }
        //------------------------------------------------------------------------------------------------





        //------------------------------------------------------------------------------------------------
        // Busca un usuario por su ID en la lista enlazada o en el archivo
        public UsuarioNegocio BuscarUsuarioPorId(int id)
        {
            NodoUsuarioNegocio actual = listaUsuarios.cabeza;
            while (actual != null)
            {
                if (actual.Usuario.Id == id)
                {
                    return actual.Usuario;
                }
                actual = actual.Siguiente;
            }

            return BuscarUsuarioPorIdEnArchivo(id);
        }

        // Busca un usuario por su ID en el archivo
        private UsuarioNegocio BuscarUsuarioPorIdEnArchivo(int id)
        {
            UsuarioNegocio[] usuarios = CargarUsuariosDesdeArchivo();
            return usuarios.FirstOrDefault(u => u.Id == id);
        }
        //------------------------------------------------------------------------------------------------




        //------------------------------------------------------------------------------------------------
        // Guarda todos los usuarios en el archivo, sobrescribiendo el contenido
        public void GuardarUsuariosEnArchivo(UsuarioNegocio[] usuarios)
        {
            string[] lineas = new string[usuarios.Length];
            for (int i = 0; i < usuarios.Length; i++)
            {
                var usuario = usuarios[i];
                lineas[i] = $"{usuario.Id},{usuario.Numero},{usuario.Nombres},{usuario.apellido_paterno},{usuario.apellido_materno},{usuario.Correo},{usuario.NumeroContacto},{usuario.FechaRegistro},{usuario.TipoUsuario}";
            }
            File.WriteAllLines(@"Data\UsuarioNegocio.txt", lineas);
        }
        //------------------------------------------------------------------------------------------------





        //------------------------------------------------------------------------------------------------

        // Carga los usuarios desde el archivo y los agrega a la lista enlazada
        private void CargarUsuariosEnListaDesdeArchivo()
        {
            UsuarioNegocio[] usuarios = CargarUsuariosDesdeArchivo();
            foreach (var usuario in usuarios)
            {
                listaUsuarios.AgregarUsuario(usuario);
            }
        }

        // Carga los usuarios desde un archivo de texto
        public UsuarioNegocio[] CargarUsuariosDesdeArchivo()
        {
            string archivoRuta = @"Data\UsuarioNegocio.txt";
            if (!File.Exists(archivoRuta)) return new UsuarioNegocio[0]; ;

            string[] lineas = File.ReadAllLines(archivoRuta);
            UsuarioNegocio[] usuarios = new UsuarioNegocio[lineas.Length];

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');

                if (campos.Length == 9)
                {
                    DateTime fechaRegistro = DateTime.TryParse(campos[7], out DateTime fechaValida)
                        ? fechaValida
                        : DateTime.MinValue;

                    usuarios[i] = new UsuarioNegocio
                    {
                        Id = int.Parse(campos[0]),
                        Numero = campos[1],
                        Nombres = campos[2],
                        apellido_paterno = campos[3],
                        apellido_materno = campos[4],
                        Correo = campos[5],
                        NumeroContacto = campos[6],
                        FechaRegistro = fechaRegistro,
                        TipoUsuario = campos[8]
                    };
                }
            }

            return usuarios;
        }
        //------------------------------------------------------------------------------------------------



        //------------------------------------------------------------------------------------------------
        // Obtiene un nuevo ID único para un usuario
        public int ObtenerNuevoId()
        {
            string archivoRuta = @"Data\UsuarioNegocio.txt";
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