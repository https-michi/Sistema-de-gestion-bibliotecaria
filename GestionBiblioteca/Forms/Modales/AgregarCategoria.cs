using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Models;
using GestionBiblioteca.Servicios;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca.Forms.Modales
{
    public partial class AgregarCategoria : Form
    {
        private CategoriaService categoriaService;
        private FormDesign formDesign;
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;

        public Categoria CategoriaSeleccionada { get; set; }

        // Define tamaños iniciales para el formulario y los paneles
        private readonly Size tamañoInicialFormulario;
        private readonly Size tamañoExpandidoFormulario;

        public AgregarCategoria()
        {
            InitializeComponent();
            categoriaService = new CategoriaService();
            listBoxResultados.Visible = false;
            lblNoEncontrado.Visible = false;        
            panelAgregarCategoria.Visible = false;
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

            Categoria[] categorias = categoriaService.BuscarCategoriasPorNombre(textoBuscado);
            listBoxResultados.Items.Clear();
            if (categorias.Length > 0)
            {
                foreach (Categoria categoria in categorias)
                {
                    listBoxResultados.Items.Add(categoria.Nombre);
                }
                AjustarTamanoListBox(listBoxResultados);
                listBoxResultados.Visible = true;
                lblNoEncontrado.Visible = false;
            }
            else
            {
                lblNoEncontrado.Text = "No se encontró la categoría. ¿Deseas agregarla?";
                lblNoEncontrado.Visible = true;
                listBoxResultados.Visible = false;
            }
        }

        private void lblNoEncontrado_Click(object sender, EventArgs e)
        {
            panelAgregarCategoria.Visible = true; 
            this.Size = tamañoExpandidoFormulario; 
            formDesign.AplicarBordesCurvos(this, 30);
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private async Task MostrarMensajeConDelay(string mensaje, Color color)
        {
            lblValidaciones.Text = mensaje;
            lblValidaciones.ForeColor = color;
            await Task.Delay(3000);  
            lblValidaciones.Text = string.Empty;
        }

        private async void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                await MostrarMensajeConDelay("Complete todos los campos.", Color.Red);
                return;
            }

            try
            {
                Categoria nuevaCategoria = new Categoria
                {
                    Id = categoriaService.ObtenerNuevoId(),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                categoriaService.AgregarCategoria(nuevaCategoria);
                LimpiarFormulario();
                await MostrarMensajeConDelay("Categoría registrada exitosamente.", Color.Green);
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

        private void btnAsignarCategoria_Click(object sender, EventArgs e)
        {
            if (CategoriaSeleccionada != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void listBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedItem != null)
            {
                string textoSeleccionado = listBoxResultados.SelectedItem.ToString();
                Categoria[] categorias = categoriaService.BuscarCategoriasPorNombre(textoSeleccionado);
                if (categorias.Length > 0)
                {
                    Categoria categoria = categorias[0];
                    CategoriaSeleccionada = categoria;
                }
            }
        }

        private void btnCerrarModalAgregarCategoria_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtBuscar.Clear();
            listBoxResultados.Items.Clear();
            listBoxResultados.Visible = false;
            lblNoEncontrado.Visible = false;
            panelAgregarCategoria.Visible = false;
            this.Size = tamañoInicialFormulario;
        }

        private void ConfigurarEstilos()
        {
            formDesign = new FormDesign();
            formDesign.AplicarBordesCurvos(this, 30);
            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtBuscar, 10);
            textBoxDesign.AplicarBordesCurvos(txtDescripcion, 10);
            textBoxDesign.AplicarBordesCurvos(txtNombre, 10);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnAsignarCategoria, 10);
            buttonDesign.AplicarBordesCurvos(btnRegistrarCategoria, 10);
            buttonDesign.AplicarBordesCurvos(btnCerrarModalAgregarCategoria, 10);
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelAgregarCategoria, 15);
            panelDesign.AplicarBordesCurvos(panelAsignarCategoria, 15);
            panelDesign.AplicarBordesCurvos(panelAgregarTitulo, 15);
            panelDesign.AplicarBordesCurvos(panelAsignarTitulo, 15);

        }
    }
}
