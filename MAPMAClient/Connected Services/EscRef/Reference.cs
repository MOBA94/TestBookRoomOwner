﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAPMAClient.EscRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EscapeRoom", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class EscapeRoom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<System.TimeSpan> AvalibleTimesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<string> checkListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal cleanTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MAPMAClient.EscRef.Employee empField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int escapeRoomIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal maxClearTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ratingField;
        
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
        public System.Collections.Generic.List<System.TimeSpan> AvalibleTimes {
            get {
                return this.AvalibleTimesField;
            }
            set {
                if ((object.ReferenceEquals(this.AvalibleTimesField, value) != true)) {
                    this.AvalibleTimesField = value;
                    this.RaisePropertyChanged("AvalibleTimes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> checkList {
            get {
                return this.checkListField;
            }
            set {
                if ((object.ReferenceEquals(this.checkListField, value) != true)) {
                    this.checkListField = value;
                    this.RaisePropertyChanged("checkList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal cleanTime {
            get {
                return this.cleanTimeField;
            }
            set {
                if ((this.cleanTimeField.Equals(value) != true)) {
                    this.cleanTimeField = value;
                    this.RaisePropertyChanged("cleanTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MAPMAClient.EscRef.Employee emp {
            get {
                return this.empField;
            }
            set {
                if ((object.ReferenceEquals(this.empField, value) != true)) {
                    this.empField = value;
                    this.RaisePropertyChanged("emp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int escapeRoomID {
            get {
                return this.escapeRoomIDField;
            }
            set {
                if ((this.escapeRoomIDField.Equals(value) != true)) {
                    this.escapeRoomIDField = value;
                    this.RaisePropertyChanged("escapeRoomID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal maxClearTime {
            get {
                return this.maxClearTimeField;
            }
            set {
                if ((this.maxClearTimeField.Equals(value) != true)) {
                    this.maxClearTimeField = value;
                    this.RaisePropertyChanged("maxClearTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Employee : MAPMAClient.EscRef.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int employeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string regionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int zipcodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cityName {
            get {
                return this.cityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.cityNameField, value) != true)) {
                    this.cityNameField = value;
                    this.RaisePropertyChanged("cityName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int employeeID {
            get {
                return this.employeeIDField;
            }
            set {
                if ((this.employeeIDField.Equals(value) != true)) {
                    this.employeeIDField = value;
                    this.RaisePropertyChanged("employeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string region {
            get {
                return this.regionField;
            }
            set {
                if ((object.ReferenceEquals(this.regionField, value) != true)) {
                    this.regionField = value;
                    this.RaisePropertyChanged("region");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int zipcode {
            get {
                return this.zipcodeField;
            }
            set {
                if ((this.zipcodeField.Equals(value) != true)) {
                    this.zipcodeField = value;
                    this.RaisePropertyChanged("zipcode");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MAPMAClient.EscRef.Employee))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
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
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mail {
            get {
                return this.mailField;
            }
            set {
                if ((object.ReferenceEquals(this.mailField, value) != true)) {
                    this.mailField = value;
                    this.RaisePropertyChanged("mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8735/Design_Time_Addresses/Escaperoom/", ConfigurationName="EscRef.IEscapeRoom_Services")]
    public interface IEscapeRoom_Services {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetFo" +
            "rOwner", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetFo" +
            "rOwnerResponse")]
        MAPMAClient.EscRef.EscapeRoom GetForOwner(int ER_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetFo" +
            "rOwner", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetFo" +
            "rOwnerResponse")]
        System.Threading.Tasks.Task<MAPMAClient.EscRef.EscapeRoom> GetForOwnerAsync(int ER_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetAl" +
            "lForOwner", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetAl" +
            "lForOwnerResponse")]
        System.Collections.Generic.List<MAPMAClient.EscRef.EscapeRoom> GetAllForOwner();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetAl" +
            "lForOwner", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/GetAl" +
            "lForOwnerResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MAPMAClient.EscRef.EscapeRoom>> GetAllForOwnerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Creat" +
            "eEscapeRoom", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Creat" +
            "eEscapeRoomResponse")]
        void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Creat" +
            "eEscapeRoom", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Creat" +
            "eEscapeRoomResponse")]
        System.Threading.Tasks.Task CreateEscapeRoomAsync(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Delet" +
            "eEscapeRoom", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Delet" +
            "eEscapeRoomResponse")]
        void DeleteEscapeRoom(int ER_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Delet" +
            "eEscapeRoom", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Delet" +
            "eEscapeRoomResponse")]
        System.Threading.Tasks.Task DeleteEscapeRoomAsync(int ER_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/FreeT" +
            "imes", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/FreeT" +
            "imesResponse")]
        System.Collections.Generic.List<System.TimeSpan> FreeTimes(int ER_ID, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/FreeT" +
            "imes", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/FreeT" +
            "imesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<System.TimeSpan>> FreeTimesAsync(int ER_ID, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Updat" +
            "e", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Updat" +
            "eResponse")]
        void Update(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int EscId, byte[] img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Updat" +
            "e", ReplyAction="http://localhost:8735/Design_Time_Addresses/Escaperoom/IEscapeRoom_Services/Updat" +
            "eResponse")]
        System.Threading.Tasks.Task UpdateAsync(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int EscId, byte[] img);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEscapeRoom_ServicesChannel : MAPMAClient.EscRef.IEscapeRoom_Services, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EscapeRoom_ServicesClient : System.ServiceModel.ClientBase<MAPMAClient.EscRef.IEscapeRoom_Services>, MAPMAClient.EscRef.IEscapeRoom_Services {
        
        public EscapeRoom_ServicesClient() {
        }
        
        public EscapeRoom_ServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EscapeRoom_ServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EscapeRoom_ServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EscapeRoom_ServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MAPMAClient.EscRef.EscapeRoom GetForOwner(int ER_ID) {
            return base.Channel.GetForOwner(ER_ID);
        }
        
        public System.Threading.Tasks.Task<MAPMAClient.EscRef.EscapeRoom> GetForOwnerAsync(int ER_ID) {
            return base.Channel.GetForOwnerAsync(ER_ID);
        }
        
        public System.Collections.Generic.List<MAPMAClient.EscRef.EscapeRoom> GetAllForOwner() {
            return base.Channel.GetAllForOwner();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MAPMAClient.EscRef.EscapeRoom>> GetAllForOwnerAsync() {
            return base.Channel.GetAllForOwnerAsync();
        }
        
        public void CreateEscapeRoom(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img) {
            base.Channel.CreateEscapeRoom(name, description, maxClearTime, cleanTime, price, rating, empId, img);
        }
        
        public System.Threading.Tasks.Task CreateEscapeRoomAsync(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, byte[] img) {
            return base.Channel.CreateEscapeRoomAsync(name, description, maxClearTime, cleanTime, price, rating, empId, img);
        }
        
        public void DeleteEscapeRoom(int ER_ID) {
            base.Channel.DeleteEscapeRoom(ER_ID);
        }
        
        public System.Threading.Tasks.Task DeleteEscapeRoomAsync(int ER_ID) {
            return base.Channel.DeleteEscapeRoomAsync(ER_ID);
        }
        
        public System.Collections.Generic.List<System.TimeSpan> FreeTimes(int ER_ID, System.DateTime Bdate) {
            return base.Channel.FreeTimes(ER_ID, Bdate);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<System.TimeSpan>> FreeTimesAsync(int ER_ID, System.DateTime Bdate) {
            return base.Channel.FreeTimesAsync(ER_ID, Bdate);
        }
        
        public void Update(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int EscId, byte[] img) {
            base.Channel.Update(name, description, maxClearTime, cleanTime, price, rating, empId, EscId, img);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string name, string description, decimal maxClearTime, decimal cleanTime, decimal price, decimal rating, int empId, int EscId, byte[] img) {
            return base.Channel.UpdateAsync(name, description, maxClearTime, cleanTime, price, rating, empId, EscId, img);
        }
    }
}
