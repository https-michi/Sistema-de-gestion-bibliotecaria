using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Models;
using GestionBiblioteca.Servicios;
using GestionBiblioteca.Validaciones;
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
    public partial class GestionPrestamos : Form, IFormularioConPanel
    {

        public Libro LibroSeleccionado { get; private set; }
        public Usuario UsuarioSeleccionado { get; private set; }
        private PrestamoService prestamoService;
        private Panel panelContenedor;


        private int idLibro;
        private int idUsuario;

        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;


        public GestionPrestamos()
        {
            InitializeComponent();
            prestamoService = new PrestamoService();


            listBoxLibros.Visible = false;
            listBoxUsuarios.Visible = false;
            lblNoLibroEncontrado.Visible = false;
            lblNoUsuarioEncontrado.Visible = false;
            //lblLibroSeleccionado.Visible = false;
            //lblUsuarioSeleccionado.Visible = false;
            CargarPrestamosEnDataGridView();
            ConfigurarEstilos();
            DataGridDesign.AplicarEstiloDataGrid(dataGridViewListaPrestamos);


            dataGridViewListaPrestamos.SelectionChanged += DataGridViewListaPrestamos_SelectionChanged;


        }


        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            string tituloBuscado = txtBuscarLibro.Text;

            listBoxLibros.Items.Clear();
            lblNoLibroEncontrado.Visible = false;

            if (!string.IsNullOrWhiteSpace(tituloBuscado))
            {
                Libro[] libros = prestamoService.BuscarLibrosPorTitulo(tituloBuscado);

                if (libros.Length > 0)
                {
                    foreach (var libro in libros)
                    {
                        listBoxLibros.Items.Add(libro.Titulo);
                    }
                    listBoxLibros.Visible = true;

                    AjustarTamanoListBox(listBoxLibros);
                }
                else
                {
                    listBoxLibros.Visible = false;
                    lblLibroSeleccionado.Visible = true;
                    lblNoLibroEncontrado.Visible = true;
                }
            }
            else
            {
                listBoxLibros.Visible = false;
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            string nombreBuscado = txtBuscarUsuario.Text;

            listBoxUsuarios.Items.Clear();
            lblNoUsuarioEncontrado.Visible = false;

            if (!string.IsNullOrWhiteSpace(nombreBuscado))
            {
                Usuario[] usuarios = prestamoService.BuscarUsuariosPorNombre(nombreBuscado);

                if (usuarios.Length > 0)
                {
                    foreach (var usuario in usuarios)
                    {
                        listBoxUsuarios.Items.Add(usuario.Nombres);
                    }
                    listBoxUsuarios.Visible = true;

                    AjustarTamanoListBox(listBoxUsuarios);
                }
                else
                {

                    listBoxUsuarios.Visible = false;
                    lblNoUsuarioEncontrado.Visible = true;
                    lblUsuarioSeleccionado.Visible = true;
                }
            }
            else
            {
                listBoxUsuarios.Visible = false;
            }
        }


        private void listBoxLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLibros.SelectedItem != null)
            {
                string textoSeleccionado = listBoxLibros.SelectedItem.ToString();
                Libro libro = prestamoService.BuscarLibrosPorTitulo(textoSeleccionado).FirstOrDefault();
                if (libro != null)
                {
                    LibroSeleccionado = libro;
                }
            }

        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                string textoSeleccionado = listBoxUsuarios.SelectedItem.ToString();
                Usuario usuario = prestamoService.BuscarUsuariosPorNombre(textoSeleccionado).FirstOrDefault();
                if (usuario != null)
                {
                    UsuarioSeleccionado = usuario;
                }
            }

        }

        private async Task MostrarMensajeConDelay(string mensaje, Color color)
        {
            lblValidaciones.Text = mensaje;
            lblValidaciones.ForeColor = color;
            lblValidaciones.Visible = true;
            await Task.Delay(3000);
            lblValidaciones.Visible = false;
            lblValidaciones.Text = string.Empty;
        }


        private async void btnAsignarLibro_Click(object sender, EventArgs e)
        {
            if (LibroSeleccionado != null)
            {
                lblLibroSeleccionado.Text = $"Libro: {LibroSeleccionado.Titulo}";
                listBoxLibros.Visible = false;
                txtBuscarLibro.Clear();
                await MostrarMensajeConDelay("Libro asignado correctamente.", Color.Green);

            }
            else
            {
                await MostrarMensajeConDelay("Por favor, seleccione un libro de la lista.", Color.Red);
            }
        }

        private async void btnAsignarUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSeleccionado != null)
            {
                lblUsuarioSeleccionado.Text = $"Usuario: {UsuarioSeleccionado.Nombres}";
                listBoxUsuarios.Visible = false;
                txtBuscarUsuario.Clear();
                await MostrarMensajeConDelay("Usuario asignado correctamente.", Color.Green);

            }
            else
            {
                await MostrarMensajeConDelay("Por favor, seleccione un usuario de la lista.", Color.Red);
            }
        }



        private async void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (UsuarioSeleccionado != null &&
                LibroSeleccionado != null &&
                dtpFechaPrestamo.SelectionStart != DateTime.MinValue &&
                dtpFechaDevolucion.SelectionStart != DateTime.MinValue)
            {
                if (dtpFechaDevolucion.SelectionStart < dtpFechaPrestamo.SelectionStart)
                {
                    await MostrarMensajeConDelay("La fecha de devolución debe ser posterior a la fecha de préstamo.", Color.Red);
                    return;
                }

                bool resultado = prestamoService.AgregarPrestamo(
                    UsuarioSeleccionado,
                    LibroSeleccionado,
                    dtpFechaPrestamo.SelectionStart,
                    dtpFechaDevolucion.SelectionStart
                );

                if (resultado)
                {
                    lblLibroSeleccionado.Text = "";
                    lblUsuarioSeleccionado.Text = "";
                    dtpFechaPrestamo.SelectionStart = DateTime.Today;
                    dtpFechaDevolucion.SelectionStart = DateTime.Today;
                    CargarPrestamosEnDataGridView();
                    await MostrarMensajeConDelay("Préstamo agregado con éxito.", Color.Green);
                }
                else
                {
                    await MostrarMensajeConDelay("El libro ya fue prestado.", Color.Red);
                }
            }
            else
            {
                await MostrarMensajeConDelay("Por favor, complete todos los campos.", Color.Red);
            }
        }

        private async void btnAcatualizarPrestamo_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaPrestamos.CurrentRow == null)
            {
                await MostrarMensajeConDelay("Por favor, seleccione un préstamo de la lista.", Color.Red);
                return;
            }
            if (dtpFechaDevolucion.SelectionStart < dtpFechaPrestamo.SelectionStart)
            {
                await MostrarMensajeConDelay("La fecha de devolución debe ser posterior a la fecha de préstamo.", Color.Red);
                //MessageBox.Show("La fecha de devolución debe ser posterior a la fecha de préstamo.");
                return;
            }
            int idPrestamo = (int)dataGridViewListaPrestamos.CurrentRow.Cells["Id"].Value;

            Prestamo[] prestamos = prestamoService.CargarListaPrestamosDesdeArchivo();
            var prestamoEditar = prestamos.FirstOrDefault(p => p.Id == idPrestamo);

            if (prestamoEditar != null)
            {
                bool estadoAnterior = prestamoEditar.EstaDevuelto;

                prestamoEditar.EstaDevuelto = checkBoxActualizarEstadoDePrestamo.Checked;
                prestamoEditar.FechaPrestamo = dtpFechaPrestamo.SelectionRange.Start;
                prestamoEditar.FechaDevolucion = dtpFechaDevolucion.SelectionRange.Start;

                if (UsuarioSeleccionado != null)
                {
                    prestamoEditar.Usuario = UsuarioSeleccionado;
                }

                if (LibroSeleccionado != null)
                {
                    prestamoEditar.Libro = LibroSeleccionado;
                }

                if (!estadoAnterior && prestamoEditar.EstaDevuelto)
                {
                    LibroService libroService = new LibroService();
                    Libro libro = libroService.BuscarLibroPorId(prestamoEditar.Libro.Id);

                    if (libro != null)
                    {
                        libro.Disponible = true;
                        libroService.ActualizarLibroEnArchivo(libro);
                        //MessageBox.Show($"El libro '{libro.Titulo}' ahora está disponible.", "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await MostrarMensajeConDelay($"El libro '{libro.Titulo}' ahora está disponible.", Color.Green);

                    }
                }
                else if (estadoAnterior && !prestamoEditar.EstaDevuelto)
                {
                    LibroService libroService = new LibroService();
                    Libro libro = libroService.BuscarLibroPorId(prestamoEditar.Libro.Id);

                    if (libro != null)
                    {
                        libro.Disponible = false;
                        libroService.ActualizarLibroEnArchivo(libro);
                        // MessageBox.Show($"El libro '{libro.Titulo}' ahora está marcado como no disponible.", "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await MostrarMensajeConDelay($"El libro '{libro.Titulo}' ahora está marcado como no disponible.", Color.Orange);

                    }
                }
                // Guardar los cambios en el archivo de préstamos
                prestamoService.GuardarPrestamosEnArchivo(prestamos);
                CargarPrestamosEnDataGridView();
                await MostrarMensajeConDelay("Préstamo actualizado exitosamente.", Color.Green);
                //MessageBox.Show("Préstamo actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Préstamo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await MostrarMensajeConDelay("Préstamo no encontrado.", Color.Red);

            }
        }

        private async void btnDeshacerPrestamo_Click(object sender, EventArgs e)
        {
            bool resultado = prestamoService.DeshacerUltimoPrestamo();
            if (resultado)
            {
                CargarPrestamosEnDataGridView();
                await MostrarMensajeConDelay("Último préstamo deshecho con éxito.", Color.Green);

            }
            else
            {
                // MessageBox.Show("No se pudo deshacer el préstamo.");
                await MostrarMensajeConDelay("No se pudo deshacer el préstamo porque no se hizo.", Color.Red);
            }
        }
        //--------------------------------------------------------------


        private void DataGridViewListaPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaPrestamos.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dataGridViewListaPrestamos.CurrentRow;
                // var prestamoSeleccionado = (Prestamo)filaSeleccionada.DataBoundItem;
                Prestamo prestamoSeleccionado = (Prestamo)filaSeleccionada.DataBoundItem;
                idLibro = prestamoSeleccionado.Libro.Id;
                idUsuario = prestamoSeleccionado.Usuario.Id;

                lblLibroSeleccionado.Text = $"Libro: {prestamoSeleccionado.Libro.Titulo}";
                lblUsuarioSeleccionado.Text = $"Usuario: {prestamoSeleccionado.Usuario.Nombres}";

                dtpFechaPrestamo.SelectionRange = new SelectionRange(prestamoSeleccionado.FechaPrestamo, prestamoSeleccionado.FechaPrestamo);
                dtpFechaDevolucion.SelectionRange = new SelectionRange(prestamoSeleccionado.FechaDevolucion, prestamoSeleccionado.FechaDevolucion);

                checkBoxActualizarEstadoDePrestamo.Checked = prestamoSeleccionado.EstaDevuelto;
            }
        }


        private void CargarPrestamosEnDataGridView()
        {
            var prestamos = prestamoService.CargarListaPrestamosDesdeArchivo();
            dataGridViewListaPrestamos.DataSource = prestamos;

            // Configurar los encabezados de las columnas
            dataGridViewListaPrestamos.Columns["Id"].HeaderText = "ID";

            dataGridViewListaPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha de Préstamo";
            dataGridViewListaPrestamos.Columns["FechaDevolucion"].HeaderText = "Fecha de Devolución";
            dataGridViewListaPrestamos.Columns["EstaDevuelto"].HeaderText = "Devuelto";
            dataGridViewListaPrestamos.Columns["Multas"].HeaderText = "Multas";

            dataGridViewListaPrestamos.Columns["Usuario"].Visible = false;
            dataGridViewListaPrestamos.Columns["Libro"].Visible = false;

        }


        private void lblNoLibroEncontrado_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new GestionLibro());
        }

        private void lblNoUsuarioEncontrado_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new GestionUsuarioNegocio());
        }

        private void AbrirFormsHijos(object formsHijos)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form form = formsHijos as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
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
        private void AsignarValorATextBox(TextBox textBox, object valor)
        {
            if (valor != null)
            {
                textBox.Text = valor.ToString();
            }
            else
            {
                textBox.Text = string.Empty;
            }
        }

        public void SetPanelContenedor(Panel panel)
        {
            this.panelContenedor = panel;
        }
        private void ConfigurarEstilos()
        {
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelFormPrestamo, 20);
            panelDesign.AplicarBordesCurvos(panelTitulo, 20);
            panelDesign.AplicarBordesCurvos(panelListaPrestamo, 20);
            panelDesign.AplicarBordesCurvos(panelValidaciones, 20);
            panelDesign.AplicarBordesCurvos(panelAcciones, 20);

            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtBuscarLibro, 10);
            textBoxDesign.AplicarBordesCurvos(txtBuscarUsuario, 10);

            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnAsignarLibro, 10);
            buttonDesign.AplicarBordesCurvos(btnAsignarUsuario, 10);
            buttonDesign.AplicarBordesCurvos(btnDeshacerPrestamo, 10);
            buttonDesign.AplicarBordesCurvos(btnAgregarPrestamo, 10);
            buttonDesign.AplicarBordesCurvos(btnAcatualizarPrestamo, 10);


        }

        private void panelFormPrestamo_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}


