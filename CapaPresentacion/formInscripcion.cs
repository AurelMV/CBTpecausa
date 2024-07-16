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

        private CN_Departamento DEPA = new CN_Departamento();
        private CN_DIstrito DESTRI = new CN_DIstrito();
        private CN_Provincia PROVI = new CN_Provincia();
        private CN_Colegio COLE = new CN_Colegio();

        private Usuario usuario;
        public formInscripcion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            ///dffdgfgdassdfg
           
        }

        private void formInscripcion_Load(object sender, EventArgs e)
        {
            txtidusuario.Text = usuario.idusuarios;
            txtnombreusuario.Text = usuario.nombre;

            inicializarconbos();
            InicializarComboBox();
            ListarDepartamento();

            txtnacimiento.Format = DateTimePickerFormat.Custom;
            txtnacimiento.CustomFormat = "yyyy-MM-dd";

            txtañoculminado.Format = DateTimePickerFormat.Custom;
            txtañoculminado.CustomFormat = "yyyy-MM-dd";

            txtfecha.Format = DateTimePickerFormat.Custom;
            txtfecha.CustomFormat = "yyyy-MM-dd";

            txtfechapago.Format = DateTimePickerFormat.Custom;
            txtfechapago.CustomFormat = "yyyy-MM-dd";

           // CargarComboBoxDepartamentos();

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
                    Celular = celular,
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

        //private void CargarComboBoxDepartamentos()
        //{
        //    List<Departamento> departamentos = DEPA.ObtenerDepartamentos();
        //    cbodepartamentos.DataSource = departamentos;
        //    cbodepartamentos.DisplayMember = "NombreDepartamento";
        //    cbodepartamentos.ValueMember = "IdDepartamento";
        //    cbodepartamentos.SelectedIndex = -1; // Limpiar selección
        //}



        //private void CargarComboBoxProvincias(int departamentoId)
        //{
        //    List<Provincia> provincias = PROVI.ObtenerProvinciasPorDepartamento(departamentoId);
        //    cboprovincia.DataSource = provincias;
        //    cboprovincia.DisplayMember = "NombreProvincia";
        //    cboprovincia.ValueMember = "IdProvincia";
        //    cboprovincia.SelectedIndex = -1; // Limpiar selección
        //}


        //private void CargarComboBoxDistritos(int provinciaId)
        //{
        //    List<Distrito> distritos = DESTRI.ObtenerDistritosPorProvincia(provinciaId);
        //    cbodistrito.DataSource = distritos;
        //    cbodistrito.DisplayMember = "NombreDistrito";
        //    cbodistrito.ValueMember = "IdDistritos";
        //    cbodistrito.SelectedIndex = -1; // Limpiar selección
        //}

        //private void CargarComboBoxColegios(int distritoId)
        //{
        //    List<Colegio> colegios = COLE.ObtenerColegiosPorDistrito(distritoId);
        //    cbocolegio.DataSource = colegios;
        //    cbocolegio.DisplayMember = "NombreColegio";
        //    cbocolegio.ValueMember = "IdColegios";
        //    cbocolegio.SelectedIndex = -1; // Limpiar selección
        //}

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Distrito oDistrito = (Distrito)cbodistrito.SelectedItem;
            if (oDistrito != null)
            {
                cbocolegio.DataSource = new CN_Operaciones().ObtenerColegios(oDistrito.iddistrito);
                cbocolegio.ValueMember = "idcolegio";
                cbocolegio.DisplayMember = "nombrecolegio";
            }



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbodistrito.SelectedValue != null && int.TryParse(cbodistrito.SelectedValue.ToString(), out int distritoId))
            //{
            //    CargarComboBoxColegios(distritoId);
            //}
            //else
            //{
            //    // Limpiar ComboBox de Colegios si no hay selección de distrito
            //    cbocolegio.DataSource = null;
            //    cbocolegio.Items.Clear();
            //}
            Provincia oProvincia = (Provincia)cboprovincia.SelectedItem;
            if (oProvincia != null)
            {
                cbodistrito.DataSource = new CN_Operaciones().ObtenerDistritos(oProvincia.idprovincia);
                cbodistrito.ValueMember = "iddistrito";
                cbodistrito.DisplayMember = "nombredistrito";
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboprovincia.SelectedValue != null && int.TryParse(cboprovincia.SelectedValue.ToString(), out int provinciaId))
            //{
            //    CargarComboBoxDistritos(provinciaId);
            //}
            //else
            //{
            //    // Limpiar ComboBox de Distritos si no hay selección de provincia
            //    cbodistrito.DataSource = null;
            //    cbodistrito.Items.Clear();
            //}
            Departamento oDepartamento = (Departamento)cbodepartamentos.SelectedItem;
            if (oDepartamento != null)
            {
                cboprovincia.DataSource = new CN_Operaciones().ObtenerProvincias(oDepartamento.iddepartamento);
                cboprovincia.ValueMember = "idprovincia";
                cboprovincia.DisplayMember = "nombreprovincia";
            }



        }

      



        private void ListarDepartamento() {
            cbodepartamentos.DataSource = new CN_Operaciones().ObtenerDepartamentos();
            cbodepartamentos.ValueMember = "iddepartamento";
            cbodepartamentos.DisplayMember = "nombredepartamento";

        }





    }
}
