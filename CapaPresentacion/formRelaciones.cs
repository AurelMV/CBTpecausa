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
    public partial class formRelaciones : Form
    {
        public formRelaciones()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            configurarDataGridView1();
            configurarDataGridView2();
            cargarDatosRelacionados();
            cargarDocentesActivos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDocente.Text) || cboxCurso.SelectedIndex == -1 || cboxGrupo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, ingrese datos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idDocenteCurso = 0;
                if (!string.IsNullOrEmpty(txtIdDocenteCursoGrupo.Text))
                {
                    if (!int.TryParse(txtIdDocenteCursoGrupo.Text, out idDocenteCurso))
                    {
                        MessageBox.Show("El ID del programa debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                CursoDeDocente cursoDeDocente = new CursoDeDocente { 
                    IdCursoDeDocente = idDocenteCurso,
                    oCurso = new Curso { IdCurso = Convert.ToInt32(((OpcionCombo)cboxCurso.SelectedItem).Valor.ToString()) },
                    oGrupo = new Grupo { IdGrupos = Convert.ToInt32(((OpcionCombo)cboxGrupo.SelectedItem).Valor.ToString()) },
                    oDocente = new Docente { idDocente = txtIdDocente.Text }
                };
                CN_CursoDeDocente cn = new CN_CursoDeDocente();
                if (idDocenteCurso == 0)
                {
                    cn.registrar(cursoDeDocente);
                    MessageBox.Show("Se registrado exitosamente");
                }
                else
                {
                    cn.modificar(cursoDeDocente);
                    MessageBox.Show("Se ha modificado exitosamente");
                }
                cargarDatosRelacionados();
                limpiar();
            } catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void cargarDocentesActivos()
        {
            List<Docente> lista = new CN_Docente().listarDocenteActivo();
            dataGridView1.DataSource = lista;
        }
        private void cargarDatosRelacionados()
        {
            List<CursoDeDocente> lista = new CN_CursoDeDocente().listar();
            dataGridView2.DataSource = lista;
        }
        private void formRelaciones_Load(object sender, EventArgs e)
        {
            List<Curso> cursos = new CN_Curso().Listar();
            foreach (Curso item in cursos)
            {
                cboxCurso.Items.Add(new OpcionCombo { Valor = item.IdCurso, Texto = item.NombreCurso });
            }
            cboxCurso.DisplayMember = "Texto";
            cboxCurso.ValueMember = "Valor";
            cboxCurso.SelectedIndex = -1;

            List<Grupo> grupos = new CN_Grupo().ListarGrupoActivo();
            foreach (Grupo item in grupos)
            {
                cboxGrupo.Items.Add(new OpcionCombo { Valor = item.IdGrupos, Texto = item.NombreGrupo });
            }
            cboxGrupo.DisplayMember = "Texto";
            cboxGrupo.ValueMember = "Valor";
            cboxGrupo.SelectedIndex = -1;

        }
        private void configurarDataGridView1()
        {
            var nombre = new DataGridViewTextBoxColumn { DataPropertyName = "nombre", HeaderText = "Nombre", ReadOnly = true };
            var aPaterno = new DataGridViewTextBoxColumn { DataPropertyName = "aPaterno", HeaderText = "Apellido P.", ReadOnly = true };
            var aMaterno = new DataGridViewTextBoxColumn { DataPropertyName = "aMaterno", HeaderText = "Apellido M.", ReadOnly = true };
            dataGridView1.Columns.Add(nombre);
            dataGridView1.Columns.Add(aPaterno);
            dataGridView1.Columns.Add(aMaterno);
        }
        private void configurarDataGridView2()
        {
            var grupo = new DataGridViewTextBoxColumn { DataPropertyName = "nombreGrupo", HeaderText = "Grupo", ReadOnly = true, Width = 30 };
            var docente = new DataGridViewTextBoxColumn { DataPropertyName = "nombreDocente", HeaderText = "Docente", ReadOnly = true, Width = 200 };
            var curso = new DataGridViewTextBoxColumn { DataPropertyName = "nombreCurso", HeaderText = "Curso", ReadOnly = true };
            dataGridView2.Columns.Add(grupo);
            dataGridView2.Columns.Add(docente);
            dataGridView2.Columns.Add(curso);
        }
        private void limpiar()
        {
            txtIdDocente.Text = string.Empty;
            txtIdCurso.Text = "0";
            txtIdGrupo.Text = "0";
            txtIdDocenteCursoGrupo.Text = "0";
            txtDocente.Text = string.Empty;
            cboxCurso.SelectedIndex = -1;
            cboxGrupo.SelectedIndex = -1;
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
                var docente = filaSeleccionada.DataBoundItem as Docente;
                if (docente != null)
                {
                    txtDocente.Text = docente.nombre +" "+ docente.aPaterno +" "+docente.aMaterno;
                    txtIdDocente.Text = docente.idDocente.ToString();
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dataGridView2.Rows[e.RowIndex];
                var cd = filaSeleccionada.DataBoundItem as CursoDeDocente;
                if (cd != null)
                {
                    txtIdDocenteCursoGrupo.Text = cd.IdCursoDeDocente.ToString();
                    txtDocente.Text = cd.nombreDocente;
                    foreach (OpcionCombo oc in cboxCurso.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == cd.oCurso.IdCurso)
                        {
                            int indice = cboxCurso.Items.IndexOf(oc);
                            cboxCurso.SelectedIndex = indice;
                        }
                    }
                    foreach (OpcionCombo oc in cboxGrupo.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == cd.oGrupo.IdGrupos)
                        {
                            int indice = cboxGrupo.Items.IndexOf(oc);
                            cboxGrupo.SelectedIndex = indice;
                        }
                    }
                }
            }
        }
        private void cboxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCurso.SelectedItem != null)
            {
                OpcionCombo opcionSeleccionada = (OpcionCombo)cboxCurso.SelectedItem;
                txtIdCurso.Text = opcionSeleccionada.Valor.ToString();
            }
        }

        private void cboxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxGrupo.SelectedItem != null)
            {
                OpcionCombo opcionSeleccionada = (OpcionCombo)cboxGrupo.SelectedItem;
                txtIdGrupo.Text = opcionSeleccionada.Valor.ToString();
            }
        }
    }
}
