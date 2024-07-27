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
using System.Drawing.Imaging;
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
        private CN_CicloInscripcion cnciclo = new CN_CicloInscripcion();

        private CN_Grupo cngrupo = new CN_Grupo();

        private Usuario usuario;
        public formInscripcion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;


            inicializarconbos();
            InicializarComboBox();
            cargarciclos();

        }

        private void formInscripcion_Load(object sender, EventArgs e)
        {
            txtidusuario.Text = usuario.idusuarios;
            txtnombreusuario.Text = usuario.nombre;



            //List<CicloInscripcion> listaCiclo = new CN_CicloInscripcion().listar();
            //cbociclo.Items.Clear();
            //foreach (CicloInscripcion item in listaCiclo)
            //{
            //    cbociclo.Items.Add(new OpcionCombo() { Valor = item.idciclo, Texto = item.nombreCiclo });
            //}
            //cbociclo.DisplayMember = "Texto";
            //cbociclo.ValueMember = "Valor";
            //if (cbociclo.Items.Count > 0)
            //{
            //    cbociclo.SelectedIndex = 0;
            //}



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
            txtañoculminado.CustomFormat = "yyyy";

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
            cbosexo.SelectedIndex = -1;
            cbosexo.DisplayMember = "Texto";
            cbosexo.ValueMember = "Valor";
            if (cbosexo.Items.Count > 0)
            {
                cbosexo.SelectedIndex = 0;
            }

            cbomedio.Items.Add(new OpcionCombo() { Valor = "Caja central", Texto = "Caja central" });
            cbomedio.Items.Add(new OpcionCombo() { Valor = "Banco de la Nacion", Texto = "Banco de la Nacion" });
            cbomedio.SelectedIndex = -1;
            cbomedio.DisplayMember = "Texto";
            cbomedio.ValueMember = "Valor";
            if (cbomedio.Items.Count > 0)
            {
                cbomedio.SelectedIndex = 0;
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


            // Inicializar ComboBox de tipodocumento
            cbodocumento.Items.Add(new OpcionCombo() { Valor = "DNI", Texto = "DNI" });
            cbodocumento.Items.Add(new OpcionCombo() { Valor = "Pasaporte", Texto = "Pasaporte" });
            cbodocumento.DisplayMember = "Texto";
            cbodocumento.ValueMember = "Valor";
            if (cbodocumento.Items.Count > 0)
            {
                cbodocumento.SelectedIndex = 0;
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
            string dniParte = !string.IsNullOrEmpty(Dni) && Dni.Length >= 3 ? Dni.Substring(2, 3).ToUpper() : string.Empty;

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
              
                int monto;

                // Validar campos de entrada
                if (string.IsNullOrWhiteSpace(nroVoucher))
                {
                    MessageBox.Show("El número de voucher no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               

                if (!int.TryParse(txtmonto.Text, out monto))
                {
                    MessageBox.Show("El monto debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] foto = pictureBox1.Image != null ? ConvertirImagenAByteArray(pictureBox1.Image) : null;

                string nombres = txtnombre.Text.Trim();
                string aPaterno = txtapaterno.Text.Trim();
                string aMaterno = txtamaterno.Text.Trim();
                string dni = txtdeni.Text.Trim();
                string direccion = txtdireccion.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(aPaterno) || string.IsNullOrWhiteSpace(aMaterno) || string.IsNullOrWhiteSpace(dni))
                {
                    MessageBox.Show("Todos los campos de nombre y DNI deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de fecha de nacimiento
                if (!DateTime.TryParse(txtnacimiento.Text, out DateTime fechaNacimiento))
                {
                    MessageBox.Show("Formato de fecha de nacimiento inválido. Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de datos opcionales
                string celularapoderado = txtnroapoderado.Text.Trim();
                string celular = txtcelular.Text.Trim();
                string email = txtemail.Text.Trim();
                string culminado = txtañoculminado.Text.Trim();

                // Validación de ComboBoxes
                if (cbosexo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbodocumento.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbomedio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione el medio de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OpcionCombo opcionCombo3 =(OpcionCombo)cbomedio.SelectedItem;
                OpcionCombo opcionSeleccionada = (OpcionCombo)cbosexo.SelectedItem;
                OpcionCombo opcionselect = (OpcionCombo)cbodocumento.SelectedItem;
                char sexo = (char)opcionSeleccionada.Valor;
                string medio =(string)opcionCombo3.Valor;
                string tipdocument = (string)opcionselect.Valor;

                if (cbocolegio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un colegio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int? idColegio = cbocolegio.SelectedValue as int?;

                if (cboturno.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string turno = ((OpcionCombo)cboturno.SelectedItem).Texto;

                if (cbopago.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un estado de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool estadopago = Convert.ToBoolean(((OpcionCombo)cbopago.SelectedItem).Valor);

                if (cbociclo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un ciclo de inscripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idciclo = Convert.ToInt32(cbociclo.SelectedValue)  ;


                if (cboprograma.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un programa de estudios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idprogramaestudios = Convert.ToInt32(((OpcionCombo)cboprograma.SelectedItem).Valor);

                if (cbogrupo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un grupo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idGrupos = Convert.ToInt32(cbogrupo.SelectedValue)  ;


                if (!DateTime.TryParseExact(txtfecha.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaInscripcion))
                {
                    MessageBox.Show("Formato de fecha inválido. Por favor, ingrese la fecha en formato yyyy-MM-dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CelularApoderado = celularapoderado,
                    FechaNacimiento = fechaNacimiento,
                    TipoDocumento = tipdocument,
                    Email = email,
                    Direccion = direccion,
                    foto = foto,
                    AnoCulminado = culminado,
                    oColegio = idColegio.HasValue ? new Colegio { idcolegio = idColegio.Value } : null
                };

                // Generar y asignar ID dinámico para el estudiante
                string idEstudiante = GenerarIdDinamico2(nombres, aPaterno, aMaterno, dni);
                nuevoEstudiante.IdEstudiante = idEstudiante;

                // Registrar estudiante
                string mensajeEstudiante = string.Empty;
                bool exitoEstudiante = new CN_Estudiante().Registrar(nuevoEstudiante, out mensajeEstudiante);

                if (!exitoEstudiante)
                {
                    MessageBox.Show("Error al registrar el estudiante: " + mensajeEstudiante, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    oUsuario = new Usuario { idusuarios = txtidusuario.Text.Trim() },
                    oEstudiante = nuevoEstudiante
                };

                // Registrar inscripción
                string mensajeInscripcion = string.Empty;
                bool exitoInscripcion = new CN_Inscripcion().Registrar(nuevaInscripcion, out mensajeInscripcion, dni);

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
                    MedioPago = medio,
                    NroVoucher = nroVoucher,
                    IdInscripcion = nuevaInscripcion.IdInscripcion
                };

                // Registrar pago
                string mensajePago = string.Empty;
                bool exitoPago = new CN_Pago().Registrar(nuevoPago, out mensajePago);

                if (!exitoPago)
                {
                    MessageBox.Show("Error al registrar/modificar el pago: " + mensajePago, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LimpiarControles();
                MessageBox.Show("Pago e Inscripción registradas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            txtmonto.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapaterno.Text = string.Empty;
            txtamaterno.Text = string.Empty;
            txtdeni.Text = string.Empty;
            txtcelular.Text = string.Empty;
            txtnacimiento.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtañoculminado.Text = string.Empty;

          
            cbosexo.SelectedIndex = -1;
            cboturno.SelectedIndex = -1;
            cbopago.SelectedIndex = -1;
            cbociclo.SelectedIndex = -1;
            cboprograma.SelectedIndex = -1; 
            cbogrupo.SelectedIndex = -1;
            cbomedio.SelectedIndex = -1;

           
            txtfecha.Value = DateTime.Now; 

            txtvoucher.Focus();
        }

        private void txtidpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidusuario_TextChanged(object sender, EventArgs e)
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
                try
                {
                    // Liberar la imagen anterior si existe
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    // Cargar la nueva imagen
                    pictureBox1.Image = System.Drawing.Image.FromFile(rutaImagen);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Error: Memoria insuficiente para cargar la imagen. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para convertir Image a byte[]
        private byte[] ConvertirImagenAByteArray(System.Drawing.Image imagen)
        {
            if (imagen == null)
            {
                return null; // Devuelve null si no hay imagen
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            formColegios formularioInterfaz = new formColegios();

            // Configurar la ventana para que se muestre por encima del formulario principal
            formularioInterfaz.StartPosition = FormStartPosition.CenterParent;

            // Mostrar el nuevo formulario
            formularioInterfaz.ShowDialog(); // Usa S
        }

        private void cbociclo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbociclo.SelectedValue != null && cbociclo.SelectedValue is int)
            {
                int idciclo = Convert.ToInt32(cbociclo.SelectedValue);
                cargargrupos(idciclo);
              
            }




        }

        private void cargargrupos(int idciclo)
        {
            List<Grupo> grup = cngrupo.Listargrupconcicloyactivo(idciclo);
            cbogrupo.DataSource = grup;
            cbogrupo.DisplayMember = "nombreGrupo";
            cbogrupo.ValueMember = "idGrupos";
            cbogrupo.SelectedIndex = -1;
        }

        private void cargarciclos()
        {
            List<CicloInscripcion> ciclo = cnciclo.listar();
            cbociclo.DataSource = ciclo;
            cbociclo.DisplayMember = "nombreCiclo";
            cbociclo.ValueMember = "idciclo";
            cbociclo.SelectedIndex = -1;

        }

        private void cbogrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
