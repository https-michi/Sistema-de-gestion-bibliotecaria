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
    public class TextBoxDesign
    {
        public void AplicarBordesCurvos(TextBox textBox, int radioEsquina)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radioEsquina, radioEsquina), 180, 90); 
            path.AddArc(new Rectangle(textBox.Width - radioEsquina, 0, radioEsquina, radioEsquina), 270, 90); 
            path.AddArc(new Rectangle(textBox.Width - radioEsquina, textBox.Height - radioEsquina, radioEsquina, radioEsquina), 0, 90); 
            path.AddArc(new Rectangle(0, textBox.Height - radioEsquina, radioEsquina, radioEsquina), 90, 90); 
            path.CloseFigure();

            textBox.Region = new Region(path);
        }
    }
}
