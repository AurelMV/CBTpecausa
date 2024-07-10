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
using CapaEntidad;
using CapaNegocio;
using System.Windows.Media;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class formGestionInscripcion : Form
    {
        public formGestionInscripcion()
        {
            InitializeComponent();
        }

        private void formGestionInscripcion_Load(object sender, EventArgs e)
        {

            InicializarComboBox();
            CargarInscripciones();
            txtfecha.Format = DateTimePickerFormat.Custom;
            txtfecha.CustomFormat = "yyyy-MM-dd";

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {

                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });

                }



            }
        }

        private void InicializarComboBox()
        {
            // Inicializar ComboBox de pago
            cbopago.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Pagado" });
            cbopago.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Deuda" });
            cbopago.DisplayMember = "Texto";
            cbopago.ValueMember = "Valor";
            if (cbopago.Items.Count > 0)
            {
                cbopago.SelectedIndex = 0;
            }


            //inicializar Combobox 
            cboturno.Items.Add(new OpcionCombo() { Valor = "dia", Texto = "dia" });
            cboturno.Items.Add(new OpcionCombo() { Valor = "tarde", Texto = "tarde" });
            cboturno.Items.Add(new OpcionCombo() { Valor = "noche", Texto = "noche" });
            cboturno.DisplayMember = "Texto";
            cboturno.ValueMember = "Valor";
            if (cboturno.Items.Count > 0)
            {
                cboturno.SelectedIndex = 0;
            }

            // Inicializar ComboBox de programas de estudio
            List<ProgramaEstudios> listaPrograma = new CN_ProgramaEstudios().listar();
            cboprograma.Items.Clear();
            foreach (ProgramaEstudios item in listaPrograma)
            {
                cboprograma.Items.Add(new OpcionCombo() { Valor = item.idprogramaestudios, Texto = item.nombre });
            }
            cboprograma.DisplayMember = "Texto";
            cboprograma.ValueMember = "Valor";
            if (cboprograma.Items.Count > 0)
            {
                cboprograma.SelectedIndex = 0;
            }

            // Inicializar ComboBox de ciclos de inscripción
            List<CicloInscripcion> listaCiclo = new CN_CicloInscripcion().listar();
            cbociclo.Items.Clear();
            foreach (CicloInscripcion item in listaCiclo)
            {
                cbociclo.Items.Add(new OpcionCombo() { Valor = item.idciclo, Texto = item.nombreCiclo });
            }
            cbociclo.DisplayMember = "Texto";
            cbociclo.ValueMember = "Valor";
            if (cbociclo.Items.Count > 0)
            {
                cbociclo.SelectedIndex = 0;
            }


            // Inicializar ComboBox de ciclos de inscripción
            List<Grupo> listagrup = new CN_Grupo().Listar2();
            cbogrupo.Items.Clear();
            foreach (Grupo item in listagrup)
            {
                cbogrupo.Items.Add(new OpcionCombo() { Valor = item.IdGrupos, Texto = item.NombreGrupo });
            }
            cbogrupo.DisplayMember = "Texto";
            cbogrupo.ValueMember = "Valor";
            if (cbogrupo.Items.Count > 0)
            {
                cbogrupo.SelectedIndex = 0;
            }
        }

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

                        txtidinscripcion.Text = dataGridView1.Rows[indice].Cells["id"].Value?.ToString() ?? string.Empty;
                        txtusuario.Text = dataGridView1.Rows[indice].Cells["Usuario"].Value?.ToString() ?? string.Empty;
                        txtestudiante.Text = dataGridView1.Rows[indice].Cells["Estudiante"].Value?.ToString() ?? string.Empty;
                        txtfecha.Text = dataGridView1.Rows[indice].Cells["fecha"].Value?.ToString() ?? string.Empty;
                        txtidestudiante.Text = dataGridView1.Rows[indice].Cells["idestudiantes"].Value?.ToString() ?? string.Empty;
                        txtidusuario.Text = dataGridView1.Rows[indice].Cells["idusuario"].Value?.ToString() ?? string.Empty;

                        foreach (OpcionCombo oc in cbopago.Items)
                        {
                            if (dataGridView1.Rows[indice].Cells["Pago"].Value != null &&
                                Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["valorpago"].Value))
                            {
                                cbopago.SelectedIndex = cbopago.Items.IndexOf(oc);
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in cboturno.Items)
                        {
                            if (dataGridView1.Rows[indice].Cells["Turnos"].Value != null &&
                                oc.Valor.ToString() == dataGridView1.Rows[indice].Cells["Turnos"].Value.ToString())
                            {
                                cboturno.SelectedIndex = cboturno.Items.IndexOf(oc);
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in cbociclo.Items)
                        {
                            if (dataGridView1.Rows[indice].Cells["idciclo"].Value != null &&
                                Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["idciclo"].Value))
                            {
                                cbociclo.SelectedIndex = cbociclo.Items.IndexOf(oc);
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in cboprograma.Items)
                        {
                            if (dataGridView1.Rows[indice].Cells["idprograma"].Value != null &&
                                Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["idprograma"].Value))
                            {
                                cboprograma.SelectedIndex = cboprograma.Items.IndexOf(oc);
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in cbogrupo.Items)
                        {
                            if (dataGridView1.Rows[indice].Cells["idGrupo"].Value != null &&
                                Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["idGrupo"].Value))
                            {
                                cbogrupo.SelectedIndex = cbogrupo.Items.IndexOf(oc);
                                break;
                            }
                        }

                        foreach (OpcionCombo oc in cbociclo.Items)
                        {
                            if (dataGridView1.Rows[indice].Cells["idciclo"].Value != null &&
                                Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridView1.Rows[indice].Cells["idciclo"].Value))
                            {
                                cbociclo.SelectedIndex = cbociclo.Items.IndexOf(oc);
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
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado: " + ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarInscripciones()
        {
            dataGridView1.Rows.Clear();  // Limpiar las filas existentes
            List<Inscripcion> listarins = new CN_Inscripcion().Listar();
            foreach ( Inscripcion item in listarins)
            {
                string pagotexto = item.EstadoPago ? "Pagado" : "Deudor";
                int pagovalor = item.EstadoPago ? 1 : 0;

                dataGridView1.Rows.Add(new object[] {
            "", item.IdInscripcion, item.Turno, item.FechaInscripcion.ToString("yyyy-MM-dd"), pagovalor,pagotexto, item.oEstudiante.IdEstudiante, item.oEstudiante.Nombres, item.oCicloInscripcion.idciclo,
            item.oCicloInscripcion.nombreCiclo,item.oProgramaEstudios.idprogramaestudios,item.oProgramaEstudios.nombre,item.oUsuario.idusuarios,item.oUsuario.nombre,item.oGrupo.IdGrupos, item.oGrupo.NombreGrupo
        });
            }





        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;

                // Validar turno
                if (cboturno.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un turno.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string turno = ((OpcionCombo)cboturno.SelectedItem).Texto;

                // Validar estado de pago
                if (cbopago.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un estado de pago.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool estadopago = Convert.ToBoolean(((OpcionCombo)cbopago.SelectedItem).Valor);

                // Validar ciclo de inscripción
                if (cbociclo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un ciclo de inscripción.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idciclo = Convert.ToInt32(((OpcionCombo)cbociclo.SelectedItem).Valor);

                // Validar programa de estudios
                if (cboprograma.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un programa de estudios.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idprogramaestudios = Convert.ToInt32(((OpcionCombo)cboprograma.SelectedItem).Valor);

                // Validar grupo
                if (cbogrupo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un grupo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idGrupos = Convert.ToInt32(((OpcionCombo)cbogrupo.SelectedItem).Valor);

                // Validar fecha de inscripción
                if (!DateTime.TryParseExact(txtfecha.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaInscripcion))
                {
                    MessageBox.Show("Formato de fecha inválido. Por favor, ingrese la fecha en formato yyyy-MM-dd.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear nueva inscripción
                Inscripcion nuevaInscripcion = new Inscripcion
                {
                    Turno = turno,
                    EstadoPago = estadopago,
                    oCicloInscripcion = new CicloInscripcion { idciclo = idciclo },
                    oProgramaEstudios = new ProgramaEstudios { idprogramaestudios = idprogramaestudios },
                    oGrupo = new Grupo { IdGrupos = idGrupos },
                    FechaInscripcion = fechaInscripcion,
                    oUsuario = new Usuario { idusuarios = txtidusuario.Text }, // Asegúrate de que txtusuario.Text contiene un ID válido
                    oEstudiante = new Estudiante { IdEstudiante = txtidestudiante.Text } // Asegúrate de que txtestudiante.Text contiene un ID válido
                };

                if (int.TryParse(txtidinscripcion.Text, out int idInscripcion) && idInscripcion != 0)
                {
                    // Acción para actualización
                    nuevaInscripcion.IdInscripcion = idInscripcion;
                    bool modificado = new CN_Inscripcion().Editar(nuevaInscripcion, out mensaje);
                    if (modificado)
                    {
                        MessageBox.Show("Inscripción actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarInscripciones();
                        
                    }
                    else
                    {
                        MessageBox.Show("Inscripción actualizada exitosamente: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
               
                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato en los datos: " + ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            





        }

        private void cbopago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbusqueda.Text.Trim().ToUpper();

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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CargarInscripciones();


        }
    }
}
