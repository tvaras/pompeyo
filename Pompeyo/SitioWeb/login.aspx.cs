using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace SitioWeb
{
    public partial class login : System.Web.UI.Page
    {
        private PompeyoWCFServiceReference.IPompeyoWCFService service = 
            new PompeyoWCFServiceReference.PompeyoWCFServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            if (Request.Params.Get("msg") != null) {

                if (Request.Params.Get("msg").Equals("401")) {
                    lblMsg.Text = Constantes.ERROR_CREDENCIALES;
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                } else if (Request.Params.Get("msg").Equals("412")) {
                    lblMsg.Text = Constantes.LOGIN_REQUIRIDO;
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                } else if (Request.Params.Get("msg").Equals("200")) {
                    lblMsg.Text = Constantes.SESSION_FINALIZADA;
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string path = "";
            try {

                UsuarioDTO user = service.login(txtUser.Text, txtPass.Text);

                if (user != null) {

                    Session["CURRENT_USER"] = user;
                    path = "~/Home";

                } else {

                    path = "~/login?msg=401";
                }
            }
            catch (Exception e1) {
                path = "~/login?msg=412";
            }

            Response.Redirect(path);
        }
    }
}