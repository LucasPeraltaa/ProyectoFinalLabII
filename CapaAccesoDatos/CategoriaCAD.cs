using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CategoriaCAD
    {
        private ConexionCAD objConexionCAD; //miembros atributos
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public CategoriaCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public void agregarCategoria(int ID_categoria, string categoria)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "INSERT_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_categoria", ID_categoria);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarCategoria(int ID_categoria, string categoria)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "UP_DATE_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_categoria", ID_categoria);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarCategoria(int ID_categoria)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "DELETE_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_categoria", ID_categoria);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public DataTable consultarCategoria()
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "CONSULTAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();

            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
