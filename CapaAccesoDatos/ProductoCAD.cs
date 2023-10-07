using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Text.RegularExpressions;

namespace CapaAccesoDatos
{
    public class ProductoCAD
    {
        private ConexionCAD objConexionCAD; //miembros atributos
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public ProductoCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        // metodos para el crud

        public void agregarProducto(int ID_productos, string nombre_producto , string marca, decimal costo, decimal precio, int stock,
            int ID_provedor, int ID_categoria, int ID_origen) //insertar producto
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "INSERT_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_producto", ID_productos);
            comando.Parameters.AddWithValue("@nombre_producto", nombre_producto);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@ID_provedor", ID_provedor);
            comando.Parameters.AddWithValue("@ID_categoria", ID_categoria);
            comando.Parameters.AddWithValue("@ID_origen", ID_origen);

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarProducto(int ID_productos, string nombre_producto, string marca, decimal costo, decimal precio, int stock,
            int ID_provedor, int ID_categoria, int ID_origen) //actualizar producto
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "UP_DATE_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_producto", ID_productos);
            comando.Parameters.AddWithValue("@nombre_producto", nombre_producto);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@ID_provedor", ID_provedor);
            comando.Parameters.AddWithValue("@ID_categoria", ID_categoria);
            comando.Parameters.AddWithValue("@ID_origen", ID_origen);

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarProducto(int ID_productos) //eliminar producto
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "DELETE_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_producto", ID_productos);

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public DataTable consultarListaProductos()
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "CONSULTAR_PRODUCTOS";
            comando.CommandType = CommandType.StoredProcedure;
           // comando.CommandText = "select * from PRODUCTO";
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();

            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
