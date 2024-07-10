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
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public static Usuario usuarioActual;
        public static IconMenuItem MenuActivo =null;
        public static Form FormularioActivo =null;  

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            label3.Text = "Usuario: "+usuarioActual.nombre+" "+usuarioActual.aPaterno+" "+usuarioActual.aMaterno;
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void AbrirForma(IconMenuItem menu,Form formulario) {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor= Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo=menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                
            }
            FormularioActivo= formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
          
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menudocentes_Click(object sender, EventArgs e)
        {

        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender,new formUsuario());
        }

        private void menuinformacion_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formInfo());
        }

        private void menugrupos_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formGrupos());
        }

        private void menucursos_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formCurso());

        }

        private void menuprogramas_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formProgramas());
        }

        private void menuciclos_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formCiclos());
        }

        private void sudmenuinscripcion_Click(object sender, EventArgs e)
        {
            formInscripcion frmInscripcion = new formInscripcion(usuarioActual);
            AbrirForma(menuinscripcion, frmInscripcion);
        }

        private void sudmenuestudiantes_Click(object sender, EventArgs e)
        {
            AbrirForma(menuinscripcion, new formEstudiantes());
        }

        private void sudmenupagos_Click(object sender, EventArgs e)
        {
            AbrirForma(menuinscripcion, new formGestionPago());
        }

        private void inscripcionDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(menudocentes, new formDocente());
        }

        private void datosDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(menudocentes, new formInfoDocentes());
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void relacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(menudocentes, new formRelaciones());
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(menuinscripcion, new formGestionInscripcion());
        }
    }
 }

