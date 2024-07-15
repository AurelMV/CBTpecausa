using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaNegocio;
using CapaEntidad;
using System.Globalization;
using System.Windows.Documents;



namespace CapaPresentacion
{
    public partial class formGrupos : Form
    {
        public formGrupos()
        {
            InitializeComponent();
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;

                // Validar nombreGrupo
                string nombreGrupo = txtnombre.Text;
                if (string.IsNullOrWhiteSpace(nombreGrupo))
                {
                    MessageBox.Show("El nombre del grupo no puede estar vacío.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar aforo
                if (!int.TryParse(txtaforo.Text, out int aforo))
                {
                    MessageBox.Show("El aforo debe ser un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar estado
                if (cboestado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un estado para el grupo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1;


                // Validar ciclo seleccionado
                if (cbciclo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un ciclo para el grupo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idCiclo = (int)cbciclo.SelectedValue;

                // Crear nuevo grupo
                Grupo nuevoGrupo = new Grupo
                {
                    NombreGrupo = nombreGrupo,
                    Aforo = aforo,
                    Estado = estado,
                    oCicloinscripcion = new CicloInscripcion { idciclo = idCiclo },
                   
                };

                // Verificar si se está editando o registrando
                if (int.TryParse(txtidgrupo.Text, out int idGrupo) && idGrupo != 0)
                {
                    // Acción para actualización
                    nuevoGrupo.IdGrupos = idGrupo;
                    bool modificado = new CN_Grupo().Editar(nuevoGrupo, out mensaje);
                    if (modificado)
                    {
                        MessageBox.Show("Grupo actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrupos();
                    
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el grupo: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Acción para registro
                    int idNuevoGrupo = new CN_Grupo().Registrar(nuevoGrupo, out mensaje);
                    if (idNuevoGrupo != 0)
                    {
                        MessageBox.Show("Grupo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrupos();
                        limpiar();
    
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el grupo: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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









        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //funcion para alimentar el combo box de estado 
        private void formGrupos_Load(object sender, EventArgs e)
        {
            List<CicloInscripcion> listaCiclo = new CN_CicloInscripcion().listar();
            cbciclo.Items.Clear();
            foreach (CicloInscripcion item in listaCiclo)
            {
                cbciclo.Items.Add(new OpcionCombo() { Valor = item.idciclo, Texto = item.nombreCiclo });
            }
            cbciclo.DisplayMember = "Texto";
            cbciclo.ValueMember = "Valor";
            if (cbciclo.Items.Count > 0)
            {
                cbciclo.SelectedIndex = 0;
            }



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

            InicializarComboBox();
            CargarGrupos();

            
        }


        private void limpiar() {
            txtindice.Text = "-1";
            txtidgrupo.Text = "0";
            txtnombre.Text = "";
            txtaforo.Text = "";


            cboestado.SelectedIndex=0;

        
        
        }

        private void txtfecha_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtfecha_DateSelected(object sender, DateRangeEventArgs e)
        {
          


        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtidgrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex< 0)
                return;
                if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icon1.Width;
                var h = Properties.Resources.icon1.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w)/2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icon1, new Rectangle(x, y, w, h)
                    );

                e.Handled = true;
            }


        }
        //funcion para inicializar los combos box 
        private void InicializarComboBox()
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;
        }

        //funcion para cargar el gurpo
        private void CargarGrupos()
        {
            dataGridView1.Rows.Clear();  // Limpiar las filas existentes
            List<Grupo> listaGrupo = new CN_Grupo().Listar();
            foreach (Grupo item in listaGrupo)
            {
                string estadoTexto = item.Estado ? "Activo" : "No Activo";
                int estadoValor = item.Estado ? 1 : 0;

                dataGridView1.Rows.Add(new object[] {
                    "", item.IdGrupos, item.NombreGrupo, item.Aforo, estadoValor, estadoTexto, item.oCicloinscripcion.idciclo, item.oCicloinscripcion.nombreCiclo
                });
            }
        }

        //Funcion para autocompletar los textos apartir del dataGrivView asiendo uso del boton combo 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "boton")
                {
                    int indice = e.RowIndex;
                    if (indice >= 0)
                    {
                        txtindice.Text = indice.ToString();

                        txtidgrupo.Text = dataGridView1.Rows[indice].Cells["id"].Value?.ToString() ?? string.Empty;
                        txtnombre.Text = dataGridView1.Rows[indice].Cells["Nombre"].Value?.ToString() ?? string.Empty;
                        txtaforo.Text = dataGridView1.Rows[indice].Cells["Aforo"].Value?.ToString() ?? string.Empty;
                     
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            var estadoValor = dataGridView1.Rows[indice].Cells["EstadoValor"].Value;
                            if (estadoValor != null && Convert.ToInt32(oc.Valor) == Convert.ToInt32(estadoValor))
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Índice no válido. Por favor, seleccione una fila válida.", "Error de Índice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Error: El índice de la fila está fuera del rango válido.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error: Un valor necesario no está disponible.", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            
            
                string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
                string textoBusqueda = txtfechabus2.Text.Trim().ToUpper();

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




        private void txtfechabuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            CargarGrupos();
        }
    }
}
