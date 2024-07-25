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
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
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

        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.BackColor = Color.Red;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.BackColor= Color.DarkRed;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimizar_MouseEnter(object sender, EventArgs e)
        {
            lblMinimizar.BackColor = Color.DarkGray;
        }

        private void lblMinimizar_MouseLeave(object sender, EventArgs e)
        {
            lblMinimizar.BackColor= Color.DimGray;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = label1.PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
