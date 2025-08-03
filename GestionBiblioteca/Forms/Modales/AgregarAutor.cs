using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Models;
using GestionBiblioteca.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca.Forms.Modales
{
    public partial class AgregarAutor : Form
    {
        private AutorService autorService;
        public Autor AutorSeleccionado { get; set; }

        private FormDesign formDesign;
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;

        // Define tamaños iniciales para el formulario y los paneles
        private readonly Size tamañoInicialFormulario;
        private readonly Size tamañoExpandidoFormulario;

        public AgregarAutor()
        {
            InitializeComponent();
            autorService = new AutorService();
            listBoxResultados.Visible = false;
            lblNoEncontrado.Visible = false;
            panelAgregarAutor.Visible = false;
            tamañoInicialFormulario = new Size(384, 432);
            tamañoExpandidoFormulario = new Size(744, 432);
            this.Size = tamañoInicialFormulario;
            lblNoEncontrado.Click += new EventHandler(lblNoEncontrado_Click);
            ConfigurarEstilos();
            formDesign = new FormDesign();
            formDesign.AplicarBordesCurvos(this, 30);

        }

    

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text;

            if (string.IsNullOrWhiteSpace(textoBuscado))
            {
                listBoxResultados.Visible = false;
                lblNoEncontrado.Visible = false;
                return;
            }

            Autor[] autores = autorService.BuscarAutoresPorNombre(textoBuscado);

            listBoxResultados.Items.Clear();

            if (autores.Length > 0)
            {
                foreach (Autor autor in autores)
                {
                    listBoxResultados.Items.Add(autor.Nombre);
                }
                AjustarTamanoListBox(listBoxResultados);
                listBoxResultados.Visible = true;
                lblNoEncontrado.Visible = false;
            }
            else
            {
                lblNoEncontrado.Text = "No se encontró el autor. ¿Deseas agregarlo?";
                lblNoEncontrado.Visible = true;
                listBoxResultados.Visible = false;
            }
        }


        private void AjustarTamanoListBox(ListBox listBox)
        {
            int margen = 10;
            int alturaTotal = (listBox.ItemHeight * listBox.Items.Count) + margen;

            if (alturaTotal > 200)
            {
                alturaTotal = 200;
            }

            listBox.Height = alturaTotal;
        }

        private void listBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedItem != null)
            {
                string textoSeleccionado = listBoxResultados.SelectedItem.ToString();
                Autor autor = autorService.BuscarAutoresPorNombre(textoSeleccionado).FirstOrDefault();
                if (autor != null)
                {
                    AutorSeleccionado = autor;
                }
            }
        }

        private void btnAsignarAutor_Click(object sender, EventArgs e)
        {
            if (AutorSeleccionado != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private async Task MostrarMensajeConDelay(string mensaje, Color color)
        {
            lblValidaciones.Text = mensaje;
            lblValidaciones.ForeColor = color;
            await Task.Delay(3000);
            lblValidaciones.Text = string.Empty;
        }
        private async void btnRegistrarAutor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                string.IsNullOrWhiteSpace(txtBiografia.Text))
            {
                await MostrarMensajeConDelay("Complete todos los campos.", Color.Red);
                return;
            }

            try
            {
                Autor nuevoAutor = new Autor
                {
                    Id = autorService.ObtenerNuevoId(),
                    Nombre = txtNombre.Text.Trim(),
                    Nacionalidad = txtNacionalidad.Text.Trim(),
                    FechaNacimiento = dtpFechaNacimiento.SelectionStart,
                    Biografia = txtBiografia.Text.Trim()
                };

                autorService.AgregarAutor(nuevoAutor);
                LimpiarFormulario();
                await MostrarMensajeConDelay("Autor registrado exitosamente.", Color.Green);

            }
            catch (InvalidOperationException ex)
            {
                await MostrarMensajeConDelay(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                await MostrarMensajeConDelay("Ocurrió un error inesperado: " + ex.Message, Color.Red);
            }
        }

        private void lblNoEncontrado_Click(object sender, EventArgs e)
        {
            panelAgregarAutor.Visible = true;
            this.Size = tamañoExpandidoFormulario;
            formDesign.AplicarBordesCurvos(this, 30);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnCerrarModalAgregarAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //------------------------------------------------------------------------------------------------
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtNacionalidad.Clear();
            dtpFechaNacimiento.SelectionStart = DateTime.Now;
            txtBiografia.Clear();
            txtBuscar.Clear();
            listBoxResultados.Visible = false;
            lblNoEncontrado.Visible = false;
            this.Size = tamañoInicialFormulario;
        }
        private void ConfigurarEstilos()
        {
            formDesign = new FormDesign();
            //this.FormBorderStyle = FormBorderStyle.None;
            formDesign.AplicarBordesCurvos(this, 30);
            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtBuscar, 10);
            textBoxDesign.AplicarBordesCurvos(txtNombre, 10);
            textBoxDesign.AplicarBordesCurvos(txtNacionalidad, 10);
            textBoxDesign.AplicarBordesCurvos(txtBiografia, 10);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnAsignarAutor, 10);
            buttonDesign.AplicarBordesCurvos(btnRegistrarAutor, 10);
            buttonDesign.AplicarBordesCurvos(btnCerrarModalAgregarAutor, 10);
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelAgregarAutor, 15);
            panelDesign.AplicarBordesCurvos(panelAsignarAutor, 15);
            panelDesign.AplicarBordesCurvos(panelAgregarTitulo, 15);
            panelDesign.AplicarBordesCurvos(panelAsignarTitulo, 15);
        }
    }
}
