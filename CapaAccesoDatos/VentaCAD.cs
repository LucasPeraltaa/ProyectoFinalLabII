using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class VentaCAD
    {
        private ConexionCAD objConexionCAD;
        private DataTable miTablaVenta;
        private SqlDataReader leerTabla;
        private SqlCommand comando;

        public VentaCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTablaVenta = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarListaVenta()
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "SELECT_VENTA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            leerTabla = comando.ExecuteReader();
            miTablaVenta.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTablaVenta;
        }
        public void agregarVenta(int idVenta, DateTime fecha, int cantidad, decimal precioTotal, int idProductos)
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "INSERT_VENTA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_venta", idVenta);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@total_venta", precioTotal);
            comando.Parameters.AddWithValue("@ID_productos", idProductos);

            comando.ExecuteReader();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarVenta(int idVenta)
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "DELETE_VENTA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_venta", idVenta);

            comando.ExecuteReader();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarVenta(int idVenta, DateTime fecha, int cantidad, decimal precioTotal, int idProductos)
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "UPDATE_VENTA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_venta", idVenta);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@total_venta", precioTotal);
            comando.Parameters.AddWithValue("@ID_productos", idProductos);

            comando.ExecuteReader();
            objConexionCAD.cerrarConexion();
        }
    }
}
