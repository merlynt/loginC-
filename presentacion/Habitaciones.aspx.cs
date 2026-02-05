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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string descripcion = txtDescripcion.Text;
            int cant_huespedes = Convert.ToInt32(txtCantHuespedes.Text);
            bool agregado = CNHabitaciones.AgregarHabitacion(numero, descripcion, cant_huespedes);
            if(agregado)
            {
                Response.Write("<script>alert('Habitación agregada correctamente.');</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al agregar la habitación.');</script>");
            }
        }


    }
}