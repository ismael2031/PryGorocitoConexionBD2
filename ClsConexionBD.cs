using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PryGorocitoConexionBD2
{
    internal class ClsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";

        //conector
        private SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        // método para abrir la conexión
        public void ConectarBD()
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();
                nombreBaseDeDatos = conexionBaseDatos.Database;

                MessageBox.Show("Conexión exitosa a la base de datos: " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al conectar: " + error.Message);
            }
        }

        // método para obtener la conexión abierta
        public SqlConnection ObtenerConexion()
        {
            return conexionBaseDatos;
        }
    }
}
