using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class OrigenCAD
    {
        private ConexionCAD objConexionCAD; //miembros atributos
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public OrigenCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public void agregarOrigen(int ID_origen, string origen)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "INSERT_ORIGEN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_origen", ID_origen);
            comando.Parameters.AddWithValue("@origen", origen);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarOrigen(int ID_origen, string origen)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "UP_DATE_ORIGEN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_origen", ID_origen);
            comando.Parameters.AddWithValue("@origen", origen);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarOrigen(int ID_origen)
        {
            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "DELETE_ORIGEN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@ID_origen", ID_origen);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public DataTable consultarOrigen()
        {
            comando.Connection = objConexionCAD.abrirConeccion();

            comando.CommandText = "CONSULTAR_ORIGEN";
            comando.CommandType = CommandType.StoredProcedure;
            
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();

            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }
    }
}
