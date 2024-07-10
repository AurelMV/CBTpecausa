﻿using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;


using CapaPresentacion.Utilidades;
namespace CapaPresentacion
{
    public partial class formInfo : Form
    {
        public formInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrupos()
        {
            dataGridView1.Rows.Clear();  // Limpiar las filas existentes

            try
            {
                List<Inscripcion> listarins = new CN_Inscripcion().Listar2();

                foreach (Inscripcion item in listarins)
                {
                    string pagotexto = item.EstadoPago ? "Pagado" : "Deudor";

                    // Añadir fila al DataGridView
                    dataGridView1.Rows.Add(new object[] {
                        item.IdInscripcion,

                item.oEstudiante.Nombres, // Nombre del estudiante
                item.oEstudiante.APaterno, // Apellido paterno del estudiante
                item.oEstudiante.AMaterno, // Apellido materno del estudiante
                pagotexto, // Estado de pago (Pagado o Deudor)
                item.oProgramaEstudios.nombre,
                item.oGrupo.NombreGrupo   ,// Nombre del programa de estudios
                item.oCicloInscripcion.nombreCiclo // Nombre del ciclo de inscripción
                 
            });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los grupos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formInfo_Load(object sender, EventArgs e)
        {
            CargarGrupos();

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


        }


        private void ExportDataGridViewToPDF(DataGridView dgv, string fileName)
        {
            // Crear documento y escritor de PDF
            Document document = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30); // Paisaje y márgenes de 30 unidades
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();

            // Crear tabla de PDF con el mismo número de columnas que el DataGridView
            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
            pdfTable.WidthPercentage = 100; // Utilizar todo el ancho disponible

            // Obtener los anchos de las columnas del DataGridView
            float[] columnWidths = new float[dgv.ColumnCount];
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                columnWidths[i] = (float)dgv.Columns[i].Width; // Usar el ancho de cada columna del DataGridView
            }
            pdfTable.SetWidths(columnWidths);

            // Colores para alternar filas
            BaseColor rowColor1 = new BaseColor(255, 255, 255); // Color blanco
            BaseColor rowColor2 = new BaseColor(240, 240, 240); // Color gris claro

            // Agregar encabezados de columna
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(50, 50, 50); // Color de fondo del encabezado
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5;
                pdfTable.AddCell(cell);
            }

            // Agregar filas de datos
            bool rowColorToggle = true;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell dgvCell in row.Cells)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dgvCell.Value?.ToString()));
                    cell.BackgroundColor = rowColorToggle ? rowColor1 : rowColor2; // Alternar color de fondo de las filas
                    cell.Padding = 5;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                }
                rowColorToggle = !rowColorToggle; // Cambiar el color para la siguiente fila
            }

            // Agregar tabla al documento PDF
            document.Add(pdfTable);
            document.Close();

            MessageBox.Show("Exportación a PDF completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = "DataGridViewExport.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPDF(dataGridView1, saveFileDialog.FileName);
                MessageBox.Show("Exportación a PDF completada exitosamente.");
            }
        }

        private void cbobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbuscar.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null)
                {
                    string valorCelda = row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper();


                    bool contieneTexto = valorCelda.Contains(textoBusqueda);


                    row.Visible = contieneTexto;
                }
                else
                {

                    row.Visible = true;
                }
            }



        }
    }
}
