using CapaEntidad;
using CapaNegocio;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            configurarDataGridView();
            cargarUsuarios();
        }

        private void iduser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = string.Empty;
                if (txtContrasenia.Text == txtConfirContra.Text)
                {
                    clave = txtContrasenia.Text;
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtApaternoUsuario.Text) || string.IsNullOrEmpty(txtAmaternoUsuario.Text) || string.IsNullOrEmpty(txtUserUsuario.Text))
                {
                    MessageBox.Show("Por favor, ingrese datos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string idDinamico = GenerarIdDinamico(txtNombreUsuario.Text, txtApaternoUsuario.Text, txtAmaternoUsuario.Text, txtUserUsuario.Text);
                Usuario nuevoUsuario = new Usuario
                {
                    idusuarios = idDinamico,
                    user = txtUserUsuario.Text,
                    password = clave,
                    tipo = cboxTipoUsuario.Text,
                    estado = cboxEstadoUsuario.Text,
                    nombre = txtNombreUsuario.Text,
                    aPaterno = txtApaternoUsuario.Text,
                    aMaterno = txtAmaternoUsuario.Text
                };
                CN_Usuario user = new CN_Usuario();
                if (string.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    user.insertarUsuarios(nuevoUsuario);
                    MessageBox.Show("Usuario registrado correctamente");
                }
                else {
                    user.actualizarUsuarios(nuevoUsuario);
                    MessageBox.Show("Usuario modificado correctamente");
                }
                cargarUsuarios();
                limpiar();
            }
            catch (Exception ex) {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void cargarUsuarios() {
            List<Usuario> listausuarios = new CN_Usuario().Listar();
            dataGridView1.DataSource = listausuarios;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var usuario = row.DataBoundItem as Usuario;
                if (usuario != null)
                {
                    CN_Usuario usuarioNuevo = new CN_Usuario();
                    usuarioNuevo.actualizarUsuarios(usuario);
                }
            }
        }

        private string GenerarIdDinamico(string nombre, string aPaterno, string aMaterno, string user)
        {
            char Nombre = !string.IsNullOrEmpty(nombre) ? nombre[0] : ' ';
            char Apaterno = !string.IsNullOrEmpty(aPaterno) ? aPaterno[0] : ' ';
            char Amaterno = !string.IsNullOrEmpty(aMaterno) ? aMaterno[0] : ' ';
            char User = !string.IsNullOrEmpty(user) ? user[0] : ' ';

            string idDinamico = $"{Nombre}{Apaterno}{Amaterno}{User}";

            return idDinamico;
        }

        private void limpiar() { 
            txtIdUsuario.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtApaternoUsuario.Text = string.Empty;
            txtAmaternoUsuario.Text = string.Empty;
            txtUserUsuario.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            txtConfirContra.Text = string.Empty;
            cboxTipoUsuario.SelectedIndex = -1;
            cboxEstadoUsuario.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                var usuario = filaSeleccionada.DataBoundItem as Usuario;
                if (usuario != null)
                {
                    txtIdUsuario.Text = usuario.idusuarios;
                    txtNombreUsuario.Text = usuario.nombre;
                    txtApaternoUsuario.Text = usuario.aPaterno;
                    txtAmaternoUsuario.Text = usuario.aMaterno;
                    txtUserUsuario.Text = usuario.user;
                    txtContrasenia.Text = usuario.password;
                    txtConfirContra.Text = usuario.password;
                    cboxTipoUsuario.SelectedItem = usuario.tipo;
                    cboxEstadoUsuario.SelectedItem = usuario.estado;
                }
            }
        }
        private void configurarDataGridView()
        {
            var nombre = new DataGridViewTextBoxColumn { DataPropertyName = "nombre", HeaderText = "Nombre", ReadOnly = true };
            var aPaterno = new DataGridViewTextBoxColumn { DataPropertyName = "aPaterno", HeaderText = "Apellido P.", ReadOnly = true };
            var aMaterno = new DataGridViewTextBoxColumn { DataPropertyName = "aMaterno", HeaderText = "Apellido M.", ReadOnly = true };
            var user = new DataGridViewTextBoxColumn { DataPropertyName = "user", HeaderText = "Usuario", ReadOnly = true };
            var password = new DataGridViewTextBoxColumn { DataPropertyName = "password", HeaderText = "Clave", ReadOnly = true };
            var tipo = new DataGridViewTextBoxColumn { DataPropertyName = "tipo", HeaderText = "Tipo", ReadOnly = true };
            var estado = new DataGridViewTextBoxColumn { DataPropertyName = "estado", HeaderText = "Estado", ReadOnly = true };
            dataGridView1.Columns.Add(nombre);
            dataGridView1.Columns.Add(aPaterno);
            dataGridView1.Columns.Add(aMaterno);
            dataGridView1.Columns.Add(user);
            dataGridView1.Columns.Add(password);
            dataGridView1.Columns.Add(tipo);
            dataGridView1.Columns.Add(estado);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
