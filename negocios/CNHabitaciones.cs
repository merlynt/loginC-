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
    }
}
