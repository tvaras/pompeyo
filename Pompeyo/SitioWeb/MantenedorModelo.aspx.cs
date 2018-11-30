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
    public partial class MantenedorModelo : System.Web.UI.Page
    {

        private PompeyoWCFServiceReference.IPompeyoWCFService service =
            new PompeyoWCFServiceReference.PompeyoWCFServiceClient();
        private List<ModeloDTO> listaModelos = new List<ModeloDTO>();
        private List<SimpleDTO> listaMarcas = new List<SimpleDTO>();

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

                    listarMarcas();
                    listarModelos();
                }
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                ModeloDTO entidad = service.crearModelo(int.Parse(cbMarcas.SelectedValue), 
                    txtModelo.Text, int.Parse(txtValor.Text));

                if (entidad != null)
                {

                    listarModelos();
                    txtModelo.Text = "";
                }

            }
            catch (Exception e1)
            {

                lblMsg.Text = e1.Message;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            listaModelos = service.listarModelosDTO();
            ModeloDTO dto = service.buscarModelo(((ModeloDTO) listaModelos[e.RowIndex]).idModelo);
            try
            {

                bool resultado = service.eliminarModelo(dto);
                listarModelos();
                txtModelo.Text = "";

            }
            catch (Exception e1)
            {

                lblMsg.Text = e1.Message;
            }
        }

        void listarMarcas()
        {
            listaMarcas = service.listarMarcas();
            cbMarcas.DataValueField = "id";
            cbMarcas.DataTextField = "descripcion";
            cbMarcas.DataSource = Utils.ToDataTable<SimpleDTO>(listaMarcas);
            cbMarcas.DataBind();

        }

        void listarModelos()
        {
            listaModelos = service.listarModelosDTO();
            GridView1.DataSource = Utils.ToDataTable<ModeloDTO>(listaModelos);
            GridView1.DataBind();

        }
    }
}