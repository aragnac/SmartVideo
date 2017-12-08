﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.ServiceHostReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilmDTO", Namespace="http://schemas.datacontract.org/2004/07/FilmDTOLibrary")]
    [System.SerializableAttribute()]
    public partial class FilmDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Original_titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosterpathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RuntimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrailerpathField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Original_title {
            get {
                return this.Original_titleField;
            }
            set {
                if ((object.ReferenceEquals(this.Original_titleField, value) != true)) {
                    this.Original_titleField = value;
                    this.RaisePropertyChanged("Original_title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posterpath {
            get {
                return this.PosterpathField;
            }
            set {
                if ((object.ReferenceEquals(this.PosterpathField, value) != true)) {
                    this.PosterpathField = value;
                    this.RaisePropertyChanged("Posterpath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Runtime {
            get {
                return this.RuntimeField;
            }
            set {
                if ((this.RuntimeField.Equals(value) != true)) {
                    this.RuntimeField = value;
                    this.RaisePropertyChanged("Runtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Trailerpath {
            get {
                return this.TrailerpathField;
            }
            set {
                if ((object.ReferenceEquals(this.TrailerpathField, value) != true)) {
                    this.TrailerpathField = value;
                    this.RaisePropertyChanged("Trailerpath");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceHostReference.IToolsBD")]
    public interface IToolsBD {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilms", ReplyAction="http://tempuri.org/IToolsBD/GetFilmsResponse")]
        WebApplication.ServiceHostReference.FilmDTO[] GetFilms(string table, int start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToolsBD/GetFilms", ReplyAction="http://tempuri.org/IToolsBD/GetFilmsResponse")]
        System.Threading.Tasks.Task<WebApplication.ServiceHostReference.FilmDTO[]> GetFilmsAsync(string table, int start);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToolsBDChannel : WebApplication.ServiceHostReference.IToolsBD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToolsBDClient : System.ServiceModel.ClientBase<WebApplication.ServiceHostReference.IToolsBD>, WebApplication.ServiceHostReference.IToolsBD {
        
        public ToolsBDClient() {
        }
        
        public ToolsBDClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ToolsBDClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToolsBDClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToolsBDClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication.ServiceHostReference.FilmDTO[] GetFilms(string table, int start) {
            return base.Channel.GetFilms(table, start);
        }
        
        public System.Threading.Tasks.Task<WebApplication.ServiceHostReference.FilmDTO[]> GetFilmsAsync(string table, int start) {
            return base.Channel.GetFilmsAsync(table, start);
        }
    }
}