using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace SitioWeb
{
    public partial class MantenedorMarcas : System.Web.UI.Page
    {

        private PompeyoWCFServiceReference.IPompeyoWCFService service =
            new PompeyoWCFServiceReference.PompeyoWCFServiceClient();
        private List<SimpleDTO> lista = new List<SimpleDTO>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["CURRENT_USER"] == null) {

                    Response.Redirect("~/login");
                } else {

                    listar();
                }
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try {

                SimpleDTO entidad = service.crearMarca(txtMarca.Text);

                if (entidad != null) {

                    listar();
                    txtMarca.Text = "";
                }

            } catch(Exception e1) {

                lblMsg.Text = e1.Message;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            lista = service.listarMarcas();
            SimpleDTO dto = lista[e.RowIndex];
            try {

                bool resultado = service.eliminarMarca(dto);
                listar();
                txtMarca.Text = "";

            }
            catch (Exception e1) {

                lblMsg.Text = e1.Message;
            }
        }

        void listar()
        {
            lista = service.listarMarcas();
            GridView1.DataSource = Utils.ToDataTable<SimpleDTO>(lista);
            GridView1.DataBind();

        }
    }
}