using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace SitioWeb
{
    public partial class Informe : System.Web.UI.Page
    {

        private PompeyoWCFServiceReference.IPompeyoWCFService service =
            new PompeyoWCFServiceReference.PompeyoWCFServiceClient();
        private List<VentaDTO> listaVentas = new List<VentaDTO>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["CURRENT_USER"] == null)
                {

                    Response.Redirect("~/login");
                }
                else
                {
                    listarVentas();
                }
            }
        }

        void listarVentas()
        {
            listaVentas = service.listarVentasDTO();
            GridView1.DataSource = Utils.ToDataTable<VentaDTO>(listaVentas);
            GridView1.DataBind();
        }
    }
}