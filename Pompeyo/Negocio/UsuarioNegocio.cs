using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public UsuarioDTO login(string username, string pass)
        {
            if (username == null || username != null && username.Trim() == "") {
                throw new Exception(Constantes.LOGIN_REQUIRIDO);
            }

            if (pass == null || pass != null && pass.Trim() == "")
            {
                throw new Exception(Constantes.LOGIN_REQUIRIDO);
            }

            return usuarioDAL.login(username, pass);
        }
    }
}
