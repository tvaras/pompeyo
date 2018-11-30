using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PompeyoService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PompeyoWCFService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PompeyoWCFService.svc o PompeyoWCFService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PompeyoWCFService : IPompeyoWCFService
    {

        private MarcaNegocio marcaNeg = new MarcaNegocio();
        private ModeloNegocio modeloNeg = new ModeloNegocio();
        private ClienteNegocio clienteNeg = new ClienteNegocio();
        private UsuarioNegocio usuarioNeg = new UsuarioNegocio();
        private VentaNegocio ventaNeg = new VentaNegocio();

        public SimpleDTO crearMarca(string descripcion)
        {
            return marcaNeg.crear(descripcion);
        }

        public List<SimpleDTO> listarMarcas() {

            return marcaNeg.listar();
        }

        public bool eliminarMarca(SimpleDTO marca)
        {

            return marcaNeg.eliminar(marca);
        }

        public ModeloDTO crearModelo(int idMarca, string descripcion, int valor)
        {
            return modeloNeg.crear(idMarca, descripcion, valor);
        }

        public List<ModeloDTO> listarModelos()
        {
            return modeloNeg.listar();
        }

        public ModeloDTO buscarModelo(int id)
        {
            return modeloNeg.buscar(id);
        }

        public List<ModeloDTO> listarModelosDTO()
        {
            return modeloNeg.listarDTO();
        }

        public List<ModeloDTO> listarModelosDTOCombo()
        {
            return modeloNeg.listarDTOCombo();
        }

        public bool eliminarModelo(ModeloDTO dto)
        {
            return modeloNeg.eliminar(dto);
        }

        public ClienteDTO crearCliente(string rut, string nombre, string direccion, string giro)
        {
            return clienteNeg.crear(rut, nombre, direccion, giro);
        }

        public List<ClienteDTO> listarClientes()
        {
            return clienteNeg.listar();
        }

        public ClienteDTO buscarCliente(int id)
        {
            return clienteNeg.buscar(id);
        }

        public List<ClienteDTO> listarClientesDTO()
        {
            return clienteNeg.listarDTO();
        }

        public List<ClienteDTO> listarClientesDTOCombo()
        {
            return clienteNeg.listarDTOCombo();
        }

        public bool eliminarCliente(ClienteDTO dto)
        {
            return clienteNeg.eliminar(dto);
        }

        public UsuarioDTO login(string username, string pass)
        {
            return usuarioNeg.login(username, pass);
        }

        public VentaDTO crearVenta(int idModelo, int idCliente, int monto, int idUsuario)
        {
            return ventaNeg.crear(idModelo, idCliente, monto, idUsuario);
        }

        public List<VentaDTO> listarVentas()
        {
            return ventaNeg.listar();
        }

        public VentaDTO buscarVenta(int id)
        {
            return ventaNeg.buscar(id);
        }

        public List<VentaDTO> listarVentasDTO()
        {
            return ventaNeg.listarDTO();
        }

        public bool eliminarVenta(VentaDTO dto)
        {
            return ventaNeg.eliminar(dto);
        }
    }
}
