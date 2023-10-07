using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class UsuarioCAD
    {
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public UsuarioCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public int validarUsuario(string nombreUsuario, string contrasena)
        {
            int bandera = 0;

            comando.Connection = objConexionCAD.abrirConeccion();
            comando.CommandText = "VALIDAR_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            leerTabla = comando.ExecuteReader();

            if (leerTabla.Read())
            {
                bandera = 1;
            }

            leerTabla.Close();

            objConexionCAD.cerrarConexion();
            return bandera;
        }
    }
}
