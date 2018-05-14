﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaWSPresentacion.WSSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/CapaServicio")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSSoap.IWSSHostel")]
    public interface IWSSHostel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ValidarLogin", ReplyAction="http://tempuri.org/IWSSHostel/ValidarLoginResponse")]
        CapaObjeto.Sesion ValidarLogin(string usuario, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ValidarLogin", ReplyAction="http://tempuri.org/IWSSHostel/ValidarLoginResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Sesion> ValidarLoginAsync(string usuario, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/CrearCliente", ReplyAction="http://tempuri.org/IWSSHostel/CrearClienteResponse")]
        CapaObjeto.PerfilCliente CrearCliente(CapaObjeto.PerfilCliente entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/CrearCliente", ReplyAction="http://tempuri.org/IWSSHostel/CrearClienteResponse")]
        System.Threading.Tasks.Task<CapaObjeto.PerfilCliente> CrearClienteAsync(CapaObjeto.PerfilCliente entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoCrear", ReplyAction="http://tempuri.org/IWSSHostel/ProductoCrearResponse")]
        CapaObjeto.Producto ProductoCrear(CapaObjeto.Producto entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoCrear", ReplyAction="http://tempuri.org/IWSSHostel/ProductoCrearResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Producto> ProductoCrearAsync(CapaObjeto.Producto entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoActualizar", ReplyAction="http://tempuri.org/IWSSHostel/ProductoActualizarResponse")]
        CapaObjeto.Producto ProductoActualizar(CapaObjeto.Producto entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoActualizar", ReplyAction="http://tempuri.org/IWSSHostel/ProductoActualizarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Producto> ProductoActualizarAsync(CapaObjeto.Producto entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoEliminar", ReplyAction="http://tempuri.org/IWSSHostel/ProductoEliminarResponse")]
        CapaObjeto.Producto ProductoEliminar(CapaObjeto.Producto entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoEliminar", ReplyAction="http://tempuri.org/IWSSHostel/ProductoEliminarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Producto> ProductoEliminarAsync(CapaObjeto.Producto entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoRescatar", ReplyAction="http://tempuri.org/IWSSHostel/ProductoRescatarResponse")]
        CapaObjeto.ListaProductos ProductoRescatar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ProductoRescatar", ReplyAction="http://tempuri.org/IWSSHostel/ProductoRescatarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.ListaProductos> ProductoRescatarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ServicioComidaRescatar", ReplyAction="http://tempuri.org/IWSSHostel/ServicioComidaRescatarResponse")]
        CapaObjeto.ListaServicioComida ServicioComidaRescatar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/ServicioComidaRescatar", ReplyAction="http://tempuri.org/IWSSHostel/ServicioComidaRescatarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.ListaServicioComida> ServicioComidaRescatarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoCrear", ReplyAction="http://tempuri.org/IWSSHostel/PlatoCrearResponse")]
        CapaObjeto.Plato PlatoCrear(CapaObjeto.Plato entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoCrear", ReplyAction="http://tempuri.org/IWSSHostel/PlatoCrearResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Plato> PlatoCrearAsync(CapaObjeto.Plato entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoActualizar", ReplyAction="http://tempuri.org/IWSSHostel/PlatoActualizarResponse")]
        CapaObjeto.Plato PlatoActualizar(CapaObjeto.Plato entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoActualizar", ReplyAction="http://tempuri.org/IWSSHostel/PlatoActualizarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Plato> PlatoActualizarAsync(CapaObjeto.Plato entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoEliminar", ReplyAction="http://tempuri.org/IWSSHostel/PlatoEliminarResponse")]
        CapaObjeto.Plato PlatoEliminar(CapaObjeto.Plato entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoEliminar", ReplyAction="http://tempuri.org/IWSSHostel/PlatoEliminarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.Plato> PlatoEliminarAsync(CapaObjeto.Plato entrada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoRescatar", ReplyAction="http://tempuri.org/IWSSHostel/PlatoRescatarResponse")]
        CapaObjeto.ListaPlatos PlatoRescatar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/PlatoRescatar", ReplyAction="http://tempuri.org/IWSSHostel/PlatoRescatarResponse")]
        System.Threading.Tasks.Task<CapaObjeto.ListaPlatos> PlatoRescatarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IWSSHostel/GetDataUsingDataContractResponse")]
        CapaWSPresentacion.WSSoap.CompositeType GetDataUsingDataContract(CapaWSPresentacion.WSSoap.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSSHostel/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IWSSHostel/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<CapaWSPresentacion.WSSoap.CompositeType> GetDataUsingDataContractAsync(CapaWSPresentacion.WSSoap.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSSHostelChannel : CapaWSPresentacion.WSSoap.IWSSHostel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSSHostelClient : System.ServiceModel.ClientBase<CapaWSPresentacion.WSSoap.IWSSHostel>, CapaWSPresentacion.WSSoap.IWSSHostel {
        
        public WSSHostelClient() {
        }
        
        public WSSHostelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSSHostelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSHostelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSHostelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CapaObjeto.Sesion ValidarLogin(string usuario, string clave) {
            return base.Channel.ValidarLogin(usuario, clave);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Sesion> ValidarLoginAsync(string usuario, string clave) {
            return base.Channel.ValidarLoginAsync(usuario, clave);
        }
        
        public CapaObjeto.PerfilCliente CrearCliente(CapaObjeto.PerfilCliente entrada) {
            return base.Channel.CrearCliente(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.PerfilCliente> CrearClienteAsync(CapaObjeto.PerfilCliente entrada) {
            return base.Channel.CrearClienteAsync(entrada);
        }
        
        public CapaObjeto.Producto ProductoCrear(CapaObjeto.Producto entrada) {
            return base.Channel.ProductoCrear(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Producto> ProductoCrearAsync(CapaObjeto.Producto entrada) {
            return base.Channel.ProductoCrearAsync(entrada);
        }
        
        public CapaObjeto.Producto ProductoActualizar(CapaObjeto.Producto entrada) {
            return base.Channel.ProductoActualizar(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Producto> ProductoActualizarAsync(CapaObjeto.Producto entrada) {
            return base.Channel.ProductoActualizarAsync(entrada);
        }
        
        public CapaObjeto.Producto ProductoEliminar(CapaObjeto.Producto entrada) {
            return base.Channel.ProductoEliminar(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Producto> ProductoEliminarAsync(CapaObjeto.Producto entrada) {
            return base.Channel.ProductoEliminarAsync(entrada);
        }
        
        public CapaObjeto.ListaProductos ProductoRescatar() {
            return base.Channel.ProductoRescatar();
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.ListaProductos> ProductoRescatarAsync() {
            return base.Channel.ProductoRescatarAsync();
        }
        
        public CapaObjeto.ListaServicioComida ServicioComidaRescatar() {
            return base.Channel.ServicioComidaRescatar();
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.ListaServicioComida> ServicioComidaRescatarAsync() {
            return base.Channel.ServicioComidaRescatarAsync();
        }
        
        public CapaObjeto.Plato PlatoCrear(CapaObjeto.Plato entrada) {
            return base.Channel.PlatoCrear(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Plato> PlatoCrearAsync(CapaObjeto.Plato entrada) {
            return base.Channel.PlatoCrearAsync(entrada);
        }
        
        public CapaObjeto.Plato PlatoActualizar(CapaObjeto.Plato entrada) {
            return base.Channel.PlatoActualizar(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Plato> PlatoActualizarAsync(CapaObjeto.Plato entrada) {
            return base.Channel.PlatoActualizarAsync(entrada);
        }
        
        public CapaObjeto.Plato PlatoEliminar(CapaObjeto.Plato entrada) {
            return base.Channel.PlatoEliminar(entrada);
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.Plato> PlatoEliminarAsync(CapaObjeto.Plato entrada) {
            return base.Channel.PlatoEliminarAsync(entrada);
        }
        
        public CapaObjeto.ListaPlatos PlatoRescatar() {
            return base.Channel.PlatoRescatar();
        }
        
        public System.Threading.Tasks.Task<CapaObjeto.ListaPlatos> PlatoRescatarAsync() {
            return base.Channel.PlatoRescatarAsync();
        }
        
        public CapaWSPresentacion.WSSoap.CompositeType GetDataUsingDataContract(CapaWSPresentacion.WSSoap.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<CapaWSPresentacion.WSSoap.CompositeType> GetDataUsingDataContractAsync(CapaWSPresentacion.WSSoap.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
