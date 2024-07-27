using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            cbodocumento.Items.Add(new OpcionCombo() { Valor = "DNI", Texto = "DNI" });
            cbodocumento.Items.Add(new OpcionCombo() { Valor = "Pasaporte", Texto = "Pasaporte" });
            cbodocumento.DisplayMember = "Texto";
            cbodocumento.ValueMember = "Valor";
            if (cbodocumento.Items.Count > 0)
            {
                cbodocumento.SelectedIndex = 0;
            }

            txtnacimiento.Format = DateTimePickerFormat.Custom;
            txtnacimiento.CustomFormat = "yyyy-MM-dd";

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
                        txttipodocu.Text = dataGridView1.Rows[indice].Cells["tipodocumento"].Value?.ToString() ?? string.Empty;
                        var fotoData = dataGridView1.Rows[indice].Cells["Foto"].Value as byte[];
                        if (fotoData != null && fotoData.Length > 0)
                            using (var ms = new MemoryStream(fotoData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }

                       
                        OpcionCombo opcionSeleccionada = (OpcionCombo)cbosexo.SelectedItem;
                       

                        // Acceder al valor 'Valor' y convertirlo a char
                  
                        char sexo = Convert.ToChar(opcionSeleccionada.Valor);

                        // Asignar el valor de 'sexo' a la celda correspondiente en el DataGridView
                        dataGridView1.Rows[indice].Cells["Sexo"].Value = sexo.ToString();
                       
                        

                        txtcelular.Text = dataGridView1.Rows[indice].Cells["Celular"].Value?.ToString() ?? string.Empty;
                        txtcelularapoderado.Text = dataGridView1.Rows[indice].Cells["Celular_Apoderado"].Value?.ToString() ?? string.Empty;
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

                        txtdireccion.Text = dataGridView1.Rows[indice].Cells["direccion"].Value?.ToString() ?? string.Empty;
                        txtemail.Text = dataGridView1.Rows[indice].Cells["Email"].Value?.ToString() ?? string.Empty;
                        txtcolegio.Text = dataGridView1.Rows[indice].Cells["Nombre_Colegio"].Value?.ToString() ?? string.Empty;
                        txtanoculminado.Text = dataGridView1.Rows[indice].Cells["Año_Culminado"].Value?.ToString() ?? string.Empty;
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
            "", item.IdEstudiante, item.Nombres, item.APaterno, item.AMaterno, item.Sexo ,item.CelularEstudiante, item.CelularApoderado,item.FechaNacimiento,item.Email,item.AnoCulminado,item.Documneto,item.TipoDocumento,item.Direccion,item.foto, item.oColegio.idcolegio,item.oColegio.nombrecolegio,
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
        private byte[] ConvertirImagenAByteArraySeguro(Image imagen)
        {
            if (imagen == null)
            {
                return null;
            }

            try
            {
                // Clonar la imagen antes de convertirla
                using (Image clonedImage = new Bitmap(imagen))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la imagen: " + ex.Message, "Error de Conversión de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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
                string celularapoderado = txtcelularapoderado.Text;
                string celular = txtcelular.Text;
                byte[] foto2 = ConvertirImagenAByteArraySeguro(pictureBox1.Image);
                string email = txtemail.Text;

                Estudiante nuevoEstudiante = new Estudiante
                {
                    IdEstudiante = txtidestudiante.Text,
                    Nombres = nombres,
                    APaterno = aPaterno,
                    AMaterno = aMaterno,
                    Documneto = dni,
                    foto = foto2,
                    CelularEstudiante = celular,
                    CelularApoderado = celularapoderado,
                    Email = email
                };

                
                    bool modificado = new CN_Estudiante().Editar(nuevoEstudiante, out mensaje);
                    if (!modificado)
                    {
                        MessageBox.Show("Error al actualizar el estudiante: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LimpiarCampos();
                        MessageBox.Show("Estudiante actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrupos();
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar el estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private byte[] ConvertirImagenAByteArray(System.Drawing.Image imagen)
        {
            if (imagen == null)
            {
                return null; 
            }

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.ToArray();
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
                        pictureBox1.Image = null; 
                    }

                    // Cargar la nueva imagen
                    pictureBox1.Image = Image.FromFile(rutaImagen);
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

        private void button1_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void LimpiarCampos()
        {
            txtindice.Text = string.Empty;
            txtidestudiante.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapaterno.Text = string.Empty;
            txtamaterno.Text = string.Empty;
            txtdeni.Text = string.Empty;
            pictureBox1.Image = null;
           
            txtcelular.Text = string.Empty;
            txtcelularapoderado.Text = string.Empty;
            txtnacimiento.Value = DateTime.Today; // o cualquier valor por defecto que prefieras
            txtdireccion.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtcolegio.Text = string.Empty;
            txtanoculminado.Text = string.Empty;
        }
        public void MostrarImagen(int indice)
        {
            var fotoData = dataGridView1.Rows[indice].Cells["Foto"].Value as byte[];
            if (fotoData != null && fotoData.Length > 0)
            {
                using (var ms = new MemoryStream(fotoData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null; 
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
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
    }
}
