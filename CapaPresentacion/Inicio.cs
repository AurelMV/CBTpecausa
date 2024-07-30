using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapadeEntidad;
using CapaEntidad;
using FontAwesome.Sharp;
using Org.BouncyCastle.Asn1.X509;

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
            label3.Text = usuarioActual.nombre+" "+usuarioActual.aPaterno+" "+usuarioActual.aMaterno;
            AjustarLabel3();
            if (usuarioActual.oRol.idrol == 1)
            {
                label2.Text = "ADMINISTRADOR";
                AjustarLabel2();
            }
            if (usuarioActual.oRol.idrol == 2)
            {
                label2.Text = "USUARIO";
                AjustarLabel2();
                menuusuario.Visible = false;
            }
        }

        private void AjustarLabel3()
        {
            int formWidth = this.ClientSize.Width;
            int maxLabelWidth = formWidth - 10;
            int desiredWidth = TextRenderer.MeasureText(label3.Text, label3.Font).Width;
            if (desiredWidth > maxLabelWidth)
            {
                label3.Width = maxLabelWidth;
                label3.Left = formWidth - maxLabelWidth - 10;
                label3.AutoEllipsis = true;
            }
            else
            {
                label3.Width = desiredWidth;
                label3.Left = formWidth - desiredWidth - 10;
                label3.AutoEllipsis = false;
            }
        }

        private void AjustarLabel2()
        {
            int formWidth = this.ClientSize.Width;
            int maxLabelWidth = formWidth - 10;
            int desiredWidth = TextRenderer.MeasureText(label2.Text, label2.Font).Width;
            if (desiredWidth > maxLabelWidth)
            {
                label2.Width = maxLabelWidth;
                label2.Left = formWidth - maxLabelWidth - 10;
                label2.AutoEllipsis = true;
            }
            else
            {
                label2.Width = desiredWidth;
                label2.Left = formWidth - desiredWidth - 10;
                label2.AutoEllipsis = false;
            }
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

