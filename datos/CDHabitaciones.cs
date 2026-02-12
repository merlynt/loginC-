using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class CDHabitaciones
    {
        public DataTable ObtenerHabitaciones()
        {

            DataTable dt = new DataTable();
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM habitaciones", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
            return dt;
        }

        public bool AgregarHabitacion(int numero, string descripcion, int cant_huespedes)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO habitaciones (numero, descripcion, cant_huespedes) VALUES (@numero, @descripcion, @cant_huespedes)", con))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@cant_huespedes", cant_huespedes);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filasAfectadas > 0;
                }

            }
        }

        public bool ModificarHabitacion(int id, int numero, string descripcion, int cant_huespedes)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE habitaciones SET numero = @numero, descripcion = @descripcion, cant_huespedes = @cant_huespedes WHERE id_habitaciones = @id_habitaciones", con))
                {
                    cmd.Parameters.AddWithValue("@id_habitaciones", id);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@cant_huespedes", cant_huespedes);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool EliminarHabitacion(int id)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM habitaciones WHERE id_habitaciones = @id_habitaciones", con))
                {
                    cmd.Parameters.AddWithValue("@id_habitaciones", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    con.Close();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
