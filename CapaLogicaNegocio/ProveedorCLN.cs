using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data.SqlClient;

namespace CapaLogicaNegocio
{
    public class ProveedorCLN
    {
        // m atribu

        private DataTable miTabla;
        private ProveedorCAD objProveedorCAD;
        private object valorUltID;
        
        // construc

        public ProveedorCLN()
        {
            miTabla = new DataTable();
            objProveedorCAD = new ProveedorCAD();
            valorUltID = new object();
        }

        public DataTable consultarProveedores() //mostrar
        {
            miTabla = objProveedorCAD.consultarProveedores();
            return miTabla;
        }

        public void agregarProveedor(object valorUltID, string nombre_proveedor, string telefono, string nombre_vendedor)
        {
            int ID_proveedor = Convert.ToInt32(valorUltID) + 1;
            objProveedorCAD.agregarProveedor(ID_proveedor, nombre_proveedor, Convert.ToInt32(telefono), nombre_vendedor);
        }
        public void actualizarProveedor(object valorUltID, string nombre_proveedor,
                                        string telefono, string nombre_vendedor)
        {
            int ID_proveedor = Convert.ToInt32(valorUltID);
            objProveedorCAD.actualizarProveedor(ID_proveedor, nombre_proveedor, Convert.ToInt32(telefono), nombre_vendedor);
        }


        public void eliminarProveedor(object valorUltID)
        {
            int ID_proveedor = Convert.ToInt32(valorUltID);
            objProveedorCAD.eliminarProveedor(ID_proveedor);
        }


        public int getPosicionUltFila(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }
}
