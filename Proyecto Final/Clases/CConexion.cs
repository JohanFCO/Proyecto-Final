using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    class CConexion
    {
        static String Server = "Server=DESKTOP-DUU22CK;";
        static String DB = "Database=dbprueba;";
        static String User = ";";
        static String Pass = ";";
        static String Security = "Trusted_Connection=True;";
        String cd = Server + DB + User + Pass + Security;
        SqlConnection cnn = new();

        public CConexion()
        {
            cnn.ConnectionString = cd;
        }
        public void abrir()
        {
            try
            {
                cnn.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al abrir BD ", ex.Message);
            }
        }
        public void cerrar()
        {

            try
            {
                cnn.Close();
                MessageBox.Show("Conexion Terminada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cerrar BD ", ex.Message);
            }
        }
    }

}