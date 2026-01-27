using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Conexion
    {
        private static string cadena = "Data Source=MERLYNRAJO;Initial Catalog=hotel;Integrated Security=True;Encrypt=False;";

        public static SqlConnection obtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
