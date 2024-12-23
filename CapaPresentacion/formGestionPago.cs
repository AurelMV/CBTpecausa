﻿using CapaEntidad;
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
    public partial class formGestionPago : Form
    {
        private CN_CicloInscripcion cnciclo = new CN_CicloInscripcion();
        public formGestionPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "boton2")
                {
                    int indice = e.RowIndex;
                    if (indice >= 0)
                    {
                        idindice2.Text = indice.ToString();
                        txtidinscripcion.Text = dataGridView2.Rows[indice].Cells["idinscrip"].Value?.ToString() ?? string.Empty;
                        txtidestudiante.Text = dataGridView2.Rows[indice].Cells["idestudiantes"].Value?.ToString() ?? string.Empty;
                        txtestudiante.Text = dataGridView2.Rows[indice].Cells["Estudiante"].Value?.ToString() ?? string.Empty;
                        txtapellido.Text = dataGridView2.Rows[indice].Cells["Apellido_Paterno"].Value?.ToString() ?? string.Empty;
                        txtapellido2.Text = dataGridView2.Rows[indice].Cells["Apellido_Materno"].Value?.ToString() ?? string.Empty;
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




        }


        private void CargarInscripcion()
        {
            dataGridView2.Rows.Clear();  // Limpiar las filas existentes
            List<Inscripcion> listarins = new CN_Inscripcion().Listar();
            foreach (Inscripcion item in listarins)
            {
                string pagotexto = item.EstadoPago ? "Pagado" : "Deudor";
                int pagovalor = item.EstadoPago ? 1 : 0;

                dataGridView2.Rows.Add(new object[] {
            "", item.IdInscripcion, item.Turno, item.FechaInscripcion.ToString("yyyy-MM-dd"), pagovalor,pagotexto, item.oEstudiante.IdEstudiante, item.oEstudiante.Nombres,item.oEstudiante.APaterno, item.oEstudiante.AMaterno, item.oCicloInscripcion.idciclo,
            item.oCicloInscripcion.nombreCiclo,item.oProgramaEstudios.idprogramaestudios,item.oProgramaEstudios.nombre,item.oUsuario.idusuarios,item.oUsuario.nombre,item.oGrupo.IdGrupos, item.oGrupo.NombreGrupo
        });
            }
        }





        private void CargarPago()
        {
         
        }

        private string GenerarIdDinamico(string nroVoucher, DateTime fecha)
        {

            string voucherParte = !string.IsNullOrEmpty(nroVoucher) && nroVoucher.Length >= 3 ? nroVoucher.Substring(0, 3) : nroVoucher;


            string fechaParte = fecha.ToString("yyyyMMdd").Substring(0, 3);

            string idDinamico = $"{voucherParte}{fechaParte}";

            return idDinamico;
        }

        private void formGestionPago_Load(object sender, EventArgs e)
        {

            txtidinscripcion.Clear();
   
            txtestudiante.Clear();
           


            txtidestudiante.Clear();
           
            txtbusqueda.Clear();

            cbociclo.SelectedIndex = -1;
   
            cbobusqueda.SelectedIndex = -1;
            CargarInscripcion();
            cargarciclos1();
            cargarciclos2();
            txtfecha.Format = DateTimePickerFormat.Custom;
            txtfecha.CustomFormat = "yyyy-MM-dd";

            foreach (DataGridViewColumn columna in dataGridView2.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda2.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda2.DisplayMember = "Texto";
            cbobusqueda2.ValueMember = "Valor";
            cbobusqueda2.SelectedIndex = 0;

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


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btncargar2_Click(object sender, EventArgs e)
        {
            CargarInscripcion();
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda2.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbusqueda2.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in dataGridView2.Rows)
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

                        txtidpago.Text = dataGridView1.Rows[indice].Cells["id"].Value?.ToString() ?? string.Empty;
                        txtmonto.Text = dataGridView1.Rows[indice].Cells["monto"].Value?.ToString() ?? string.Empty;
                        txtnrovouche.Text = dataGridView1.Rows[indice].Cells["nroVoucher"].Value?.ToString() ?? string.Empty;
                        txtmedio.Text = dataGridView1.Rows[indice].Cells["medioPago"].Value?.ToString() ?? string.Empty;
                        txtestudiante.Text = dataGridView1.Rows[indice].Cells["Nombre"].Value?.ToString() ?? string.Empty;
                        txtidinscripcion.Text = dataGridView1.Rows[indice].Cells["idInscripcion"].Value?.ToString() ?? string.Empty;
                        txtidestudiante.Text = dataGridView1.Rows[indice].Cells["idEstudiante"].Value?.ToString() ?? string.Empty;

                        // Manejo adecuado del campo de fecha de pago
                        if (dataGridView1.Rows[indice].Cells["fecha"].Value != null &&
                            DateTime.TryParse(dataGridView1.Rows[indice].Cells["fecha"].Value.ToString(), out DateTime fechaPago))
                        {
                            txtfecha.Value = fechaPago;
                        }
                        else
                        {
                            txtfecha.Value = DateTime.Today; // o cualquier valor por defecto que prefieras
                        }
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

        private void cbobusqueda_SelectedIndexChanged(object sender, EventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bool newVisibility = !cbobusqueda2.Visible;
            iconButton4.Visible = newVisibility;
            cbobusqueda2.Visible = newVisibility;
            dataGridView2.Visible = newVisibility;
            txtbusqueda2.Visible = newVisibility;
            label2.Visible = newVisibility;
            dataGridView1.Visible = !dataGridView1.Visible;
            LimpiarCampos();
            btnbuscar2.Visible = newVisibility;
            btncargar2.Visible = newVisibility;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {


            try
            {
                string idPago = txtidpago.Text.Trim();
                string nroVoucher = txtnrovouche.Text.Trim();
                DateTime fecha = txtfecha.Value;
                string medioPago = txtmedio.Text.Trim();
                int monto = 0;

                if (string.IsNullOrWhiteSpace(nroVoucher))
                {
                    MessageBox.Show("El número de voucher no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(medioPago))
                {
                    MessageBox.Show("El medio de pago no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtmonto.Text, out monto))
                {
                    MessageBox.Show("El monto debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idInscripcion = 0;
                if (!int.TryParse(txtidinscripcion.Text, out idInscripcion))
                {
                    MessageBox.Show("El ID de inscripción debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(idPago))
                {
                    idPago = GenerarIdDinamico(nroVoucher, fecha);
                }
                Pago nuevoPago = new Pago
                {
                    IdPago = idPago,
                    Fecha = fecha,
                    Monto = monto,
                    MedioPago = medioPago,
                    NroVoucher = nroVoucher,
                    IdInscripcion = idInscripcion
                };

                string mensaje = string.Empty;
                bool exito = false;



                exito = new CN_Pago().Registrar(nuevoPago, out mensaje);


                if (exito)
                {
                    MessageBox.Show("Pago registrado/modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPago();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar/modificar el pago: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CargarPago();
        }


        private void LimpiarCampos()
        {
            txtidpago.Text = String.Empty;
            txtnrovouche.Text = string.Empty;
            txtfecha.Value = DateTime.Now;
            txtmedio.Text = string.Empty;
            txtmonto.Text = string.Empty;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string idPago = txtidpago.Text.Trim();
                string nroVoucher = txtnrovouche.Text.Trim();
                DateTime fecha = txtfecha.Value;
                string medioPago = txtmedio.Text.Trim();
                int monto = 0;

                if (string.IsNullOrWhiteSpace(nroVoucher))
                {
                    MessageBox.Show("El número de voucher no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(medioPago))
                {
                    MessageBox.Show("El medio de pago no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtmonto.Text, out monto))
                {
                    MessageBox.Show("El monto debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idInscripcion = 0;
                if (!int.TryParse(txtidinscripcion.Text, out idInscripcion))
                {
                    MessageBox.Show("El ID de inscripción debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(idPago))
                {
                    idPago = GenerarIdDinamico(nroVoucher, fecha);
                }
                Pago nuevoPago = new Pago
                {
                    IdPago = idPago,
                    Fecha = fecha,
                    Monto = monto,
                    MedioPago = medioPago,
                    NroVoucher = nroVoucher,
                    IdInscripcion = idInscripcion
                };

                string mensaje = string.Empty;
                bool exito = false;



                exito = new CN_Pago().Editar(nuevoPago, out mensaje);


                if (exito)
                {
                    MessageBox.Show("Pago registrado/modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPago();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar/modificar el pago: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void cargarciclos1()
        {
            List<CicloInscripcion> ciclo = cnciclo.listar();
            cbociclo.DataSource = ciclo;
            cbociclo.DisplayMember = "nombreCiclo";
            cbociclo.ValueMember = "idciclo";
            cbociclo.SelectedIndex = -1;
        
        }
        private void cargarciclos2()
        {
            List<CicloInscripcion> ciclo = cnciclo.listar();
           
            cbociclo2.DataSource = ciclo;
            cbociclo2.DisplayMember = "nombreCiclo";
            cbociclo2.ValueMember = "idciclo";
            cbociclo2.SelectedIndex = -1;
        }

        private void cbociclo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbociclo.SelectedIndex == -1 || cbociclo.SelectedValue == null)
            {
               
                return;
            }

          
            int idCiclo;
            if (cbociclo.SelectedValue != null && int.TryParse(cbociclo.SelectedValue.ToString(), out idCiclo))
            {
       
                dataGridView1.Rows.Clear();

                try
                {
                  
                    List<Pago> listarPagos = new CN_Pago().Listar(idCiclo);

                    if (listarPagos.Count == 0)
                    {
                        MessageBox.Show("No se encontraron pagos para el ciclo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                   

                    foreach (Pago item in listarPagos)
                    {
                        string pagotexto = item.oInscripcion.EstadoPago ? "Pagado" : "Deudor";
                        int pagovalor = item.oInscripcion.EstadoPago ? 1 : 0;

                        dataGridView1.Rows.Add(new object[] {
                    "",
                    item.IdPago,
                    item.Fecha.ToString("yyyy-MM-dd"),
                    item.Monto,
                    item.MedioPago,
                    item.NroVoucher,
                    item.oInscripcion.IdInscripcion,
                    item.oInscripcion.FechaInscripcion.ToString("yyyy-MM-dd"),
                    pagovalor,
                    pagotexto,
                    item.oInscripcion.oEstudiante.IdEstudiante,
                    item.oInscripcion.oEstudiante.Nombres,
                    item.oInscripcion.oEstudiante.APaterno,
                    item.oInscripcion.oEstudiante.AMaterno
                });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CargarInscripcion();
            }

        }

        private void cbociclo2_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();

            if (cbociclo2.SelectedValue == null)
            {
               
                return;
            }

            int idciclo;
            if (!int.TryParse(cbociclo2.SelectedValue.ToString(), out idciclo))
            {
              
                return;
            }

            try
            {
                // Listar las inscripciones del ciclo seleccionado
                List<Inscripcion> listarins = new CN_Inscripcion().Listar3(idciclo);

                // Verificar si hay inscripciones encontradas
                if (listarins.Count == 0)
                {
                    MessageBox.Show("No se encontraron inscripciones para el ciclo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Agregar inscripciones al DataGridView
                foreach (Inscripcion item in listarins)
                {
                    string pagotexto = item.EstadoPago ? "Pagado" : "Deudor";
                    int pagovalor = item.EstadoPago ? 1 : 0;

                    dataGridView2.Rows.Add(new object[] {
                "",
                item.IdInscripcion,
                 item.oEstudiante.IdEstudiante,
                item.oEstudiante.Nombres,
                item.oEstudiante.APaterno,
                item.oEstudiante.AMaterno,
                item.FechaInscripcion.ToString("yyyy-MM-dd"),
                  item.Turno,item.Monto,
                pagovalor,
                pagotexto,
               
                item.oCicloInscripcion.idciclo,
                item.oCicloInscripcion.nombreCiclo,
                item.oProgramaEstudios.idprogramaestudios,
                item.oProgramaEstudios.nombre,
                item.oUsuario.idusuarios,
                item.oUsuario.nombre,
                item.oGrupo.IdGrupos,
                item.oGrupo.NombreGrupo
            });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las inscripciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
    }
    
    

