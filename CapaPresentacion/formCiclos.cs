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
    public partial class formCiclos : Form
    {
        public formCiclos()
        {
            InitializeComponent();
            cargarCiclos();
            datetpFechaInicio.Format = DateTimePickerFormat.Custom;
            datetpFechaInicio.CustomFormat = "dd/MM/yyyy";
            datetpFechaFin.Format = DateTimePickerFormat.Custom;
            datetpFechaFin.CustomFormat = "dd/MM/yyyy";
        }

        private void btnRegistrarCiclo_Click(object sender, EventArgs e)
        {
            CicloInscripcion nuevociclo = new CicloInscripcion { 
                nombreCiclo = txtNombreCiclo.Text,
                fechainicio = datetpFechaInicio.Value.Date,
                fechafin = datetpFechaFin.Value.Date
            };
            CN_CicloInscripcion o_ciclo = new CN_CicloInscripcion();
            o_ciclo.registrarCiclos(nuevociclo);
            cargarCiclos();
            limpiar();
        }

        private void cargarCiclos() {
            List<CicloInscripcion> listaciclos = new CN_CicloInscripcion().listar();
            dataGridView1.DataSource = listaciclos;

            dataGridView1.Columns["idciclo"].HeaderText = "ID";
            dataGridView1.Columns["nombreCiclo"].HeaderText = "Nombre de Ciclo";
            dataGridView1.Columns["fechainicio"].HeaderText = "Fecha Inicio";
            dataGridView1.Columns["fechafin"].HeaderText = "Fecha Fin";
        }

        private void limpiar() {
            txtNombreCiclo.Text = "";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var ciclo = row.DataBoundItem as CicloInscripcion;
                if (ciclo != null)
                {
                    CN_CicloInscripcion cicloNuevo = new CN_CicloInscripcion();
                    cicloNuevo.actualizarCiclos(ciclo);
                    //fcfgvghgh
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                txtNombreCiclo.Text = filaSeleccionada.Cells["nombreCiclo"].Value.ToString();
                datetpFechaInicio.Value = Convert.ToDateTime(filaSeleccionada.Cells["fechainicio"].Value);
                datetpFechaFin.Value = Convert.ToDateTime(filaSeleccionada.Cells["fechafin"].Value);

            }
        }
    }
}
