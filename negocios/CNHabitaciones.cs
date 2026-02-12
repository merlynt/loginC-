using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace negocios
{
    public class CNHabitaciones
    {
        CDHabitaciones CDHabitaciones = new CDHabitaciones();

        public DataTable ObtenerHabitaciones()
        {
            return CDHabitaciones.ObtenerHabitaciones();
        }

        public bool AgregarHabitacion(int numero, string descripcion, int cant_huespedes)
        {
            return CDHabitaciones.AgregarHabitacion(numero, descripcion, cant_huespedes);
        }

        public bool ModificarHabitacion(int id, int numero, string descripcion, int cant_huespedes)
        {
            return CDHabitaciones.ModificarHabitacion(id, numero, descripcion, cant_huespedes);
        }

        public bool EliminarHabitacion(int id)
        {
            return CDHabitaciones.EliminarHabitacion(id);
        }
    }
}
