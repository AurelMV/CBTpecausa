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
    public partial class formInfoDocentes : Form
    {
        public formInfoDocentes()
        {
            InitializeComponent();
            configurarDataGridView();
            cargarDocentes();
        }

        private void formInfoDocentes_Load(object sender, EventArgs e)
        {

        }

        private void cargarDocentes()
        {
            List<Docente> lista = new CN_Docente().listar();
            dataGridView1.DataSource = lista;
        }

        private void configurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            var nombre = new DataGridViewTextBoxColumn { DataPropertyName = "nombre", HeaderText = "Nombre", ReadOnly = true };
            var aPaterno = new DataGridViewTextBoxColumn { DataPropertyName = "aPaterno", HeaderText = "Apellido P.", ReadOnly = true };
            var aMaterno = new DataGridViewTextBoxColumn { DataPropertyName = "aMaterno", HeaderText = "Apellido M.", ReadOnly = true };
            var dni = new DataGridViewTextBoxColumn { DataPropertyName = "dni", HeaderText = "DNI", ReadOnly = true };
            var sexo = new DataGridViewTextBoxColumn { DataPropertyName = "sexo", HeaderText = "Sexo", ReadOnly = true };
            var celular = new DataGridViewTextBoxColumn { DataPropertyName = "celular", HeaderText = "Celular", ReadOnly = true };
            var fechaNacimiento = new DataGridViewTextBoxColumn { DataPropertyName = "fechaNacimiento", HeaderText = "Fecha Nacimiento", ReadOnly = true };
            var email = new DataGridViewTextBoxColumn { DataPropertyName = "email", HeaderText = "Email", ReadOnly = true };
            var estado = new DataGridViewTextBoxColumn { DataPropertyName = "estadoTexto", HeaderText = "Estado", ReadOnly = true };
            dataGridView1.Columns.Add(nombre);
            dataGridView1.Columns.Add(aPaterno);
            dataGridView1.Columns.Add(aMaterno);
            dataGridView1.Columns.Add(dni);
            dataGridView1.Columns.Add(sexo);
            dataGridView1.Columns.Add(celular);
            dataGridView1.Columns.Add(fechaNacimiento);
            dataGridView1.Columns.Add(email);
            dataGridView1.Columns.Add(estado);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            cargarDocentes();
        }
    }
}
