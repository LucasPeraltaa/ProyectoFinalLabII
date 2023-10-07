using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class ConexionCAD
    {
        public string cadenaConexion;
        private SqlConnection conectarBD;
        
        public ConexionCAD()
        {
            cadenaConexion = "Data Source = DESKTOP-7F22TEQ\\SQLEXPRESS;Initial Catalog = MOTOTUC; User ID = sa; " +
                                                                                            "Password=laboratorio2";
            conectarBD = new SqlConnection();
            conectarBD.ConnectionString = cadenaConexion;
        }
        
        ~ConexionCAD()
        {
            Console.WriteLine("out...");
        }

       /* public void abrirConexion()
        {
            try
            {
                conectarBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión no se pudo abrir " + ex.Message);
            }
        }*/

        public SqlConnection abrirConeccion()
        {
            try
            {
                conectarBD.Open();
                return conectarBD;

            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión no se pudo abrir " + ex.Message);
                return conectarBD;
            }
        }

        public void cerrarConexion()
        {
            conectarBD.Close();
        }
        public SqlConnection getConexion()
        {
            return conectarBD;
        }

    }
}
