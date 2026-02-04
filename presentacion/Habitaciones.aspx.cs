using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocios;

namespace presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CNHabitaciones CNHabitaciones = new CNHabitaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
            

        }

        protected void CargarGrid()
        {
            dvgHabitaciones.DataSource = CNHabitaciones.ObtenerHabitaciones();
            dvgHabitaciones.DataBind();
        }



    }
}