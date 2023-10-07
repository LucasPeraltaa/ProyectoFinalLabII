using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class VentaCLN
    {
        private VentaCAD objVentaCAD;
        private DataTable miTablaVenta;
        private object ID_VENTA;

        public VentaCLN()
        {
            miTablaVenta = new DataTable();
            objVentaCAD = new VentaCAD();
            ID_VENTA = new object();
        }

        public DataTable consultarListaVenta()
        {
            miTablaVenta = objVentaCAD.consultarListaVenta();
            return miTablaVenta;
        }

        public void agregarVenta(object ID_VENTA, string fecha, string cantidad, string precioTotal, object idProductos)
        {
            objVentaCAD.agregarVenta(Convert.ToInt32(ID_VENTA) + 1, Convert.ToDateTime(fecha), Convert.ToInt32(cantidad), 
                Convert.ToDecimal(precioTotal), Convert.ToInt32(idProductos));
        }

        public void actualizarVenta(object ID_VENTA, string fecha, string cantidad, string precioTotal, object idProductos)
        {
            objVentaCAD.actualizarVenta(Convert.ToInt32(ID_VENTA) +1, Convert.ToDateTime(fecha), Convert.ToInt32(cantidad), 
                Convert.ToDecimal(precioTotal), Convert.ToInt32(idProductos));
        }

        public void eliminarVenta(object idVenta)
        {
            objVentaCAD.eliminarVenta(Convert.ToInt32(idVenta));
        }

        public int getPosicionUltFila(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }
}
