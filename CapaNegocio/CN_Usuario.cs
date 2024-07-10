using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public void insertarUsuarios(Usuario usuarioNuevo) { 
            objcd_usuario.insertarUsuarios(usuarioNuevo);
        }

        public void actualizarUsuarios(Usuario usuario) { 
            objcd_usuario.actualizarUsuarios(usuario);
        }
        public Usuario obtenerUsuario(string usuario, string contrasena)
        {
            return objcd_usuario.ObtenerUsuario(usuario, contrasena);
        }
    }
}
