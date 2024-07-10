using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formProgramas : Form
    {
        public formProgramas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            configurarDataGridView();
            cargarProgramas();
            AjustarAlturaDataGridView();
        }

        private void btnGuardarPrograma_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombrePrograma.Text)) {
                    MessageBox.Show("Por favor, ingrese datos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idPrograma = 0;
                if (!string.IsNullOrEmpty(txtIdPrograma.Text)) {
                    if (!int.TryParse(txtIdPrograma.Text, out idPrograma)) {
                        MessageBox.Show("El ID del programa debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                ProgramaEstudios programaEstudios = new ProgramaEstudios {
                    idprogramaestudios = idPrograma,
                    nombre = txtNombrePrograma.Text
                };
                CN_ProgramaEstudios cN_ProgramaEstudios = new CN_ProgramaEstudios();
                if (idPrograma == 0) {
                    cN_ProgramaEstudios.registrarPrograma(programaEstudios);
                    MessageBox.Show("Programa de estudio registrado exitosamente");
                }
                else {
                    cN_ProgramaEstudios.actualizarPrograma(programaEstudios);
                    MessageBox.Show("Programa de estudio modificado exitosamente");
                }
                cargarProgramas();
                limpiar();
                AjustarAlturaDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cargarProgramas()
        {
            List<ProgramaEstudios> lista = new CN_ProgramaEstudios().listar();
            dataGridView1.DataSource = lista;
        }
        private void configurarDataGridView()
        {
            var id = new DataGridViewTextBoxColumn { DataPropertyName = "idprogramaestudios", HeaderText = "ID", ReadOnly = true };
            var nombre = new DataGridViewTextBoxColumn { DataPropertyName = "nombre", HeaderText = "Nombre", ReadOnly = true, Width = 425 };
            dataGridView1.Columns.Add(id);
            dataGridView1.Columns.Add(nombre);
        }
        private void limpiar()
        {
            txtIdPrograma.Text = string.Empty;
            txtNombrePrograma.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                var programa = filaSeleccionada.DataBoundItem as ProgramaEstudios;
                if (programa != null)
                {
                    txtIdPrograma.Text = (programa.idprogramaestudios).ToString();
                    txtNombrePrograma.Text = programa.nombre;
                }
            }
        }
        private void AjustarAlturaDataGridView()
        {
            int alturaFila = dataGridView1.RowTemplate.Height;
            int totalFilas = dataGridView1.Rows.Count;
            int alturaEncabezado = dataGridView1.ColumnHeadersHeight;

            int alturaTotal = alturaEncabezado + (totalFilas * alturaFila);
            dataGridView1.Height = alturaTotal + 2;
        }
    }
}
