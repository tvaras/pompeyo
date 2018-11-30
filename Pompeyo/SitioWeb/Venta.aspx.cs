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
    public partial class Venta : System.Web.UI.Page
    {

        private PompeyoWCFServiceReference.IPompeyoWCFService service =
            new PompeyoWCFServiceReference.PompeyoWCFServiceClient();
        private List<VentaDTO> listaVentas = new List<VentaDTO>();
        private List<ModeloDTO> listaModelos = new List<ModeloDTO>();
        private List<ClienteDTO> listaClientes = new List<ClienteDTO>();

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

                    listarModelos();
                    listarClientes();
                    listarVentas();
                }
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = ((UsuarioDTO)Session["CURRENT_USER"]).idUsuario;
                int idModelo = int.Parse(cbModelo.SelectedValue);
                ModeloDTO mod = service.buscarModelo(idModelo);
                Entidades.VentaDTO entidad = service.crearVenta(
                    idModelo,
                    int.Parse(cbCliente.SelectedValue),
                    mod.valor, 
                    idUsuario);

                if (entidad != null)
                {

                    listarVentas();
                }

            }
            catch (Exception e1)
            {

                lblMsg.Text = e1.Message;
            }
        }

        void listarModelos()
        {
            listaModelos = service.listarModelosDTOCombo();
            cbModelo.DataValueField = "idModelo";
            cbModelo.DataTextField = "modelo";
            cbModelo.DataSource = Utils.ToDataTable<ModeloDTO>(listaModelos);
            cbModelo.DataBind();

        }

        void listarClientes()
        {
            listaClientes = service.listarClientesDTOCombo();
            cbCliente.DataValueField = "id";
            cbCliente.DataTextField = "nombre";
            cbCliente.DataSource = Utils.ToDataTable<ClienteDTO>(listaClientes);
            cbCliente.DataBind();

        }

        void listarVentas()
        {
            listaVentas = service.listarVentasDTO();
            GridView1.DataSource = Utils.ToDataTable<VentaDTO>(listaVentas);
            GridView1.DataBind();

        }
    }
}