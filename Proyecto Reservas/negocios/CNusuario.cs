using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace negocios
{
    public class CNusuario
    {
        CDusuario CDusuario = new CDusuario();

        public bool AccesoAlSistema(string usuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return false;
            }

            return CDusuario.ValidarLogin(usuario, contrasena);
        }
    }
}
