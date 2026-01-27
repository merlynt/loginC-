using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class CDusuario
    {

        

        public bool ValidarLogin(string user, string pass)
        {
            try
            {
                bool existe = false;
                using (SqlConnection conn = Conexion.obtenerConexion())
                {

                    string query = "SELECT COUNT(*) FROM usuario WHERE nombre=@u AND contrasena=@c";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@c", pass);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        existe = true;
                    }
                }
                return existe;
            }
            catch (Exception)
            {
                return false; 
            }
        }
    }
}
