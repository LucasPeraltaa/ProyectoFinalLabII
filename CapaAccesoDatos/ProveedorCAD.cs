using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ProveedorCAD
    {
        private ConexionCAD objConexionCAD; //miembros atributos
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        // metodos para CRUD y construcvtor

        public ProveedorCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        // agregar un proveedor (repetir lo mismo con los demas y modificar los parametros)

        public void agregarProveedor(int ID_proveedor, string nombre_proveedor, 
                                        int telefono, string nombre_vendedor)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "INSERT_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_provedor", ID_proveedor);
            comando.Parameters.AddWithValue("@nombre_proveedor", nombre_proveedor);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@nombre_vendedor", nombre_vendedor);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarProveedor(int ID_proveedor, string nombre_proveedor,
                                        int telefono, string nombre_vendedor)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "UP_DATE_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_provedor", ID_proveedor);
            comando.Parameters.AddWithValue("@nombre_proveedor", nombre_proveedor);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@nombre_vendedor", nombre_vendedor);

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        // cmd.CommandText = "insert into proveedor(razon_social,sector_comercial,direccion,telefono) values('" + razon_social + "','" + sector_comercial + "','" + direccion + "','" + telefono + "')";

        public void eliminarProveedor(int ID_proveedor)
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "DELETE_PROVEEDOR";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@ID_provedor", ID_proveedor);

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public DataTable consultarProveedores()
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "CONSULTAR_PROVEEDOR";
           // comando.CommandText = "select * from proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
