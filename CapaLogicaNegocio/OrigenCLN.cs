using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class OrigenCLN
    {
        private DataTable miTabla;
        private OrigenCAD objOrigenCAD;
        private object ID_ORIGEN;

        public OrigenCLN()
        {
            miTabla = new DataTable();
            objOrigenCAD = new OrigenCAD();
            ID_ORIGEN = new object();
        }

        public DataTable consultarOrigen()
        {
            miTabla = objOrigenCAD.consultarOrigen();
            return miTabla;
        }

        public void agregarOrigen(object ID_origen, string origen)
        {
            objOrigenCAD.agregarOrigen(Convert.ToInt32(ID_origen) + 1, origen);    
        }

        public void eliminarOrigen(object ID_origen)
        {
            objOrigenCAD.eliminarOrigen(Convert.ToInt32(ID_origen));
        }

        public void actualizarOrigen(object ID_origen, string origen)
        {
            objOrigenCAD.actualizarOrigen(Convert.ToInt32(ID_origen), origen);
        }

        public int getPosicionUltFila(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }

    
}
