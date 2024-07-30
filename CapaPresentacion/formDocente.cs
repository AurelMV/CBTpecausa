using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class formDocente : Form
    {
        public formDocente()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            configurarDataGridView();
            ConfigurarComboBox();
            fechaNacimientoDocente.Format = DateTimePickerFormat.Custom;
            fechaNacimientoDocente.CustomFormat = "dd/MM/yyyy";
            rbtnMasculino.Checked = true;
            cargarDocentes();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreDocente.Text) || string.IsNullOrEmpty(txtApaternoDocente.Text) || string.IsNullOrEmpty(txtAmaternoDocente.Text) || string.IsNullOrEmpty(txtDniDocente.Text) || string.IsNullOrEmpty(txtCelularDocente.Text) || string.IsNullOrEmpty(txtEmailDocente.Text))
                {
                    MessageBox.Show("Por favor, ingrese datos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string idDinamico = GenerarIdDinamico(txtNombreDocente.Text, txtApaternoDocente.Text, txtAmaternoDocente.Text);
                Docente docente = new Docente
                {
                    idDocente = idDinamico,
                    nombre = txtNombreDocente.Text,
                    aPaterno = txtApaternoDocente.Text,
                    aMaterno = txtAmaternoDocente.Text,
                    dni = txtDniDocente.Text,
                    sexo = ObtenerSexoSeleccionado(),
                    celular = txtCelularDocente.Text,
                    fechaNacimiento = fechaNacimientoDocente.Value.Date,
                    email = txtEmailDocente.Text,
                    estado = ((KeyValuePair<string, bool>)cboxEstadoDocente.SelectedItem).Value
                };
                CN_Docente cN_Docente = new CN_Docente();
                if (string.IsNullOrEmpty(txtIdDocente.Text))
                {
                    cN_Docente.registrarDocente(docente);
                    MessageBox.Show("Docente registrado correctamente");
                }
                else { 
                    cN_Docente.actualizarDocente(docente);
                    MessageBox.Show("Docente modificado correctamente");
                }
                cargarDocentes();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void cargarDocentes() 
        { 
            List<Docente> lista = new CN_Docente().listar();
            dataGridView1.DataSource = lista;
        }
        private void ConfigurarComboBox()
        {
            cboxEstadoDocente.Items.Add(new KeyValuePair<string, bool>("Activo", true));
            cboxEstadoDocente.Items.Add(new KeyValuePair<string, bool>("Inactivo", false));
            cboxEstadoDocente.DisplayMember = "Key";
            cboxEstadoDocente.ValueMember = "Value";
        }

        private char ObtenerSexoSeleccionado()
        {
            if (rbtnMasculino.Checked)
            {
                return 'M';
            }
            else if (rbtnFemenino.Checked)
            {
                return 'F';
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ' ';
            }
        }
        private string GenerarIdDinamico(string nombre, string aPaterno, string aMaterno)
        {
            char Nombre = !string.IsNullOrEmpty(nombre) ? nombre[0] : ' ';
            char Apaterno = !string.IsNullOrEmpty(aPaterno) ? aPaterno[0] : ' ';
            char Amaterno = !string.IsNullOrEmpty(aMaterno) ? aMaterno[0] : ' ';

            string idDinamico = $"{Nombre}{Apaterno}{Amaterno}";

            return idDinamico;
        }
        private void limpiar()
        {
            txtIdDocente.Text = string.Empty;
            txtNombreDocente.Text = string.Empty;
            txtApaternoDocente.Text = string.Empty;
            txtAmaternoDocente.Text = string.Empty;
            txtDniDocente.Text = string.Empty;
            txtCelularDocente.Text = string.Empty;
            txtEmailDocente.Text = string.Empty;
            rbtnMasculino.Checked = false;
            rbtnFemenino.Checked = false;
            cboxEstadoDocente.SelectedIndex = -1;
        }

        private void configurarDataGridView() 
        {
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var docente = row.DataBoundItem as Docente;
                if (docente != null)
                {
                    CN_Docente cN_Docente = new CN_Docente();
                    cN_Docente.actualizarDocente(docente);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                var docente = filaSeleccionada.DataBoundItem as Docente;
                if (docente != null)
                {
                    txtIdDocente.Text = docente.idDocente;
                    txtNombreDocente.Text = docente.nombre;
                    txtApaternoDocente.Text = docente.aPaterno;
                    txtAmaternoDocente.Text = docente.aMaterno;
                    txtDniDocente.Text = docente.dni;
                    if (docente.sexo == 'M') { 
                        rbtnMasculino.Checked = true;
                    }
                    else {
                        rbtnFemenino.Checked = true;
                    }
                    txtCelularDocente.Text = docente.celular;
                    fechaNacimientoDocente.Value = docente.fechaNacimiento;
                    txtEmailDocente.Text = docente.email;
                    cboxEstadoDocente.SelectedItem = docente.estado ?
                        new KeyValuePair<string, bool>("Activo", true) :
                        new KeyValuePair<string, bool>("Inactivo", false);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
            //vgvvvvv
        }

        private void formDocente_Load(object sender, EventArgs e)
        {
            fechaNacimientoDocente.MaxDate = DateTime.Today;
        }
    }
}
