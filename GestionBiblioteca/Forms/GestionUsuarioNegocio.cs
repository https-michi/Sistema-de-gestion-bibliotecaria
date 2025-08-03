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
    public partial class GestionUsuarioNegocio : Form
    {
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;

        public GestionUsuarioNegocio()
        {
            InitializeComponent();
            CargarUsuariosEnDataGridView();
            ConfigurarEstilos();
            LimpiarFormulario();
            DataGridDesign.AplicarEstiloDataGrid(dataGridViewListaUsuarioNegocio);
            dataGridViewListaUsuarioNegocio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewListaUsuarioNegocio.SelectionChanged += DataGridViewListaUsuarioNegocio_SelectionChanged;
        }
        private async Task MostrarMensajeConDelay()
        {
            await Task.Delay(3000);
            lblValidaciones.Text = "";
        }


        //------------------------------------------------------------------------------------------------
        private async void btnBuscarDni_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDni.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                lblValidaciones.Text = "Por favor, ingrese un DNI.";
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
                return;
            }

            ApiClient apiClient = new ApiClient();
            ApiResponse response = await apiClient.BuscarPorDniAsync(dni);

            if (response != null && response.Success)
            {
                txtDni.Text = response.Data.Numero;
                txtNombre.Text = response.Data.Nombres;
                txtApellidoPaterno.Text = response.Data.apellido_paterno;
                txtApellidoMaterno.Text = response.Data.apellido_materno;

                lblValidaciones.Text = "Datos encontrados y cargados correctamente.";
                lblValidaciones.ForeColor = Color.Green;
            }
            else
            {
                lblValidaciones.Text = "No se encontraron datos para el DNI ingresado.";
                lblValidaciones.ForeColor = Color.Red;
            }

            await MostrarMensajeConDelay();
        }
        //------------------------------------------------------------------------------------------------




        //------------------------------------------------------------------------------------------------
        private async void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellidoPaterno.Text) || string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(txtNumeroContacto.Text) || string.IsNullOrEmpty(txtTipoUsuario.Text))
            {
                lblValidaciones.Text = MensajesValidacionGestionUsuario.CamposVacios();
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
                return;
            }
            try
            {
                UsuarioNegocioService usuarioNegocioService = new UsuarioNegocioService();
                UsuarioNegocio nuevoUsuarioNegocio = new UsuarioNegocio
                {
                    Id = usuarioNegocioService.ObtenerNuevoId(),
                    Numero = txtDni.Text,
                    Nombres = txtNombre.Text,
                    apellido_paterno = txtApellidoPaterno.Text,
                    apellido_materno = txtApellidoMaterno.Text,
                    Correo = txtCorreo.Text,
                    NumeroContacto = txtNumeroContacto.Text,
                    TipoUsuario = txtTipoUsuario.Text,
                    FechaRegistro = DateTime.Now
                };
                usuarioNegocioService.AgregarUsuarioNegocio(nuevoUsuarioNegocio);
                usuarioNegocioService.listaUsuarios.MostrarUsuarios();

                lblValidaciones.Text = MensajesValidacionGestionUsuario.UsuarioRegistradoExitosamente();
                lblValidaciones.ForeColor = Color.Green;

                LimpiarFormulario();
                CargarUsuariosEnDataGridView();
                await MostrarMensajeConDelay();
            }
            catch (InvalidOperationException ex)
            {
                lblValidaciones.Text = ex.Message;
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
            }
        }




        //------------------------------------------------------------------------------------------------

        private async void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellidoPaterno.Text) || string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(txtNumeroContacto.Text) || string.IsNullOrEmpty(txtTipoUsuario.Text))
            {
                lblValidaciones.Text = MensajesValidacionGestionUsuario.CamposVacios();
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
                return;
            }

            string dni = txtDni.Text.Trim();
            UsuarioNegocioService usuarioNegocioService = new UsuarioNegocioService();
            UsuarioNegocio[] usuarios = usuarioNegocioService.CargarUsuariosDesdeArchivo();

            bool encontrado = false;

            foreach (var usuario in usuarios)
            {
                if (usuario.Numero == dni)
                {
                    usuario.Nombres = txtNombre.Text;
                    usuario.apellido_paterno = txtApellidoPaterno.Text;
                    usuario.apellido_materno = txtApellidoMaterno.Text;
                    usuario.Correo = txtCorreo.Text;
                    usuario.NumeroContacto = txtNumeroContacto.Text;
                    usuario.TipoUsuario = txtTipoUsuario.Text;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                lblValidaciones.Text = MensajesValidacionGestionUsuario.UsuarioNoEncontrado();
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
                return;
            }

            usuarioNegocioService.GuardarUsuariosEnArchivo(usuarios);
            lblValidaciones.Text = MensajesValidacionGestionUsuario.UsuarioEditadoExitosamente();
            lblValidaciones.ForeColor = Color.Green;

            CargarUsuariosEnDataGridView();
            LimpiarFormulario();
            await MostrarMensajeConDelay();

        }




        //------------------------------------------------------------------------------------------------
        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaUsuarioNegocio.CurrentRow == null)
            {
                lblValidaciones.Text = "Por favor, seleccione un usuario para eliminar.";
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
                return;
            }
            string dni = dataGridViewListaUsuarioNegocio.CurrentRow.Cells["Numero"].Value?.ToString();
            if (string.IsNullOrEmpty(dni))
            {
                lblValidaciones.Text = "Error al obtener el DNI del usuario seleccionado.";
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario con DNI {dni}?", "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                UsuarioNegocioService usuarioNegocioService = new UsuarioNegocioService();
                UsuarioNegocio[] usuarios = usuarioNegocioService.CargarUsuariosDesdeArchivo();

                var usuarioAEliminar = usuarios.FirstOrDefault(u => u.Numero == dni);
                if (usuarioAEliminar == null)
                {
                    lblValidaciones.Text = "El usuario seleccionado no existe.";
                    lblValidaciones.ForeColor = Color.Red;
                    await MostrarMensajeConDelay();
                    return;
                }

                var listaUsuariosActualizada = usuarios.Where(u => u.Numero != dni).ToArray();
                usuarioNegocioService.GuardarUsuariosEnArchivo(listaUsuariosActualizada);

                lblValidaciones.Text = MensajesValidacionGestionUsuario.UsuarioEliminadoExitosamente();
                lblValidaciones.ForeColor = Color.Green;
                CargarUsuariosEnDataGridView();
                await MostrarMensajeConDelay();

            }
            catch (Exception ex)
            {
                lblValidaciones.Text = $"Error al eliminar el usuario: {ex.Message}";
                lblValidaciones.ForeColor = Color.Red;
                await MostrarMensajeConDelay();
            }
        }
        //------------------------------------------------------------------------------------------------





        //------------------------------------------------------------------------------------------------
        private void CargarUsuariosEnDataGridView()
        {
            UsuarioNegocioService usuarioNegocioService = new UsuarioNegocioService();
            UsuarioNegocio[] usuarios = usuarioNegocioService.CargarUsuariosDesdeArchivo();
            dataGridViewListaUsuarioNegocio.DataSource = usuarios.ToList();
            dataGridViewListaUsuarioNegocio.DataSource = usuarios;
            dataGridViewListaUsuarioNegocio.Columns["Id"].HeaderText = "ID";
            dataGridViewListaUsuarioNegocio.Columns["Numero"].HeaderText = "DNI";
            dataGridViewListaUsuarioNegocio.Columns["Nombres"].HeaderText = "Nombres";
            dataGridViewListaUsuarioNegocio.Columns["apellido_paterno"].HeaderText = "Apellido Paterno";
            dataGridViewListaUsuarioNegocio.Columns["apellido_materno"].HeaderText = "Apellido Materno";
            dataGridViewListaUsuarioNegocio.Columns["Correo"].HeaderText = "Correo";
            dataGridViewListaUsuarioNegocio.Columns["NumeroContacto"].HeaderText = "Celular";
            dataGridViewListaUsuarioNegocio.Columns["FechaRegistro"].HeaderText = "Fecha de Registro";
            dataGridViewListaUsuarioNegocio.Columns["TipoUsuario"].HeaderText = "Tipo de Usuario";
            dataGridViewListaUsuarioNegocio.ReadOnly = true;

        }
        //------------------------------------------------------------------------------------------------




        //------------------------------------------------------------------------------------------------
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
        private void DataGridViewListaUsuarioNegocio_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaUsuarioNegocio.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dataGridViewListaUsuarioNegocio.CurrentRow;

                AsignarValorATextBox(txtDni, filaSeleccionada.Cells["Numero"].Value);
                AsignarValorATextBox(txtNombre, filaSeleccionada.Cells["Nombres"].Value);
                AsignarValorATextBox(txtApellidoPaterno, filaSeleccionada.Cells["apellido_paterno"].Value);
                AsignarValorATextBox(txtApellidoMaterno, filaSeleccionada.Cells["apellido_materno"].Value);
                AsignarValorATextBox(txtCorreo, filaSeleccionada.Cells["Correo"].Value);
                AsignarValorATextBox(txtNumeroContacto, filaSeleccionada.Cells["NumeroContacto"].Value);
                AsignarValorATextBox(txtTipoUsuario, filaSeleccionada.Cells["TipoUsuario"].Value);
            }
        }
        //------------------------------------------------------------------------------------------------

        private void LimpiarFormulario()
        {
            txtBuscarDni.Clear();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtNumeroContacto.Clear();
            txtTipoUsuario.Clear();
        }
        private void ConfigurarEstilos()
        {
            textBoxDesign = new TextBoxDesign();
            textBoxDesign.AplicarBordesCurvos(txtDni, 10);
            textBoxDesign.AplicarBordesCurvos(txtNombre, 10);
            textBoxDesign.AplicarBordesCurvos(txtApellidoPaterno, 10);
            textBoxDesign.AplicarBordesCurvos(txtApellidoMaterno, 10);
            textBoxDesign.AplicarBordesCurvos(txtCorreo, 10);
            textBoxDesign.AplicarBordesCurvos(txtNumeroContacto, 10);
            textBoxDesign.AplicarBordesCurvos(txtTipoUsuario, 10);
            textBoxDesign.AplicarBordesCurvos(txtBuscarDni, 10);
            buttonDesign = new ButtonDesign();
            buttonDesign.AplicarBordesCurvos(btnBuscarDni, 10);
            buttonDesign.AplicarBordesCurvos(btnRegistrarUsuario, 10);
            buttonDesign.AplicarBordesCurvos(btnEliminarUsuario, 10);
            buttonDesign.AplicarBordesCurvos(btnEditarUsuario, 10);
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panelContenedorLista, 20);
            panelDesign.AplicarBordesCurvos(panelBusqueda, 20);
            panelDesign.AplicarBordesCurvos(panelValidaciones, 20);
            panelDesign.AplicarBordesCurvos(panelBuscarDni, 20);
            panelDesign.AplicarBordesCurvos(panelFormRegistro, 20);
            panelDesign.AplicarBordesCurvos(panelAcciones, 20);
            panelDesign.AplicarBordesCurvos(panelTitulo, 20);

        }
    }
}
