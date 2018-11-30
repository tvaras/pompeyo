﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace SitioWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                if (Session["CURRENT_USER"] != null) {
                    lblNombre.Text = ((UsuarioDTO)Session["CURRENT_USER"]).nombre;
                }
                else {
                    Response.Redirect("~/login");
                }
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login");
        }
    }
}