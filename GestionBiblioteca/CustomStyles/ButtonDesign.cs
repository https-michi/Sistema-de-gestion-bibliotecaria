using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca.CustomStyles
{
    internal class ButtonDesign
    {
        public void AplicarBordesCurvos(Button button, int radioEsquina)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radioEsquina, radioEsquina), 180, 90);
            path.AddArc(new Rectangle(button.Width - radioEsquina, 0, radioEsquina, radioEsquina), 270, 90);
            path.AddArc(new Rectangle(button.Width - radioEsquina, button.Height - radioEsquina, radioEsquina, radioEsquina), 0, 90);
            path.AddArc(new Rectangle(0, button.Height - radioEsquina, radioEsquina, radioEsquina), 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }
    }
}
