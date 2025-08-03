using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GestionBiblioteca
{
    public class PanelDesign
    {
        public void AplicarBordesCurvos(Panel panel, int radioEsquina)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radioEsquina, radioEsquina), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radioEsquina, 0, radioEsquina, radioEsquina), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radioEsquina, panel.Height - radioEsquina, radioEsquina, radioEsquina), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radioEsquina, radioEsquina, radioEsquina), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
    }
}
