using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formCurso : Form
    {
        public formCurso()
        {
            InitializeComponent();
        }

        private void cbobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formCurso_Load(object sender, EventArgs e)
        {


            foreach (DataGridViewColumn columna in dtacursos.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            CargarCursos();

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtacursos.Columns[e.ColumnIndex].Name == "boton")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();

                    var idValue = dtacursos.Rows[indice].Cells["id"].Value;
                    if (idValue != null)
                    {
                        txtidcurso.Text = idValue.ToString();
                    }
                    else
                    {
                        txtidcurso.Text = string.Empty;
                        MessageBox.Show("El valor de 'id' es null.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    var nombreValue = dtacursos.Rows[indice].Cells["Nombre"].Value;
                    if (nombreValue != null)
                    {
                        txtnombrecurso.Text = nombreValue.ToString();
                    }
                    else
                    {
                        txtnombrecurso.Text = string.Empty;
                        MessageBox.Show("El valor de 'Nombre' es null.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Índice no válido. Por favor, seleccione una fila válida.", "Error de Índice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {


            try
            {
                string mensaje = string.Empty;

                // Validar nombreCurso
                string NombreCurso = txtnombrecurso.Text;
                if (string.IsNullOrWhiteSpace(NombreCurso))
                {
                    MessageBox.Show("El nombre del curso no puede estar vacío.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear nuevo curso
                Curso nuevoCurso = new Curso
                {
                    NombreCurso = NombreCurso,
                };

                if (int.TryParse(txtidcurso.Text, out int idCurso) && idCurso != 0)
                {
                    // Acción para actualización
                    nuevoCurso.IdCurso = idCurso;

                    bool modificado = new CN_Curso().Editar(nuevoCurso, out mensaje);
                    if (modificado)
                    {
                        MessageBox.Show("Curso actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCursos();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el curso: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Acción para registro
                    int idCursoGen = new CN_Curso().Registrar(nuevoCurso, out mensaje);
                    if (idCursoGen != 0)
                    {
                        dtacursos.Rows.Add(new object[] {
                            "", idCursoGen, NombreCurso
                        });
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el curso: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarCursos();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtidcurso.Text = "0";
            txtnombrecurso.Text = "";
            txtfechabus2.Text = "";
          
            



        }
        private void CargarCursos()
        {
            dtacursos.Rows.Clear();  // Limpiar las filas existentes
            List<Curso> listacurso = new CN_Curso().Listar();
            foreach (Curso item in listacurso)
            {
               

                dtacursos.Rows.Add(new object[] {
            "", item.IdCurso, item.NombreCurso
        });
            }





        }

        private void dtacursos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icon1.Width;
                var h = Properties.Resources.icon1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icon1, new Rectangle(x, y, w, h)
                    );

                e.Handled = true;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtfechabus2.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in dtacursos.Rows)
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

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Limpiar();


        }

        private void iconButton4_Click(object sender, EventArgs e)
        {



            CargarCursos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
