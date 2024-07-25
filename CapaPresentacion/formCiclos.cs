using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
            configurarDataGridView();
            cargarCiclos();
            datetpFechaInicio.Format = DateTimePickerFormat.Custom;
            datetpFechaInicio.CustomFormat = "dd/MM/yyyy";
            datetpFechaFin.Format = DateTimePickerFormat.Custom;
            datetpFechaFin.CustomFormat = "dd/MM/yyyy";
        }

        private void btnRegistrarCiclo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCiclo.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            CicloInscripcion nuevociclo = new CicloInscripcion { 
                nombreCiclo = txtNombreCiclo.Text,
                fechainicio = datetpFechaInicio.Value.Date,
                fechafin = datetpFechaFin.Value.Date
            };
            CN_CicloInscripcion o_ciclo = new CN_CicloInscripcion();
            if (txtIdCiclo.Text == "0")
            {
                o_ciclo.registrarCiclos(nuevociclo);
                MessageBox.Show("Ciclo registrado correctamente.");
            } 
            else 
            {
                o_ciclo.actualizarCiclos(nuevociclo);
                MessageBox.Show("Ciclo modificado correctamente.");
            }
            cargarCiclos();
            limpiar();
        }

        private void cargarCiclos() {
            List<CicloInscripcion> listaciclos = new CN_CicloInscripcion().listar();
            dataGridView1.DataSource = listaciclos;
        }

        private void configurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            var nombre = new DataGridViewTextBoxColumn { DataPropertyName = "nombreCiclo", HeaderText = "Nombre", ReadOnly = true };
            var fechaInicio = new DataGridViewTextBoxColumn { DataPropertyName = "fechainicio", HeaderText = "Fecha Inicio", ReadOnly = true };
            var fechaFin = new DataGridViewTextBoxColumn { DataPropertyName = "fechafin", HeaderText = "Fecha Fin", ReadOnly = true };
            dataGridView1.Columns.Add(nombre);
            dataGridView1.Columns.Add(fechaInicio);
            dataGridView1.Columns.Add(fechaFin);
        }

        private void limpiar() {
            txtNombreCiclo.Text = string.Empty;
            txtIdCiclo.Text = "0";
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
                var filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                var ciclo = filaSeleccionada.DataBoundItem as CicloInscripcion;
                if (ciclo != null)
                {
                    txtIdCiclo.Text = ciclo.idciclo.ToString();
                    txtNombreCiclo.Text = ciclo.nombreCiclo;
                    datetpFechaInicio.Value = ciclo.fechainicio;
                    datetpFechaFin.Value = ciclo.fechafin;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
