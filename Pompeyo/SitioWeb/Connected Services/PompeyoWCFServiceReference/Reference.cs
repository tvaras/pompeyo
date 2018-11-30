﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioWeb.PompeyoWCFServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PompeyoWCFServiceReference.IPompeyoWCFService")]
    public interface IPompeyoWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearMarca", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearMarcaResponse")]
        Entidades.SimpleDTO crearMarca(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearMarca", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearMarcaResponse")]
        System.Threading.Tasks.Task<Entidades.SimpleDTO> crearMarcaAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarMarcas", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarMarcasResponse")]
        System.Collections.Generic.List<Entidades.SimpleDTO> listarMarcas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarMarcas", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarMarcasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SimpleDTO>> listarMarcasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarMarca", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarMarcaResponse")]
        bool eliminarMarca(Entidades.SimpleDTO marca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarMarca", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarMarcaResponse")]
        System.Threading.Tasks.Task<bool> eliminarMarcaAsync(Entidades.SimpleDTO marca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearModelo", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearModeloResponse")]
        Entidades.ModeloDTO crearModelo(int idMarca, string descripcion, int valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearModelo", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearModeloResponse")]
        System.Threading.Tasks.Task<Entidades.ModeloDTO> crearModeloAsync(int idMarca, string descripcion, int valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarModelos", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarModelosResponse")]
        System.Collections.Generic.List<Entidades.ModeloDTO> listarModelos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarModelos", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarModelosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ModeloDTO>> listarModelosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/buscarModelo", ReplyAction="http://tempuri.org/IPompeyoWCFService/buscarModeloResponse")]
        Entidades.ModeloDTO buscarModelo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/buscarModelo", ReplyAction="http://tempuri.org/IPompeyoWCFService/buscarModeloResponse")]
        System.Threading.Tasks.Task<Entidades.ModeloDTO> buscarModeloAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarModelosDTO", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarModelosDTOResponse")]
        System.Collections.Generic.List<Entidades.ModeloDTO> listarModelosDTO();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarModelosDTO", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarModelosDTOResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ModeloDTO>> listarModelosDTOAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarModelosDTOCombo", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarModelosDTOComboResponse")]
        System.Collections.Generic.List<Entidades.ModeloDTO> listarModelosDTOCombo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarModelosDTOCombo", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarModelosDTOComboResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ModeloDTO>> listarModelosDTOComboAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarModelo", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarModeloResponse")]
        bool eliminarModelo(Entidades.ModeloDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarModelo", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarModeloResponse")]
        System.Threading.Tasks.Task<bool> eliminarModeloAsync(Entidades.ModeloDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearCliente", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearClienteResponse")]
        Entidades.ClienteDTO crearCliente(string rut, string nombre, string direccion, string giro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearCliente", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearClienteResponse")]
        System.Threading.Tasks.Task<Entidades.ClienteDTO> crearClienteAsync(string rut, string nombre, string direccion, string giro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarClientes", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarClientesResponse")]
        System.Collections.Generic.List<Entidades.ClienteDTO> listarClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarClientes", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarClientesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClienteDTO>> listarClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/buscarCliente", ReplyAction="http://tempuri.org/IPompeyoWCFService/buscarClienteResponse")]
        Entidades.ClienteDTO buscarCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/buscarCliente", ReplyAction="http://tempuri.org/IPompeyoWCFService/buscarClienteResponse")]
        System.Threading.Tasks.Task<Entidades.ClienteDTO> buscarClienteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarClientesDTO", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarClientesDTOResponse")]
        System.Collections.Generic.List<Entidades.ClienteDTO> listarClientesDTO();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarClientesDTO", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarClientesDTOResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClienteDTO>> listarClientesDTOAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarClientesDTOCombo", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarClientesDTOComboResponse")]
        System.Collections.Generic.List<Entidades.ClienteDTO> listarClientesDTOCombo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarClientesDTOCombo", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarClientesDTOComboResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClienteDTO>> listarClientesDTOComboAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarCliente", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarClienteResponse")]
        bool eliminarCliente(Entidades.ClienteDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarCliente", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarClienteResponse")]
        System.Threading.Tasks.Task<bool> eliminarClienteAsync(Entidades.ClienteDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/login", ReplyAction="http://tempuri.org/IPompeyoWCFService/loginResponse")]
        Entidades.UsuarioDTO login(string username, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/login", ReplyAction="http://tempuri.org/IPompeyoWCFService/loginResponse")]
        System.Threading.Tasks.Task<Entidades.UsuarioDTO> loginAsync(string username, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearVenta", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearVentaResponse")]
        Entidades.VentaDTO crearVenta(int idModelo, int idCliente, int monto, int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/crearVenta", ReplyAction="http://tempuri.org/IPompeyoWCFService/crearVentaResponse")]
        System.Threading.Tasks.Task<Entidades.VentaDTO> crearVentaAsync(int idModelo, int idCliente, int monto, int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarVentas", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarVentasResponse")]
        System.Collections.Generic.List<Entidades.VentaDTO> listarVentas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarVentas", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarVentasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.VentaDTO>> listarVentasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/buscarVenta", ReplyAction="http://tempuri.org/IPompeyoWCFService/buscarVentaResponse")]
        Entidades.VentaDTO buscarVenta(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/buscarVenta", ReplyAction="http://tempuri.org/IPompeyoWCFService/buscarVentaResponse")]
        System.Threading.Tasks.Task<Entidades.VentaDTO> buscarVentaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarVentasDTO", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarVentasDTOResponse")]
        System.Collections.Generic.List<Entidades.VentaDTO> listarVentasDTO();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/listarVentasDTO", ReplyAction="http://tempuri.org/IPompeyoWCFService/listarVentasDTOResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.VentaDTO>> listarVentasDTOAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarVenta", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarVentaResponse")]
        bool eliminarVenta(Entidades.VentaDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPompeyoWCFService/eliminarVenta", ReplyAction="http://tempuri.org/IPompeyoWCFService/eliminarVentaResponse")]
        System.Threading.Tasks.Task<bool> eliminarVentaAsync(Entidades.VentaDTO dto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPompeyoWCFServiceChannel : SitioWeb.PompeyoWCFServiceReference.IPompeyoWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PompeyoWCFServiceClient : System.ServiceModel.ClientBase<SitioWeb.PompeyoWCFServiceReference.IPompeyoWCFService>, SitioWeb.PompeyoWCFServiceReference.IPompeyoWCFService {
        
        public PompeyoWCFServiceClient() {
        }
        
        public PompeyoWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PompeyoWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PompeyoWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PompeyoWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Entidades.SimpleDTO crearMarca(string descripcion) {
            return base.Channel.crearMarca(descripcion);
        }
        
        public System.Threading.Tasks.Task<Entidades.SimpleDTO> crearMarcaAsync(string descripcion) {
            return base.Channel.crearMarcaAsync(descripcion);
        }
        
        public System.Collections.Generic.List<Entidades.SimpleDTO> listarMarcas() {
            return base.Channel.listarMarcas();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SimpleDTO>> listarMarcasAsync() {
            return base.Channel.listarMarcasAsync();
        }
        
        public bool eliminarMarca(Entidades.SimpleDTO marca) {
            return base.Channel.eliminarMarca(marca);
        }
        
        public System.Threading.Tasks.Task<bool> eliminarMarcaAsync(Entidades.SimpleDTO marca) {
            return base.Channel.eliminarMarcaAsync(marca);
        }
        
        public Entidades.ModeloDTO crearModelo(int idMarca, string descripcion, int valor) {
            return base.Channel.crearModelo(idMarca, descripcion, valor);
        }
        
        public System.Threading.Tasks.Task<Entidades.ModeloDTO> crearModeloAsync(int idMarca, string descripcion, int valor) {
            return base.Channel.crearModeloAsync(idMarca, descripcion, valor);
        }
        
        public System.Collections.Generic.List<Entidades.ModeloDTO> listarModelos() {
            return base.Channel.listarModelos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ModeloDTO>> listarModelosAsync() {
            return base.Channel.listarModelosAsync();
        }
        
        public Entidades.ModeloDTO buscarModelo(int id) {
            return base.Channel.buscarModelo(id);
        }
        
        public System.Threading.Tasks.Task<Entidades.ModeloDTO> buscarModeloAsync(int id) {
            return base.Channel.buscarModeloAsync(id);
        }
        
        public System.Collections.Generic.List<Entidades.ModeloDTO> listarModelosDTO() {
            return base.Channel.listarModelosDTO();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ModeloDTO>> listarModelosDTOAsync() {
            return base.Channel.listarModelosDTOAsync();
        }
        
        public System.Collections.Generic.List<Entidades.ModeloDTO> listarModelosDTOCombo() {
            return base.Channel.listarModelosDTOCombo();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ModeloDTO>> listarModelosDTOComboAsync() {
            return base.Channel.listarModelosDTOComboAsync();
        }
        
        public bool eliminarModelo(Entidades.ModeloDTO dto) {
            return base.Channel.eliminarModelo(dto);
        }
        
        public System.Threading.Tasks.Task<bool> eliminarModeloAsync(Entidades.ModeloDTO dto) {
            return base.Channel.eliminarModeloAsync(dto);
        }
        
        public Entidades.ClienteDTO crearCliente(string rut, string nombre, string direccion, string giro) {
            return base.Channel.crearCliente(rut, nombre, direccion, giro);
        }
        
        public System.Threading.Tasks.Task<Entidades.ClienteDTO> crearClienteAsync(string rut, string nombre, string direccion, string giro) {
            return base.Channel.crearClienteAsync(rut, nombre, direccion, giro);
        }
        
        public System.Collections.Generic.List<Entidades.ClienteDTO> listarClientes() {
            return base.Channel.listarClientes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClienteDTO>> listarClientesAsync() {
            return base.Channel.listarClientesAsync();
        }
        
        public Entidades.ClienteDTO buscarCliente(int id) {
            return base.Channel.buscarCliente(id);
        }
        
        public System.Threading.Tasks.Task<Entidades.ClienteDTO> buscarClienteAsync(int id) {
            return base.Channel.buscarClienteAsync(id);
        }
        
        public System.Collections.Generic.List<Entidades.ClienteDTO> listarClientesDTO() {
            return base.Channel.listarClientesDTO();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClienteDTO>> listarClientesDTOAsync() {
            return base.Channel.listarClientesDTOAsync();
        }
        
        public System.Collections.Generic.List<Entidades.ClienteDTO> listarClientesDTOCombo() {
            return base.Channel.listarClientesDTOCombo();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClienteDTO>> listarClientesDTOComboAsync() {
            return base.Channel.listarClientesDTOComboAsync();
        }
        
        public bool eliminarCliente(Entidades.ClienteDTO dto) {
            return base.Channel.eliminarCliente(dto);
        }
        
        public System.Threading.Tasks.Task<bool> eliminarClienteAsync(Entidades.ClienteDTO dto) {
            return base.Channel.eliminarClienteAsync(dto);
        }
        
        public Entidades.UsuarioDTO login(string username, string pass) {
            return base.Channel.login(username, pass);
        }
        
        public System.Threading.Tasks.Task<Entidades.UsuarioDTO> loginAsync(string username, string pass) {
            return base.Channel.loginAsync(username, pass);
        }
        
        public Entidades.VentaDTO crearVenta(int idModelo, int idCliente, int monto, int idUsuario) {
            return base.Channel.crearVenta(idModelo, idCliente, monto, idUsuario);
        }
        
        public System.Threading.Tasks.Task<Entidades.VentaDTO> crearVentaAsync(int idModelo, int idCliente, int monto, int idUsuario) {
            return base.Channel.crearVentaAsync(idModelo, idCliente, monto, idUsuario);
        }
        
        public System.Collections.Generic.List<Entidades.VentaDTO> listarVentas() {
            return base.Channel.listarVentas();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.VentaDTO>> listarVentasAsync() {
            return base.Channel.listarVentasAsync();
        }
        
        public Entidades.VentaDTO buscarVenta(int id) {
            return base.Channel.buscarVenta(id);
        }
        
        public System.Threading.Tasks.Task<Entidades.VentaDTO> buscarVentaAsync(int id) {
            return base.Channel.buscarVentaAsync(id);
        }
        
        public System.Collections.Generic.List<Entidades.VentaDTO> listarVentasDTO() {
            return base.Channel.listarVentasDTO();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.VentaDTO>> listarVentasDTOAsync() {
            return base.Channel.listarVentasDTOAsync();
        }
        
        public bool eliminarVenta(Entidades.VentaDTO dto) {
            return base.Channel.eliminarVenta(dto);
        }
        
        public System.Threading.Tasks.Task<bool> eliminarVentaAsync(Entidades.VentaDTO dto) {
            return base.Channel.eliminarVentaAsync(dto);
        }
    }
}