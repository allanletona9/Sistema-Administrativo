using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_2019
{
    class conexion
    {
        public static OdbcConnection conectar()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=colchoneria");
            conexion.Open();
            return conexion;
        }

        public static OdbcConnection cerrarConexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=colchoneria");
            conexion.Close();
            return conexion;
        }
    }
}
