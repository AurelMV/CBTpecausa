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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formEstudiantes : Form
    {
        public formEstudiantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void formEstudiantes_Load(object sender, EventArgs e)
        {
            CargarGrupos();
            inicializarconbos();


            txtnacimiento.Format = DateTimePickerFormat.Custom;
            txtnacimiento.CustomFormat = "yyyy-MM-dd";


            txtañoculminado.Format = DateTimePickerFormat.Custom;
            txtañoculminado.CustomFormat = "yyyy-MM-dd";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "boton")
                {
                    int indice = e.RowIndex;
                    if (indice >= 0 && indice < dataGridView1.Rows.Count)
                    {
                        txtindice.Text = indice.ToString();

                        txtidestudiante.Text = dataGridView1.Rows[indice].Cells["id"].Value?.ToString() ?? string.Empty;
                        txtnombre.Text = dataGridView1.Rows[indice].Cells["Nombre"].Value?.ToString() ?? string.Empty;
                        txtapaterno.Text = dataGridView1.Rows[indice].Cells["APaterno"].Value?.ToString() ?? string.Empty;
                        txtamaterno.Text = dataGridView1.Rows[indice].Cells["AMaterno"].Value?.ToString() ?? string.Empty;
                        txtdeni.Text = dataGridView1.Rows[indice].Cells["DNI"].Value?.ToString() ?? string.Empty;

                        // Obtener el objeto OpcionCombo seleccionado
                        OpcionCombo opcionSeleccionada = (OpcionCombo)cbosexo.SelectedItem;

                        // Acceder al valor 'Valor' y convertirlo a char
                        char sexo = Convert.ToChar(opcionSeleccionada.Valor);

                        // Asignar el valor de 'sexo' a la celda correspondiente en el DataGridView
                        dataGridView1.Rows[indice].Cells["Sexo"].Value = sexo.ToString();

                        txtcelular.Text = dataGridView1.Rows[indice].Cells["Celular"].Value?.ToString() ?? string.Empty;

                        // Manejo adecuado del campo de fecha de nacimiento
                        if (dataGridView1.Rows[indice].Cells["Nacimiento"].Value != null &&
                            DateTime.TryParse(dataGridView1.Rows[indice].Cells["Nacimiento"].Value.ToString(), out DateTime fechaNacimiento))
                        {
                            txtnacimiento.Value = fechaNacimiento;
                        }
                        else
                        {
                            txtnacimiento.Value = DateTime.Today; // o cualquier valor por defecto que prefieras
                        }

                        txtemail.Text = dataGridView1.Rows[indice].Cells["Email"].Value?.ToString() ?? string.Empty;
                        txtcolegio.Text = dataGridView1.Rows[indice].Cells["Nombre_Colegio"].Value?.ToString() ?? string.Empty;
                        txtañoculminado.Text = dataGridView1.Rows[indice].Cells["Año_Culminado"].Value?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Índice no válido. Por favor, seleccione una fila válida.", "Error de Índice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Error: El índice de la fila está fuera del rango válido.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Error: Un valor necesario no está disponible.", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrupos()
        {
            dataGridView1.Rows.Clear();  // Limpiar las filas existentes
            List<Estudiante> listaestudiante = new CN_Estudiante().Listar();
            foreach (Estudiante item in listaestudiante)
            {

                dataGridView1.Rows.Add(new object[] {
            "", item.IdEstudiante, item.Nombres, item.APaterno, item.AMaterno, item.Documneto, item.Sexo, item.CelularEstudiante,item.FechaNacimiento.ToString("yyyy-MM-dd"),item.Email
            ,item.Colegio,item.AnoCulminado
        });
            }





        }
        private void inicializarconbos(){
            cbosexo.Items.Add(new OpcionCombo() { Valor = 'M', Texto = "Masculino" });
            cbosexo.Items.Add(new OpcionCombo() { Valor = 'F', Texto = "Femenino" });

            cbosexo.DisplayMember = "Texto";
            cbosexo.ValueMember = "Valor";
            if (cbosexo.Items.Count > 0)
            {
                cbosexo.SelectedIndex = 0;
            }


        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                string nombres = txtnombre.Text;
                string aPaterno = txtapaterno.Text;
                string aMaterno = txtamaterno.Text;
                string dni = txtdeni.Text;

              
                OpcionCombo opcionSeleccionada = (OpcionCombo)cbosexo.SelectedItem;
                char sexo = (char)opcionSeleccionada.Valor;

                string celular = txtcelular.Text;
                string fechanacimiento = txtnacimiento.Text;
                string email = txtemail.Text;
                string colegio = txtcolegio.Text;
                string culminado = txtañoculminado.Text;

             
                Estudiante nuevoEstudiante = new Estudiante
                {
                    Nombres = nombres,
                    APaterno = aPaterno,
                    AMaterno = aMaterno,
                    Documneto = dni,
                    Sexo = sexo,
                    CelularEstudiante = celular,
                    FechaNacimiento = DateTime.Parse(fechanacimiento),
                    Email = email,
                    Colegio = colegio,
                    AnoCulminado = culminado
                };

                if (!string.IsNullOrEmpty(txtidestudiante.Text))
                {
                    nuevoEstudiante.IdEstudiante = txtidestudiante.Text;
                    bool modificado = new CN_Estudiante().Editar(nuevoEstudiante, out mensaje);
                    if (modificado)
                    {
                        MessageBox.Show("Estudiante actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrupos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el estudiante: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                   
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
