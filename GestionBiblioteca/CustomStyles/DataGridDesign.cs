using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioteca.CustomStyles
{
    internal class DataGridDesign
    {
        public static void AplicarEstiloDataGrid(DataGridView dataGridView)
        {
            // Configurar el estilo general
            dataGridView.BorderStyle = BorderStyle.FixedSingle;

            // Configurar estilo del encabezado de columnas
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("37, 32, 64");
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Console", 09F, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Configurar estilo del encabezado de filas
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("37, 32, 64");
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue; 
            dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White; 

            // Configurar estilo de las filas
            dataGridView.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("37, 32, 64");
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Configurar el color de los bordes
            dataGridView.GridColor = ColorTranslator.FromHtml("101, 99, 132"); ;
            
            // Ajustar columnas y filas
            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.RowTemplate.Height = 30; 
        }

    }
}
