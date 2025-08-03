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
    public partial class GestionSolicitudes : Form, IFormularioConPanel
    {
        public Libro LibroSeleccionado { get; private set; }
        public Usuario UsuarioSeleccionado { get; private set; }

        private PrestamoService prestamoService;
        private SolicitudService solicitudService;
        private Panel panelContenedor;


        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;
        private int idLibro;
        private int idUsuario;
        public GestionSolicitudes()
        {
            InitializeComponent();
            prestamoService = new PrestamoService();
            solicitudService = new SolicitudService();
            CargarSolicitudEnDataGridView();
            dataGridViewListaSolicitudes.SelectionChanged += DataGridViewListaSolicitudes_SelectionChanged;
            listBoxLibros.Visible = false;
            listBoxUsuarios.Visible = false;
            lblNoLibroEncontrado.Visible = false;
            lblNoUsuarioEncontrado.Visible = false;
            DataGridDesign.AplicarEstiloDataGrid(dataGridViewListaSolicitudes);
            dataGridViewListaSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            ConfigurarEstilos();

        }

        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            string tituloBuscado = txtBuscarLibro.Text;

            listBoxLibros.Items.Clear();

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
        public void SetPanelContenedor(Panel panel)
        {
            this.panelContenedor = panel;
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
        private async void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            if (LibroSeleccionado == null || UsuarioSeleccionado == null)
            {
                await MostrarMensajeConDelay("Debe seleccionar un libro y un usuario antes de enviar una solicitud.", Color.Red);
                return;
            }

            if (!LibroSeleccionado.Disponible)
            {
                try
                {
                    solicitudService.RegistrarSolicitud(UsuarioSeleccionado, LibroSeleccionado);
                    var solicitudesPendientes = solicitudService.ObtenerSolicitudesPendientesPorLibro(LibroSeleccionado.Id).Length;
                    CargarSolicitudEnDataGridView();
                    await MostrarMensajeConDelay($"La solicitud fue registrada. Total de solicitudes pendientes para este libro: {solicitudesPendientes}.", Color.Green);
                    MessageBox.Show($"La solicitud fue registrada. Total de solicitudes pendientes para este libro: {solicitudesPendientes}.");

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                await MostrarMensajeConDelay("El libro está disponible y no requiere solicitud", Color.Green);
                //MessageBox.Show("El libro está disponible y no requiere solicitud.");
            }
        }

        private async void btnActualizarSolicitud_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSolicitudes.CurrentRow == null) return;

            int idSolicitud = (int)dataGridViewListaSolicitudes.CurrentRow.Cells["Id"].Value;

            var solicitudes = solicitudService.CargarSolicitudes();
            Solicitud solicitudEditar = null;

            foreach (var solicitud in solicitudes)
            {
                if (solicitud.Id == idSolicitud)
                {
                    solicitudEditar = solicitud;
                    break;
                }
            }

            if (solicitudEditar != null)
            {
                bool estadoAnterior = solicitudEditar.EstaAtendida;

                solicitudEditar.EstaAtendida = checkBoxActualizarEsrtadoSolicitud.Checked;
                // solicitudEditar.FechaSolicitud = dtpFechaSolicitud.SelectionRange.Start;

                if (!estadoAnterior && solicitudEditar.EstaAtendida)
                {
                    solicitudEditar.FechaAtendida = DateTime.Now;
                }

                if (UsuarioSeleccionado != null)
                {
                    solicitudEditar.Usuario = UsuarioSeleccionado;
                }

                if (LibroSeleccionado != null)
                {
                    solicitudEditar.Libro = LibroSeleccionado;
                }
                solicitudService.GuardarSolicitudesEnArchivo(solicitudes);
                CargarSolicitudEnDataGridView();
                await MostrarMensajeConDelay("Solicitud atendida exitosamente.", Color.Green);
                //MessageBox.Show("Solicitud actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await MostrarMensajeConDelay("Solicitud no encontrada.", Color.Red);
                //MessageBox.Show("Solicitud no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud solicitudProcesada = solicitudService.ProcesarSiguienteSolicitud();

                MessageBox.Show($"Solicitud procesada:\n" +
                                $"Usuario: {solicitudProcesada.Usuario.Nombres}\n" +
                                $"Libro: {solicitudProcesada.Libro.Titulo}\n" +
                                $"Fecha de Solicitud: {solicitudProcesada.FechaSolicitud}\n" +
                                $"Estado: {(solicitudProcesada.EstaAtendida ? "Atendida" : "Pendiente")}",
                                "Solicitud Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarSolicitudEnDataGridView();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarSolicitudEnDataGridView()
        {
            var solicitudes = solicitudService.CargarSolicitudes();
            dataGridViewListaSolicitudes.DataSource = solicitudes;
            dataGridViewListaSolicitudes.Columns["Id"].HeaderText = "ID Solicitud";
            dataGridViewListaSolicitudes.Columns["FechaSolicitud"].HeaderText = "Fecha de Solicitud";
            dataGridViewListaSolicitudes.Columns["EstaAtendida"].HeaderText = "Atendida";
            dataGridViewListaSolicitudes.Columns["FechaAtendida"].HeaderText = "Fecha Atendida";
            dataGridViewListaSolicitudes.Columns["Usuario"].Visible = false;
            dataGridViewListaSolicitudes.Columns["Libro"].Visible = false;
            dataGridViewListaSolicitudes.ReadOnly = true;

        }

        private void DataGridViewListaSolicitudes_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewListaSolicitudes.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dataGridViewListaSolicitudes.CurrentRow;
                Solicitud solicitudSeleccionada = (Solicitud)filaSeleccionada.DataBoundItem;
                idLibro = solicitudSeleccionada.Libro.Id;
                idUsuario = solicitudSeleccionada.Usuario.Id;
                lblLibroSeleccionado.Text = $"Libro: {solicitudSeleccionada.Libro.Titulo}";
                lblUsuarioSeleccionado.Text = $"Usuario: {solicitudSeleccionada.Usuario.Nombres}";
                checkBoxActualizarEsrtadoSolicitud.Checked = solicitudSeleccionada.EstaAtendida;
            }
        }

        private void ConfigurarEstilos()
        {
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelFormSolicitudes, 20);
            panelDesign.AplicarBordesCurvos(panelListaSolicicitudes, 20);
            panelDesign.AplicarBordesCurvos(panelTitulo, 20);
            panelDesign.AplicarBordesCurvos(panelValidaciones, 20);
            panelDesign.AplicarBordesCurvos(panelAcciones, 20);
            panelDesign.AplicarBordesCurvos(panelTitulo2, 20);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnAsignarLibro, 10);
            buttonDesign.AplicarBordesCurvos(btnAsignarUsuario, 10);
            buttonDesign.AplicarBordesCurvos(btnEnviarSolicitud, 10);
            buttonDesign.AplicarBordesCurvos(btnActualizarSolicitud, 10);
            buttonDesign.AplicarBordesCurvos(btnProcesarSolicitud, 10); 

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

    }
}

