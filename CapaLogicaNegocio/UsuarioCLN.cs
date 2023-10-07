using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class UsuarioCLN
    {
        private UsuarioCAD objUsuarioCAD;

        public UsuarioCLN()
        {
            objUsuarioCAD = new UsuarioCAD();
        }

        public int validarUsuario(string nombreUsuario, string contrasena)
        {
            
            int bandera = 0;

            bandera = objUsuarioCAD.validarUsuario(nombreUsuario, contrasena);
            return bandera;
        }

    }
}
