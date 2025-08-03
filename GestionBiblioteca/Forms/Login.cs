
using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Forms;
using GestionBiblioteca.Servicios;
using System.Windows.Forms;
using System;
using GestionBiblioteca.Validaciones;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace GestionBiblioteca
{
    public partial class Login : Form
    {
        private UsuarioService usuarioService;
        private FormDesign formDesign;
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;

        private string contrasenaReal = "";
        private bool isTextChanging = false;

        public Login()
        {
            InitializeComponent();
            txtContrasena.TextChanged += new EventHandler(txtContrasena_TextChanged);
            usuarioService = new UsuarioService();
            ConfigurarEstilos();
            this.Icon = new Icon(@"Resources\IconoBiblio.ico");


        }
      
        private void txtCrearCuenta_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }


        private async void btnLoginSistema_Click(object sender, EventArgs e)
        {
            lblValidarLogin.Text = "";

            string usuarioNombre = txtUsuario.Text;
            string contrasena = contrasenaReal;

            lblValidarLogin.Text =
                string.IsNullOrEmpty(usuarioNombre) && string.IsNullOrEmpty(contrasena) ? MensajesValidacionLogin.UsuarioYContrasenaVacios() :
                string.IsNullOrEmpty(usuarioNombre) ? MensajesValidacionLogin.UsuarioVacio() :
                string.IsNullOrEmpty(contrasena) ? MensajesValidacionLogin.ContrasenaVacia() : "";

            if (!string.IsNullOrEmpty(lblValidarLogin.Text))
            {
                await Task.Delay(3000);
                lblValidarLogin.Text = "";
                return;
            }

            if (usuarioService.ValidarCredenciales(usuarioNombre, contrasena))
            {
                Dashboard homeForm = new Dashboard();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                lblValidarLogin.Text = MensajesValidacionLogin.CredencialesInvalidas();
                await Task.Delay(3000);
                lblValidarLogin.Text = "";
            }
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
        private void pbxVerContrasena_Click(object sender, EventArgs e)
        {
            // Por implementar      
        }
        private void ConfigurarEstilos()
        {
            formDesign = new FormDesign();
            this.FormBorderStyle = FormBorderStyle.None;
            formDesign.AplicarBordesCurvos(this, 30);
            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtUsuario, 10);
            textBoxDesign.AplicarBordesCurvos(txtContrasena, 10);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnLoginSistema, 10);
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelImgLogin, 15);
        }
    }
}

