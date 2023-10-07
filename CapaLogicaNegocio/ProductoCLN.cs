using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class ProductoCLN
    {
        // miembros atributos

        private DataTable miTabla;
        private ProductoCAD objProductoCad;
        private object ID_PRODUCTO;

        //CONSTRUCTOR

        public ProductoCLN()
        {
            miTabla = new DataTable();
            objProductoCad = new ProductoCAD();
            ID_PRODUCTO = new object();
        }

        public DataTable consultarListaProductos()
        {
            miTabla = objProductoCad.consultarListaProductos();
            return miTabla;
        }

        public void agregarProducto(object ID_productos, string nombre_producto, string marca, string costo, string precio,
                                                   string stock, object ID_provedor, object ID_categoria, object ID_origen)
        {
            objProductoCad.agregarProducto((Convert.ToInt32(ID_productos) + 1), nombre_producto, marca, (Convert.ToInt32(costo)), (Convert.ToInt32(precio)),
                (Convert.ToInt32(stock)), (Convert.ToInt32(ID_provedor) + 1), (Convert.ToInt32(ID_categoria) + 1), (Convert.ToInt32(ID_origen) + 1));
        }

        public void actualizarProducto(object ID_productos, string nombre_producto, string marca, string costo, string precio,
                                                   string stock, object ID_provedor, object ID_categoria, object ID_origen)
        {
            objProductoCad.actualizarProducto((Convert.ToInt32(ID_productos) + 1), nombre_producto, marca, (Convert.ToInt32(costo)), (Convert.ToInt32(precio)),
                (Convert.ToInt32(stock)), (Convert.ToInt32(ID_provedor) + 1), (Convert.ToInt32(ID_categoria) + 1), (Convert.ToInt32(ID_origen) + 1));
        }

        public void eliminarProducto(object ID_productos)
        {
            objProductoCad.eliminarProducto(Convert.ToInt32(ID_productos));
        }

        public int getPosicionUltFila(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }
}
