using CapaEntidad;
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
        private CN_CicloInscripcion cnciclo = new CN_CicloInscripcion();
        private bool isFormLoading = true;

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
          
        }

        private void formInfo_Load(object sender, EventArgs e)
        {
            
            cargarciclos();

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

            isFormLoading = false;
        }


        private void ExportDataGridViewToPDF(DataGridView dgv, string fileName)
        {
          
            Document document = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30); // Paisaje y márgenes de 30 unidades
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();

        
            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
            pdfTable.WidthPercentage = 100; 

            float[] columnWidths = new float[dgv.ColumnCount];
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                columnWidths[i] = (float)dgv.Columns[i].Width; 
            }
            pdfTable.SetWidths(columnWidths);

           
            BaseColor rowColor1 = new BaseColor(255, 255, 255); 
            BaseColor rowColor2 = new BaseColor(240, 240, 240);

          
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(50, 50, 50);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5;
                pdfTable.AddCell(cell);
            }

          
            bool rowColorToggle = true;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell dgvCell in row.Cells)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dgvCell.Value?.ToString()));
                    cell.BackgroundColor = rowColorToggle ? rowColor1 : rowColor2;
                    cell.Padding = 5;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                }
                rowColorToggle = !rowColorToggle;
            }

          
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
        private void cargarciclos()
        {
            List<CicloInscripcion> ciclo = cnciclo.listar();
            cbociclo.DataSource = ciclo;
            cbociclo.DisplayMember = "nombreCiclo";
            cbociclo.ValueMember = "idciclo";
            cbociclo.SelectedIndex = -1; 

        }

        private void cbociclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading)
                return;

            if (cbociclo.SelectedIndex == -1 || cbociclo.SelectedValue == null)
                return;

            int idciclo;
            if (!int.TryParse(cbociclo.SelectedValue.ToString(), out idciclo))
            {
                MessageBox.Show("Selecciona un ciclo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();

            try
            {
                List<Inscripcion> listarins = new CN_Inscripcion().Listar2(idciclo);

                foreach (Inscripcion item in listarins)
                {
                    string pagotexto = item.EstadoPago ? "Pagado" : "Deudor";

                    dataGridView1.Rows.Add(new object[] {
                item.IdInscripcion,
                item.oEstudiante.Nombres,
                item.oEstudiante.APaterno,
                item.oEstudiante.AMaterno,
                item.oEstudiante.Edad,
                pagotexto,
                item.oProgramaEstudios.nombre,
                item.oGrupo.NombreGrupo,
                item.oCicloInscripcion.nombreCiclo
            });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los grupos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
