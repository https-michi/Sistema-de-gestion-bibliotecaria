using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GestionBiblioteca.CustomStyles;
using System.Web.UI.Design.WebControls;
using GestionBiblioteca.Validaciones;
using System.Drawing.Drawing2D;

namespace GestionBiblioteca.Forms
{
    public partial class Dashboard : Form
    {
        private FormDesign formDesign;
        private PanelDesign panelDesign;



        public Dashboard()
        {
            InitializeComponent();
            //ContraerMenu();
            ConfigurarEstilos();
            AbrirFormsHijos(new Home());
            this.DoubleBuffered = true; 
            this.Icon = new Icon(@"Resources\IconoBiblio.ico");

            //logoBiblioteca.Visible = false;
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
        //        Color.FromArgb(128, 64, 64, 128), // Morado oscuro semitransparente
        //        Color.FromArgb(128, 64, 64, 128), // Morado claro semitransparente
        //        LinearGradientMode.Vertical)) // Degradado vertical
        //    {
        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}


        private void btnMenu_Click(object sender, EventArgs e)
        {
            //ContraerMenu();
        }
        private void ConfigurarEstilos()
        {
            // Bordes del form
            formDesign = new FormDesign();
            this.FormBorderStyle = FormBorderStyle.None;
            formDesign.AplicarBordesCurvos(this, 40);
            // Bordes del panel
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelMenu, 20);
            panelDesign.AplicarBordesCurvos(panelContenedor, 15);
            panelDesign.AplicarBordesCurvos(panelBarraTitulo, 15);
            panelDesign.AplicarBordesCurvos(panelMultiuso, 15);
            panelDesign.AplicarBordesCurvos(panel1, 15);

           

        }
        private void ContraerMenu()
        {
            //extraemos 
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                logoBiblioteca.Visible = false;
                btnMenu.Location = new Point(23, 12);
                foreach (Button menubtn in panelMenu.Controls.OfType<Button>())
                {
                    menubtn.Text = "";  
                    menubtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menubtn.Padding = new Padding(0);
                }
            }
            //expandimos 
            else
            {
                panelMenu.Width = 230;
                logoBiblioteca.Visible = true;
                //btnMenu.Dock = DockStyle.None;
                btnMenu.Location = new Point(23, 12);
                foreach (Button menubtn in panelMenu.Controls.OfType<Button>())
                {
                    if (menubtn.Tag != null)
                    {
                        menubtn.Text = "   " + menubtn.Tag.ToString();
                    }
                    menubtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menubtn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormsHijos(object formsHijos)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form form = formsHijos as Form;

            if (form is IFormularioConPanel hijoConPanel)
            {
                hijoConPanel.SetPanelContenedor(this.panelContenedor);
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }

        private void btnGestionLibros_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new GestionLibro());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Home());
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new GestionUsuarioNegocio());
        }
        private void btnPrestamoLibro_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new GestionPrestamos());
        }
        private void btnSolicitudLibro_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new GestionSolicitudes()); 
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Cerrar el formulario actual 
            this.Hide();
            // this.Close() si quieres cerrar el Dashboard completamente
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Normal;
            //}
        }

        private void logoBiblioteca_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Home());
        }
    }
}
