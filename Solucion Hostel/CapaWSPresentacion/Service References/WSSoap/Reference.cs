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
        
        public CapaWSPresentacion.WSSoap.CompositeType GetDataUsingDataContract(CapaWSPresentacion.WSSoap.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<CapaWSPresentacion.WSSoap.CompositeType> GetDataUsingDataContractAsync(CapaWSPresentacion.WSSoap.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
