using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Estructuras.Usuarios;
using GestionBiblioteca.Models;
using GestionBiblioteca.Servicios;
using GestionBiblioteca.Validaciones;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca.Forms
{
    public partial class Register : Form
    {
        private UsuarioService usuarioService;

        private string contrasenaReal = "";
        private bool isTextChanging = false;
        private FormDesign formDesign;
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;

        public Register()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            ConfigurarEstilos();
            txtContrasena.TextChanged += new EventHandler(txtContrasena_TextChanged);
            this.Icon = new Icon(@"Resources\IconoBiblio.ico");
        }

        // Evento del botón de registro. 
        // Valida los datos ingresados, crea un nuevo usuario 
        // y lo guarda tanto en memoria como en archivo.

        private async void btnRegistrarUsuarioSistema_Click(object sender, EventArgs e)
        {
            lblValidarRegistro.Text = "";
            // Captura los datos ingresados por el usuario.
            string usuarioNombre = txtUsuario.Text;
            string contrasena = contrasenaReal;
            string dni = txtDni.Text;
            string correo = txtCorreo.Text;
            string numeroContacto = txtNumeroContacto.Text;

            string errores = MensajesValidacionRegistro.ValidarCampos(usuarioNombre, contrasena, dni, correo, numeroContacto);
            if (!string.IsNullOrEmpty(errores))
            {
                lblValidarRegistro.Text = errores;
                await Task.Delay(3000);
                lblValidarRegistro.Text = "";
                return;
            }
            // Crea un nuevo usuario con los datos ingresados
            // y valores generados automáticamente.
            UsuarioSistema nuevoUsuario = new UsuarioSistema
            {
                Id = usuarioService.ObtenerNuevoId(),
                Numero = dni,
                Nombres = txtNombre.Text,
                apellido_paterno = txtApellidoPaterno.Text,
                apellido_materno = txtApellidoMaterno.Text,
                Correo = correo,
                NumeroContacto = numeroContacto,
                FechaRegistro = DateTime.Now,
                UsuarioSistemaNombre = usuarioNombre,
                Contrasena = contrasena,
                EsEmpleado = true,
                EstadoEmpleado = EstadoEmpleado.Activo
            };
            // Agrega el usuario al servicio y lo persiste en un archivo.
            usuarioService.AgregarUsuario(nuevoUsuario);
            // Mostrar usuarios en consola
            usuarioService.listaUsuarios.MostrarUsuarios(); // Llama al método para mostrar usuarios

            lblValidarRegistro.Text = "Usuario registrado correctamente";
            await Task.Delay(2000);
            LimpiarFormulario();
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }


        private void ConfigurarEstilos()
        {
            formDesign = new FormDesign();
            this.FormBorderStyle = FormBorderStyle.None;
            formDesign.AplicarBordesCurvos(this, 30);
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelImgRegister, 15);
            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtUsuario, 10);
            textBoxDesign.AplicarBordesCurvos(txtContrasena, 10);
            textBoxDesign.AplicarBordesCurvos(txtDni, 10);
            textBoxDesign.AplicarBordesCurvos(txtNombre, 10);
            textBoxDesign.AplicarBordesCurvos(txtCorreo, 10);
            textBoxDesign.AplicarBordesCurvos(txtNumeroContacto, 10);
            textBoxDesign.AplicarBordesCurvos(txtApellidoMaterno, 10);
            textBoxDesign.AplicarBordesCurvos(txtApellidoPaterno, 10);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnRegistrarUsuarioSistema, 10);
        } 

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (isTextChanging) return;

            isTextChanging = true;

            if (txtContrasena.Text.Length > contrasenaReal.Length)
            {
                string nuevoCaracter = txtContrasena.Text.Substring(contrasenaReal.Length);
                contrasenaReal += nuevoCaracter;
            }
            else if (txtContrasena.Text.Length < contrasenaReal.Length)
            {
                contrasenaReal = contrasenaReal.Substring(0, txtContrasena.Text.Length);
            }

            txtContrasena.Text = new string('*', contrasenaReal.Length);

            txtContrasena.SelectionStart = contrasenaReal.Length;
            txtContrasena.SelectionLength = 0;

            isTextChanging = false;
        }

        private void LimpiarFormulario()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtNumeroContacto.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            contrasenaReal = "";  
        }

        private void txtVolverLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}

