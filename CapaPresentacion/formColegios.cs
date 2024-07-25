using CapadeEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formColegios : Form
    {
        private CN_Departamento cnDepartamento = new CN_Departamento();
        private CN_Provincia cnProvincia = new CN_Provincia();
        private CN_DIstrito cnDistrito = new CN_DIstrito();
        public formColegios()
        {
            InitializeComponent();
        }

        private void formColegios_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {

            string nombrecole = txtnombrecle.Text;

            int? idDistrito = cbodistrito.SelectedValue != null ?
                       (int?)Convert.ToInt32(cbodistrito.SelectedValue) : (int?)null;
            Colegio colegio = new Colegio
            {
                nombrecolegio = txtnombrecle.Text,


                odistrito = idDistrito.HasValue ? new Distrito { iddistrito = idDistrito.Value } : null

            };

            CN_Colegio cnColegio = new CN_Colegio();
            bool resultado = cnColegio.AgregarColegio(colegio);

            if (resultado)
            {
                MessageBox.Show("Colegio agregado con éxito.");
                // Limpia los campos o cierra el formulario según sea necesario
            }
            else
            {
                MessageBox.Show("Error al agregar el colegio.");
            }




        }

        private void cbodepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodepartamentos.SelectedValue != null && cbodepartamentos.SelectedValue is int)
            {
                int departamentoId = Convert.ToInt32(cbodepartamentos.SelectedValue);
                CargarProvincias(departamentoId);
            }

        }

        private void cboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboprovincia.SelectedValue != null && cboprovincia.SelectedValue is int)
            {
                int provinciaId = Convert.ToInt32(cboprovincia.SelectedValue);
                CargarDistritos(provinciaId);
            }
        }

        private void cbodistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodistrito.SelectedItem != null)
            {
                Distrito distritoSeleccionado = (Distrito)cbodistrito.SelectedItem;
                txtDistritoSeleccionado.Text =  Convert.ToString(distritoSeleccionado.iddistrito) ;
            }

        }
    }
}
