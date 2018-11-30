using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PompeyoService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPompeyoWCFService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPompeyoWCFService
    {
        #region "Entidad Marca"
        [OperationContract]
        SimpleDTO crearMarca(string descripcion);

        [OperationContract]
        List<SimpleDTO> listarMarcas();

        [OperationContract]
        bool eliminarMarca(SimpleDTO marca);
        #endregion

        #region "Entidad Modelo"
        [OperationContract]
        ModeloDTO crearModelo(int idMarca, string descripcion, int valor);

        [OperationContract]
        List<ModeloDTO> listarModelos();

        [OperationContract]
        ModeloDTO buscarModelo(int id);

        [OperationContract]
        List<ModeloDTO> listarModelosDTO();

        [OperationContract]
        List<ModeloDTO> listarModelosDTOCombo();

        [OperationContract]
        bool eliminarModelo(ModeloDTO dto);
        #endregion

        #region "Entidad Cliente"
        [OperationContract]
        ClienteDTO crearCliente(string rut, string nombre, string direccion, string giro);

        [OperationContract]
        List<ClienteDTO> listarClientes();

        [OperationContract]
        ClienteDTO buscarCliente(int id);

        [OperationContract]
        List<ClienteDTO> listarClientesDTO();

        [OperationContract]
        List<ClienteDTO> listarClientesDTOCombo();

        [OperationContract]
        bool eliminarCliente(ClienteDTO dto);
        #endregion

        #region "Entidad Usuario"
        [OperationContract]
        UsuarioDTO login(string username, string pass);
        #endregion

        #region "Entidad Venta"
        [OperationContract]
        VentaDTO crearVenta(int idModelo, int idCliente, int monto, int idUsuario);

        [OperationContract]
        List<VentaDTO> listarVentas();

        [OperationContract]
        VentaDTO buscarVenta(int id);

        [OperationContract]
        List<VentaDTO> listarVentasDTO();

        [OperationContract]
        bool eliminarVenta(VentaDTO dto);
        #endregion
    }
}
