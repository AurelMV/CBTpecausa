using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuario cnUsuario = new CN_Usuario();
                Usuario usuario = cnUsuario.obtenerUsuario(txtusuario.Text, txtcontra.Text);

                if (usuario != null)
                {
                    Inicio formaInicio = new Inicio(usuario); // Pasar el usuario al formulario Inicio
                    formaInicio.Show();
                    this.Hide();
                    formaInicio.FormClosing += FormInicio_FormClosing;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtusuario.Text = "";
            txtcontra.Text = "";
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
