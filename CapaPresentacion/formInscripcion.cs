using CapadeEntidad;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class formInscripcion : Form
    {

        private CN_Departamento cnDepartamento = new CN_Departamento();
        private CN_Provincia cnProvincia = new CN_Provincia();
        private CN_DIstrito cnDistrito = new CN_DIstrito();
        private CN_Colegio cnColegio = new CN_Colegio();

        private Usuario usuario;
        public formInscripcion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;


            inicializarconbos();
            InicializarComboBox();

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            ///dffdgfgdassdfg
           
        }

        private void formInscripcion_Load(object sender, EventArgs e)
        {
            txtidusuario.Text = usuario.idusuarios;
            txtnombreusuario.Text = usuario.nombre;



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


            List<Grupo> listgrup = new CN_Grupo().Listar();
            cbogrupo.Items.Clear();
            foreach (Grupo item in listgrup)
            {
                cbogrupo.Items.Add(new OpcionCombo() { Valor = item.IdGrupos, Texto = item.NombreGrupo });
            }
            cbogrupo.DisplayMember = "Texto";
            cbogrupo.ValueMember = "Valor";
            if (cbogrupo.Items.Count > 0)
            {
                cbogrupo.SelectedIndex = 0;
            }



            txtnacimiento.Format = DateTimePickerFormat.Custom;
            txtnacimiento.CustomFormat = "yyyy-MM-dd";

            txtañoculminado.Format = DateTimePickerFormat.Custom;
            txtañoculminado.CustomFormat = "yyyy-MM-dd";

            txtfecha.Format = DateTimePickerFormat.Custom;
            txtfecha.CustomFormat = "yyyy-MM-dd";

            txtfechapago.Format = DateTimePickerFormat.Custom;
            txtfechapago.CustomFormat = "yyyy-MM-dd";

            CargarDepartamentos();

        }
        private void inicializarconbos()
        {
            cbosexo.Items.Add(new OpcionCombo() { Valor = 'M', Texto = "Masculino" });
            cbosexo.Items.Add(new OpcionCombo() { Valor = 'F', Texto = "Femenino" });

            cbosexo.DisplayMember = "Texto";
            cbosexo.ValueMember = "Valor";
            if (cbosexo.Items.Count > 0)
            {
                cbosexo.SelectedIndex = 0;
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

         


         



        }

        //----------------------------------------------------------------------------------------------------
        private string GenerarIdDinamico2(string nombre, string aPaterno, string aMaterno, string Dni)
        {
            // Obtener la primera letra de cada cadena y convertirla a mayúsculas
            string nombreParte = !string.IsNullOrEmpty(nombre) ? nombre.Substring(0, 1).ToUpper() : string.Empty;
            string aPaternoParte = !string.IsNullOrEmpty(aPaterno) ? aPaterno.Substring(0, 1).ToUpper() : string.Empty;
            string aMaternoParte = !string.IsNullOrEmpty(aMaterno) ? aMaterno.Substring(0, 1).ToUpper() : string.Empty;
            string dniParte = !string.IsNullOrEmpty(Dni) && Dni.Length >= 3 ? Dni.Substring(0, 3).ToUpper() : string.Empty;

            // Combinar las partes en un único ID dinámico
            string idDinamico = $"{nombreParte}{aPaternoParte}{aMaternoParte}{dniParte}";

            return idDinamico;
        }



        private string GenerarIdDinamico(string nroVoucher, DateTime fecha)
        {

            string voucherParte = !string.IsNullOrEmpty(nroVoucher) && nroVoucher.Length >= 3 ? nroVoucher.Substring(0, 3) : nroVoucher;


            string fechaParte = fecha.ToString("yyyyMMdd").Substring(0, 3);

            string idDinamico = $"{voucherParte}{fechaParte}";

            return idDinamico;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos del formulario
                string nroVoucher = txtvoucher.Text.Trim();
                DateTime fecha = txtfecha.Value;
                string medioPago = txtmediopago.Text.Trim();
                int monto;

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

                // Validaciones de datos
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

                // Crear nuevo estudiante
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

                // Generar y asignar ID dinámico para el estudiante
                string idEstudiante = GenerarIdDinamico2(nombres, aPaterno, aMaterno, dni);
                nuevoEstudiante.IdEstudiante = idEstudiante;

                // Registrar estudiante
                string mensajeEstudiante = string.Empty;
                bool exitoEstudiante = new CN_Estudiante().Registrar(nuevoEstudiante, out mensajeEstudiante);


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
            
                    oUsuario = new Usuario { idusuarios = txtidusuario.Text }, // Asegúrate de que txtusuario.Text contiene un ID válido
                    oEstudiante = nuevoEstudiante
                };

                // Registrar inscripción
                string mensajeInscripcion = string.Empty;
                bool exitoInscripcion = new CN_Inscripcion().Registrar(nuevaInscripcion, out mensajeInscripcion);

                if (!exitoInscripcion)
                {
                    MessageBox.Show("Error al registrar la inscripción: " + mensajeInscripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar ID dinámico para el pago
                string idPago = GenerarIdDinamico(nroVoucher, fecha);

                // Crear nuevo pago
                Pago nuevoPago = new Pago
                {
                    IdPago = idPago,
                    Fecha = fecha,
                    Monto = monto,
                    MedioPago = medioPago,
                    NroVoucher = nroVoucher,
                    IdInscripcion = nuevaInscripcion.IdInscripcion // Asignar el ID de la inscripción generada automáticamente
                };

                // Registrar pago
                string mensajePago = string.Empty;
                bool exitoPago = new CN_Pago().Registrar(nuevoPago, out mensajePago);
                 LimpiarControles();

                if (exitoPago)
                {
                    MessageBox.Show("Pago registrado/modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar/modificar el pago: " + mensajePago, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void LimpiarControles()
        {
          
            txtvoucher.Text = string.Empty;
            txtmediopago.Text = string.Empty;
            txtmonto.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapaterno.Text = string.Empty;
            txtamaterno.Text = string.Empty;
            txtdeni.Text = string.Empty;
            txtcelular.Text = string.Empty;
            txtnacimiento.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtcolegio.Text = string.Empty;
            txtañoculminado.Text = string.Empty;

          
            cbosexo.SelectedIndex = -1;
            cboturno.SelectedIndex = -1;
            cbopago.SelectedIndex = -1;
            cbociclo.SelectedIndex = -1;
            cboprograma.SelectedIndex = -1; 
            cbogrupo.SelectedIndex = -1;

           
            txtfecha.Value = DateTime.Now; 

            txtvoucher.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtidestudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtapaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtamaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbosexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcolegio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtañoculminado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtvoucher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmediopago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfechapago_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtidpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboturno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbopago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbociclo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbogrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboprograma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidusuario_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodistrito.SelectedValue != null && cbodistrito.SelectedValue is int)
            {
                int distritoId = Convert.ToInt32(cbodistrito.SelectedValue);
                CargarColegios(distritoId);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboprovincia.SelectedValue != null && cboprovincia.SelectedValue is int)
            {
                int provinciaId = Convert.ToInt32(cboprovincia.SelectedValue);
                CargarDistritos(provinciaId);
            }



        }

        private void CargarDistritos(int provinciaId)
        {
            List<Distrito> distritos = cnDistrito.ListarDistritosPorProvincia(provinciaId);
            cbodistrito.DataSource = distritos;
            cbodistrito.DisplayMember = "nombredistrito";
            cbodistrito.ValueMember = "iddistrito";
            cbodistrito.SelectedIndex = -1;
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = cnDepartamento.ListarDepartamentos();
            cbodepartamentos.DataSource = departamentos;
            cbodepartamentos.DisplayMember = "nombredepartamento";
            cbodepartamentos.ValueMember = "iddepartamento";
            cbodepartamentos.SelectedIndex = -1;
        }
        private void CargarProvincias(int departamentoId)
        {
            List<Provincia> provincias = cnProvincia.ListarProvinciasPorDepartamento(departamentoId);
            cboprovincia.DataSource = provincias;
            cboprovincia.DisplayMember = "nombreprovincia";
            cboprovincia.ValueMember = "idprovincia";
            cboprovincia.SelectedIndex = -1;
        }
        private void CargarColegios(int distritoId)
        {
            List<Colegio> colegios = cnColegio.ListarColegiosPorDistrito(distritoId);
            cbocolegio.DataSource = colegios;
            cbocolegio.DisplayMember = "nombrecolegio";
            cbocolegio.ValueMember = "idcolegio";
            cbocolegio.SelectedIndex = -1;
        }

        private void cbodepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodepartamentos.SelectedValue != null && cbodepartamentos.SelectedValue is int)
            {
                int departamentoId = Convert.ToInt32(cbodepartamentos.SelectedValue);
                CargarProvincias(departamentoId);
            }


        }

        private void CargarImagen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(rutaImagen);  // Usa System.Drawing.Image
            }
        }

        // Método para convertir Image a byte[]
        private byte[] ConvertirImagenAByteArray(System.Drawing.Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.ToArray();
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
CargarImagen();
        }
    }
}
