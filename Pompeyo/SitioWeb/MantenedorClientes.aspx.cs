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
    public partial class MantenedorClientes : System.Web.UI.Page
    {

        private PompeyoWCFServiceReference.IPompeyoWCFService service =
            new PompeyoWCFServiceReference.PompeyoWCFServiceClient();
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

                    listarClientes();
                    listarGiros();
                }
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteDTO entidad = service.crearCliente(txtRut.Text, 
                    txtNombre.Text, txtDireccion.Text, cbGiro.SelectedValue);

                if (entidad != null)
                {

                    listarClientes();
                    listarGiros();
                    txtRut.Text = "";
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                }

            }
            catch (Exception e1)
            {

                lblMsg.Text = e1.Message;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            listaClientes = service.listarClientesDTO();
            ClienteDTO entidad = service.buscarCliente(((ClienteDTO)listaClientes[e.RowIndex]).id);
            try
            {

                bool resultado = service.eliminarCliente(entidad);
                listarClientes();
                listarGiros();
                txtRut.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";

            }
            catch (Exception e1)
            {

                lblMsg.Text = e1.Message;
            }
        }

        void listarGiros()
        {
            cbGiro.DataSource = Utils.giros();
            cbGiro.DataBind();

        }

        void listarClientes()
        {
            listaClientes = service.listarClientesDTO();
            GridView1.DataSource = Utils.ToDataTable<ClienteDTO>(listaClientes);
            GridView1.DataBind();

        }
    }
}