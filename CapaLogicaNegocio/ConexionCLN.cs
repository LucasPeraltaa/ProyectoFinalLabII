using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class ConexionCLN
    {
        private ConexionCAD miConexion;
        public ConexionCLN()
        {
            miConexion = new ConexionCAD();
        }

        public ConexionCAD getConexion()
        {
            return miConexion;
        }
    }
}
