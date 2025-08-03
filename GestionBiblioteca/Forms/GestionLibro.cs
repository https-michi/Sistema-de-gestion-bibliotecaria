using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Estructuras.Categorias;
using GestionBiblioteca.Forms.Modales;
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

namespace GestionBiblioteca.Forms
{
    public partial class GestionLibro : Form
    {
        //---------------------------------------------
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;
        //---------------------------------------------
        private LibroService libroService;
        private int idAutor;
        private int idCategoria;
        public GestionLibro()
        {
            InitializeComponent();
            libroService = new LibroService();
            ConfigurarEstilos();
            CargarLibrosEnDataGridView();
            DataGridDesign.AplicarEstiloDataGrid(dataGridViewListaLibros);
            dataGridViewListaLibros.SelectionChanged += DataGridViewListaLibros_SelectionChanged;


        }





        private async Task MostrarMensajeConDelay(string mensaje, Color color)
        {
            lblValidaciones.Text = mensaje;
            lblValidaciones.ForeColor = color;
            await Task.Delay(3000);
            lblValidaciones.Text = "";
        }


        private async void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtISBN.Text) ||
                string.IsNullOrEmpty(txtEditorial.Text) || string.IsNullOrEmpty(txtEdicion.Text) ||
                string.IsNullOrEmpty(txtCopias.Text) || string.IsNullOrEmpty(txtUbicacionFisica.Text))
            {
                await MostrarMensajeConDelay("Por favor, complete todos los campos.", Color.Red);
                return;
            }

            Libro nuevoLibro = new Libro
            {
                Id = libroService.ObtenerNuevoId(),
                Titulo = txtTitulo.Text,
                ISBN = txtISBN.Text,
                Editorial = txtEditorial.Text,
                Edicion = txtEdicion.Text,
                FechaPublicacion = dtpFechaPublicacion.SelectionStart,
                NumeroCopias = txtCopias.Text,
                UbicacionFisica = txtUbicacionFisica.Text,
                Disponible = true,
                FechaRegistro = DateTime.Now,
                Autor = new Autor { Id = idAutor },
                Categoria = new Categoria { Id = idCategoria }
            };

            try
            {
                libroService.AgregarLibro(nuevoLibro);
                CargarLibrosEnDataGridView();
                await MostrarMensajeConDelay("Libro registrado exitosamente.", Color.Green);
                LimpiarFormulario();
            }
            catch (InvalidOperationException ex)
            {
                await MostrarMensajeConDelay(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                await MostrarMensajeConDelay("Ha ocurrido un error: " + ex.Message, Color.Red);
            }
        }

        private async void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaLibros.CurrentRow == null)
            {
                await MostrarMensajeConDelay("Por favor, seleccione un libro para editar.", Color.Red);
                return;
            }
            int idLibro = (int)dataGridViewListaLibros.CurrentRow.Cells["Id"].Value;

            if (EstaEnPrestamo(idLibro))
            {
                await MostrarMensajeConDelay("El libro no puede ser editado porque está en préstamo.", Color.Red);
                return;
            }

            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtISBN.Text) ||
                string.IsNullOrEmpty(txtEditorial.Text) || string.IsNullOrEmpty(txtEdicion.Text) ||
                string.IsNullOrEmpty(txtCopias.Text) || string.IsNullOrEmpty(txtUbicacionFisica.Text))
            {
                await MostrarMensajeConDelay("Por favor, complete todos los campos.", Color.Red);
                return;
            }

            Libro[] libros = libroService.CargarLibrosDesdeArchivo();
            var libroAEditar = libros.FirstOrDefault(l => l.Id == idLibro);

            if (libroAEditar != null)
            {
                libroAEditar.Titulo = txtTitulo.Text;
                libroAEditar.ISBN = txtISBN.Text;
                libroAEditar.Editorial = txtEditorial.Text;
                libroAEditar.Edicion = txtEdicion.Text;
                libroAEditar.NumeroCopias = txtCopias.Text;
                libroAEditar.UbicacionFisica = txtUbicacionFisica.Text;

                libroAEditar.Autor = new Autor { Id = idAutor };
                libroAEditar.Categoria = new Categoria { Id = idCategoria };

                libroService.GuardarLibrosEnArchivo(libros);
                CargarLibrosEnDataGridView();
                LimpiarFormulario();
                await MostrarMensajeConDelay("Libro editado exitosamente.", Color.Green);
            }
            else
            {
                await MostrarMensajeConDelay("Libro no encontrado.", Color.Red);
            }
        }


        private async void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaLibros.CurrentRow == null)
            {
                await MostrarMensajeConDelay("Por favor, seleccione un libro para eliminar.", Color.Red);
                return;
            }

            int idLibro = (int)dataGridViewListaLibros.CurrentRow.Cells["Id"].Value;

            if (EstaEnPrestamo(idLibro))
            {
                await MostrarMensajeConDelay("El libro no puede ser eliminado porque está en préstamo.", Color.Red);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el libro con ID {idLibro}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            Libro[] libros = libroService.CargarLibrosDesdeArchivo();

            var libroAEliminar = libros.FirstOrDefault(l => l.Id == idLibro);

            if (libroAEliminar != null)
            {
                libros = libros.Where(l => l.Id != idLibro).ToArray();
                libroService.GuardarLibrosEnArchivo(libros);

                CargarLibrosEnDataGridView();
                LimpiarFormulario();
                await MostrarMensajeConDelay("Libro eliminado exitosamente.", Color.Green);

            }
            else
            {
                await MostrarMensajeConDelay("No se encontró el libro para eliminar.", Color.Red);
            }
        }
        private bool EstaEnPrestamo(int idLibro)
        {
            var prestamos = new PrestamoService().CargarListaPrestamosDesdeArchivo();
            return prestamos.Any(p => p.Libro.Id == idLibro && !p.EstaDevuelto);
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            AgregarAutor formulario = new AgregarAutor();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                Autor autor = formulario.AutorSeleccionado;
                if (autor != null)
                {
                    lblAsignarAutor.Text = autor.Nombre;
                    idAutor = autor.Id;
                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria formulario = new AgregarCategoria();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                Categoria categoria = formulario.CategoriaSeleccionada;
                if (categoria != null)
                {
                    lblAsignarCategoria.Text = categoria.Nombre;
                    idCategoria = categoria.Id;
                }
            }
        }
        private void DataGridViewListaLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaLibros.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dataGridViewListaLibros.CurrentRow;
                txtTitulo.Text = filaSeleccionada.Cells["Titulo"].Value?.ToString();
                txtISBN.Text = filaSeleccionada.Cells["ISBN"].Value?.ToString();
                txtEditorial.Text = filaSeleccionada.Cells["Editorial"].Value?.ToString();
                txtEdicion.Text = filaSeleccionada.Cells["Edicion"].Value?.ToString();
                txtCopias.Text = filaSeleccionada.Cells["NumeroCopias"].Value?.ToString();
                txtUbicacionFisica.Text = filaSeleccionada.Cells["UbicacionFisica"].Value?.ToString();

                var libroSeleccionado = (Libro)filaSeleccionada.DataBoundItem;
                idAutor = libroSeleccionado.Autor.Id;
                idCategoria = libroSeleccionado.Categoria.Id;

                lblAsignarAutor.Text = libroSeleccionado.Autor.Nombre;
                lblAsignarCategoria.Text = libroSeleccionado.Categoria.Nombre;
            }
        }

        private void CargarLibrosEnDataGridView()
        {
            LibroService librosService = new LibroService();
            Libro[] libros = librosService.CargarLibrosDesdeArchivo();
            dataGridViewListaLibros.DataSource = libros;

            dataGridViewListaLibros.Columns["Id"].HeaderText = "ID";
            dataGridViewListaLibros.Columns["Titulo"].HeaderText = "Título";
            dataGridViewListaLibros.Columns["ISBN"].HeaderText = "ISBN";
            dataGridViewListaLibros.Columns["Editorial"].HeaderText = "Editorial";
            dataGridViewListaLibros.Columns["Edicion"].HeaderText = "Edición";
            dataGridViewListaLibros.Columns["NumeroCopias"].HeaderText = "Copias";
            dataGridViewListaLibros.Columns["UbicacionFisica"].HeaderText = "Ubicación";
            dataGridViewListaLibros.Columns["FechaPublicacion"].HeaderText = "Fecha Publicación";
            dataGridViewListaLibros.Columns["Disponible"].HeaderText = "Disponible";
            dataGridViewListaLibros.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
            dataGridViewListaLibros.Columns["NombreAutor"].HeaderText = "Autor";
            dataGridViewListaLibros.Columns["NombreCategoria"].HeaderText = "Categoria";
            dataGridViewListaLibros.ReadOnly = true;

            dataGridViewListaLibros.Columns["Autor"].Visible = false;
            dataGridViewListaLibros.Columns["Categoria"].Visible = false;

        }

        //------------------------------------------------------------------------------------------------
        private void ConfigurarEstilos()
        {
            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtTitulo, 10);
            textBoxDesign.AplicarBordesCurvos(txtISBN, 10);
            textBoxDesign.AplicarBordesCurvos(txtEditorial, 10);
            textBoxDesign.AplicarBordesCurvos(txtEdicion, 10);
            textBoxDesign.AplicarBordesCurvos(txtCopias, 10);
            textBoxDesign.AplicarBordesCurvos(txtUbicacionFisica, 10);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnAgregarAutor, 10);
            buttonDesign.AplicarBordesCurvos(btnAgregarCategoria, 10);
            buttonDesign.AplicarBordesCurvos(btnGuardarLibro, 20);
            buttonDesign.AplicarBordesCurvos(btnEditarLibro, 20);
            buttonDesign.AplicarBordesCurvos(btnEliminarLibro, 20);
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelRegistroLibro, 20);
            panelDesign.AplicarBordesCurvos(panelBusquedaLibro, 20);
            panelDesign.AplicarBordesCurvos(panelValidaciones, 20);
            panelDesign.AplicarBordesCurvos(panelAcciones, 20);
            panelDesign.AplicarBordesCurvos(panelListaLibro, 20);
        }

        private void LimpiarFormulario()
        {
            txtTitulo.Clear();
            txtISBN.Clear();
            txtEditorial.Clear();
            txtEdicion.Clear();
            txtCopias.Clear();
            txtUbicacionFisica.Clear();
            lblAsignarAutor.Text = "Autor: ";
            lblAsignarCategoria.Text = "Categoría: ";
        }

        private void lblAsignarAutor_Click(object sender, EventArgs e)
        {

        }

        private void AsignarCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
