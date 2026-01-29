using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocios;

namespace presentacion
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            CNusuario CNusuario = new CNusuario();

            if (CNusuario.AccesoAlSistema(usuarioTextBox.Text, contrasenaTextBox.Text))
            {
                Session["usuario"] = usuarioTextBox.Text;
                Response.Redirect("PanelPrincipal.aspx");
            }
            else
            {
                lblMensaje.Text = "Usuario o clave incorrecta";
            }
        }
    }
}