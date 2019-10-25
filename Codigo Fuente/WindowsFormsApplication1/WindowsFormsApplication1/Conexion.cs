using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistrosActas
{
    //Clase que se conecta con la base de datos.
  public  class Conexion
    {
        private Conexion()
        {
        }
        //Parametros para conectarce a la base de datos
        private static Conexion conexionObj;
        private String serverID = "sbogche008v\\terceros";
        private String dataBase = "fichero";
        // private String Security= "true";
        private String usuario = "Sevenet";
        private string password = "S3v3n3t";

        private SqlConnection sqlConexion;

        //Metodo que retorna el onjeto de tipo Conexion
        public static Conexion getConexionObj()
        {
            if (conexionObj == null)
            {
                conexionObj = new Conexion();
                return conexionObj;
            }
            else
            {

                return conexionObj;
            }

        }

        //Metodo que Crea la conexion a la base de datos
        public SqlConnection crearConexion()
        {

            sqlConexion = new SqlConnection("server=" + serverID + ";database=" + dataBase + ";user id=" + usuario +
                                        ";password=" + password);

            //";integrated security =" + Security
            return sqlConexion;
        }

        //Metodo que se conecta con la base de datos
        public void conectar()
        {

            sqlConexion.Open();
          // MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

        }
        //Metodo que se desconecta con la base de datos
        public void desconectar()
        {
            sqlConexion.Close();
            //MessageBox.Show("Se cerró la conexión.");
        }
    }
}
