﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34209
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CocktailizrClient.AdminServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/System.Drawing")]
    [System.SerializableAttribute()]
    public partial struct Color : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private short knownColorField;
        
        private string nameField;
        
        private short stateField;
        
        private long valueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short knownColor {
            get {
                return this.knownColorField;
            }
            set {
                if ((this.knownColorField.Equals(value) != true)) {
                    this.knownColorField = value;
                    this.RaisePropertyChanged("knownColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short state {
            get {
                return this.stateField;
            }
            set {
                if ((this.stateField.Equals(value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long value {
            get {
                return this.valueField;
            }
            set {
                if ((this.valueField.Equals(value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminServiceReference.IAdminService")]
    public interface IAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddCocktail", ReplyAction="http://tempuri.org/IAdminService/AddCocktailResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.CocktailizrEntityBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Rezept))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Step[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Step))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Zutat))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.ZutatenSkala))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrClient.AdminServiceReference.Color))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<CocktailizrTypes.Model.Entities.Zutat, decimal>))]
        bool AddCocktail(CocktailizrTypes.Model.Entities.Cocktail cocktail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddCocktail", ReplyAction="http://tempuri.org/IAdminService/AddCocktailResponse")]
        System.Threading.Tasks.Task<bool> AddCocktailAsync(CocktailizrTypes.Model.Entities.Cocktail cocktail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/ModifyCocktail", ReplyAction="http://tempuri.org/IAdminService/ModifyCocktailResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.CocktailizrEntityBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Rezept))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Step[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Step))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.Zutat))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrTypes.Model.Entities.ZutatenSkala))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CocktailizrClient.AdminServiceReference.Color))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<CocktailizrTypes.Model.Entities.Zutat, decimal>))]
        bool ModifyCocktail(System.Guid cocktailId, CocktailizrTypes.Model.Entities.Cocktail cocktail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/ModifyCocktail", ReplyAction="http://tempuri.org/IAdminService/ModifyCocktailResponse")]
        System.Threading.Tasks.Task<bool> ModifyCocktailAsync(System.Guid cocktailId, CocktailizrTypes.Model.Entities.Cocktail cocktail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/RemoveCocktail", ReplyAction="http://tempuri.org/IAdminService/RemoveCocktailResponse")]
        bool RemoveCocktail(System.Guid cocktailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/RemoveCocktail", ReplyAction="http://tempuri.org/IAdminService/RemoveCocktailResponse")]
        System.Threading.Tasks.Task<bool> RemoveCocktailAsync(System.Guid cocktailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddZutat", ReplyAction="http://tempuri.org/IAdminService/AddZutatResponse")]
        bool AddZutat(CocktailizrTypes.Model.Entities.Zutat zutat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddZutat", ReplyAction="http://tempuri.org/IAdminService/AddZutatResponse")]
        System.Threading.Tasks.Task<bool> AddZutatAsync(CocktailizrTypes.Model.Entities.Zutat zutat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/ModifyZutat", ReplyAction="http://tempuri.org/IAdminService/ModifyZutatResponse")]
        bool ModifyZutat(System.Guid zutatId, CocktailizrTypes.Model.Entities.Zutat zutat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/ModifyZutat", ReplyAction="http://tempuri.org/IAdminService/ModifyZutatResponse")]
        System.Threading.Tasks.Task<bool> ModifyZutatAsync(System.Guid zutatId, CocktailizrTypes.Model.Entities.Zutat zutat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/RemoveZutat", ReplyAction="http://tempuri.org/IAdminService/RemoveZutatResponse")]
        bool RemoveZutat(System.Guid zutatId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/RemoveZutat", ReplyAction="http://tempuri.org/IAdminService/RemoveZutatResponse")]
        System.Threading.Tasks.Task<bool> RemoveZutatAsync(System.Guid zutatId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : CocktailizrClient.AdminServiceReference.IAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<CocktailizrClient.AdminServiceReference.IAdminService>, CocktailizrClient.AdminServiceReference.IAdminService {
        
        public AdminServiceClient() {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddCocktail(CocktailizrTypes.Model.Entities.Cocktail cocktail) {
            return base.Channel.AddCocktail(cocktail);
        }
        
        public System.Threading.Tasks.Task<bool> AddCocktailAsync(CocktailizrTypes.Model.Entities.Cocktail cocktail) {
            return base.Channel.AddCocktailAsync(cocktail);
        }
        
        public bool ModifyCocktail(System.Guid cocktailId, CocktailizrTypes.Model.Entities.Cocktail cocktail) {
            return base.Channel.ModifyCocktail(cocktailId, cocktail);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyCocktailAsync(System.Guid cocktailId, CocktailizrTypes.Model.Entities.Cocktail cocktail) {
            return base.Channel.ModifyCocktailAsync(cocktailId, cocktail);
        }
        
        public bool RemoveCocktail(System.Guid cocktailId) {
            return base.Channel.RemoveCocktail(cocktailId);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveCocktailAsync(System.Guid cocktailId) {
            return base.Channel.RemoveCocktailAsync(cocktailId);
        }
        
        public bool AddZutat(CocktailizrTypes.Model.Entities.Zutat zutat) {
            return base.Channel.AddZutat(zutat);
        }
        
        public System.Threading.Tasks.Task<bool> AddZutatAsync(CocktailizrTypes.Model.Entities.Zutat zutat) {
            return base.Channel.AddZutatAsync(zutat);
        }
        
        public bool ModifyZutat(System.Guid zutatId, CocktailizrTypes.Model.Entities.Zutat zutat) {
            return base.Channel.ModifyZutat(zutatId, zutat);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyZutatAsync(System.Guid zutatId, CocktailizrTypes.Model.Entities.Zutat zutat) {
            return base.Channel.ModifyZutatAsync(zutatId, zutat);
        }
        
        public bool RemoveZutat(System.Guid zutatId) {
            return base.Channel.RemoveZutat(zutatId);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveZutatAsync(System.Guid zutatId) {
            return base.Channel.RemoveZutatAsync(zutatId);
        }
    }
}
