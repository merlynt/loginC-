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
                Response.Write("<scr ipt>alert('Habitación agregada correctamente.');</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al agregar la habitación.');</script>");
            }
        }

        protected void dvgHabitaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(dvgHabitaciones.DataKeys[e.RowIndex].Value);
            if(CNHabitaciones.EliminarHabitacion(id))
            {
                Response.Write("<script>alert('Habitación eliminada correctamente.');</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al eliminar la habitación.');</script>");
            }
        }

        protected void dvgHabitaciones_RowEditing(object sender, GridViewEditEventArgs e)
        {

            dvgHabitaciones.EditIndex = e.NewEditIndex;
            CargarGrid();
        }

       
        

        protected void dvgHabitaciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dvgHabitaciones.EditIndex = -1;
            CargarGrid();

        }

        protected void dvgHabitaciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(dvgHabitaciones.DataKeys[e.RowIndex].Value);
            GridViewRow row = dvgHabitaciones.Rows[e.RowIndex];
            int numero = int.Parse((row.Cells[1].Controls[0] as System.Web.UI.WebControls.TextBox).Text);
            string descripcion = (row.Cells[2].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
            int cant_huespedes = int.Parse((row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text);
            if (CNHabitaciones.ModificarHabitacion(id, numero, descripcion, cant_huespedes))
            {
                dvgHabitaciones.EditIndex = -1;
                CargarGrid();
                Response.Write("<script>alert('Habitación editada correctamente.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al editar la habitación.');</script>");
            }
        }
    }
}