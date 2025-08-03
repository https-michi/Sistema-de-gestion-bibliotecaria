using GestionBiblioteca.CustomStyles;
using GestionBiblioteca.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca.Forms
{
    public partial class Home : Form
    {
        private TextBoxDesign textBoxDesign;
        private ButtonDesign buttonDesign;
        private PanelDesign panelDesign;
        private SolicitudService solicitudService;

        public Home()
        {
            InitializeComponent();
            solicitudService = new SolicitudService();
            CargarSolicitudesPendientes();
            CargarTopUsuariosConMasLibrosDevueltos(); 

            ConfigurarEstilos();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            CargarSolicitudesPendientes();
            CargarTopUsuariosConMasLibrosDevueltos(); 

        }

        private void CargarTopUsuariosConMasLibrosDevueltos()
        {
            var prestamoService = new PrestamoService();
            var usuariosTop = prestamoService.ObtenerTopUsuariosConMasLibrosDevueltos(3);

            int xOffset = 42;
            int yOffset = 610; 
            int panelWidth = 222; 
            int panelHeight = 100;

            foreach (var usuario in usuariosTop)
            {
                Panel panel = new Panel
                {
                    Size = new Size(panelWidth, panelHeight),
                    Location = new Point(xOffset, yOffset),
                    BackColor = ColorTranslator.FromHtml("51, 44, 87"), 
                    BorderStyle = BorderStyle.None,
                };
                panel.Region = new Region(GetRoundedRectangle(new Rectangle(0, 0, panel.Width, panel.Height), 20));

                Label label = new Label
                {
                    Text = $"DNI: {usuario.Numero}\nNombre: {usuario.Nombres}\nApePaterno: {usuario.apellido_paterno}\nCelular: {usuario.NumeroContacto}",
                    Location = new Point(5, 5),
                    AutoSize = true,
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.White 
                };

                Label librosPrestadosLabel = new Label
                {
                    Text = $"Libros prestados: {ObtenerCantidadLibrosPrestados(usuario.Id)}",
                    Location = new Point(5, 80), 
                    AutoSize = true,
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.FromArgb(251, 134, 183) 
                };


                panel.Controls.Add(label);
                panel.Controls.Add(librosPrestadosLabel);

                this.Controls.Add(panel);
                panel.BringToFront();
                xOffset += panelWidth + 64; 
            }
        }
        private int ObtenerCantidadLibrosPrestados(int usuarioId)
        {
            var prestamoService = new PrestamoService();
            var prestamos = prestamoService.CargarListaPrestamosDesdeArchivo();
            return prestamos.Count(p => p.Usuario.Id == usuarioId);
        }

        private void CargarSolicitudesPendientes()
        {
            var solicitudesPendientes = solicitudService.CargarSolicitudes()
                .Where(s => !s.EstaAtendida)
                .OrderByDescending(s => s.FechaSolicitud)
                .Take(9)
                .ToArray();

            int yOffset = 70; 
            int xOffset = 885; 
            int panelWidth = 290; 
            int panelHeight = 60; 

            foreach (var solicitud in solicitudesPendientes)
            {
                Panel panel = new Panel
                {
                    Size = new Size(panelWidth, panelHeight),
                    Location = new Point(xOffset, yOffset),
                    BackColor = ColorTranslator.FromHtml("51, 44, 87"),
                    BorderStyle = BorderStyle.None, 
  
                };
                panel.Region = new Region(GetRoundedRectangle(new Rectangle(0, 0, panel.Width, panel.Height), 20));


                Label label = new Label
                {
                    Text = $"Solicitante: {solicitud.Usuario.Nombres}\nLibro: {solicitud.Libro.Titulo}\nFecha: {solicitud.FechaSolicitud.ToShortDateString()}",
                    Location = new Point(5, 5),
                    AutoSize = true,
                    Font = new Font("Consolas", 10) 
                };

                panel.Controls.Add(label);
                this.Controls.Add(panel);
                panel.BringToFront();
                yOffset += panelHeight + 15;
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void ConfigurarEstilos()
        {
            panelDesign = new PanelDesign();
            panelDesign.AplicarBordesCurvos(panel1, 20);
            panelDesign.AplicarBordesCurvos(panel2, 20);
            panelDesign.AplicarBordesCurvos(panel3, 20);
            panelDesign.AplicarBordesCurvos(panel4, 20);
            panelDesign.AplicarBordesCurvos(panel5, 20);
            panelDesign.AplicarBordesCurvos(panel6, 20);
            panelDesign.AplicarBordesCurvos(panel7, 20);
            panelDesign.AplicarBordesCurvos(panel8, 20);
            panelDesign.AplicarBordesCurvos(panel9, 20);
            panelDesign.AplicarBordesCurvos(panel10, 20);
            panelDesign.AplicarBordesCurvos(flowLayoutPanel, 20);
            buttonDesign = new ButtonDesign();
            //buttonDesign.AplicarBordesCurvos(btnAsignarLibro, 10);

        }
    }

}