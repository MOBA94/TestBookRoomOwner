﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAPMAClient.BookRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amountOfPeopleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan bookingTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MAPMAClient.BookRef.Customer cusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MAPMAClient.BookRef.Employee empField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MAPMAClient.BookRef.EscapeRoom erField;
        
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
        public int amountOfPeople {
            get {
                return this.amountOfPeopleField;
            }
            set {
                if ((this.amountOfPeopleField.Equals(value) != true)) {
                    this.amountOfPeopleField = value;
                    this.RaisePropertyChanged("amountOfPeople");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan bookingTime {
            get {
                return this.bookingTimeField;
            }
            set {
                if ((this.bookingTimeField.Equals(value) != true)) {
                    this.bookingTimeField = value;
                    this.RaisePropertyChanged("bookingTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MAPMAClient.BookRef.Customer cus {
            get {
                return this.cusField;
            }
            set {
                if ((object.ReferenceEquals(this.cusField, value) != true)) {
                    this.cusField = value;
                    this.RaisePropertyChanged("cus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MAPMAClient.BookRef.Employee emp {
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
        public MAPMAClient.BookRef.EscapeRoom er {
            get {
                return this.erField;
            }
            set {
                if ((object.ReferenceEquals(this.erField, value) != true)) {
                    this.erField = value;
                    this.RaisePropertyChanged("er");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Customer : MAPMAClient.BookRef.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int customerNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string saltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int customerNo {
            get {
                return this.customerNoField;
            }
            set {
                if ((this.customerNoField.Equals(value) != true)) {
                    this.customerNoField = value;
                    this.RaisePropertyChanged("customerNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string salt {
            get {
                return this.saltField;
            }
            set {
                if ((object.ReferenceEquals(this.saltField, value) != true)) {
                    this.saltField = value;
                    this.RaisePropertyChanged("salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Employee : MAPMAClient.BookRef.Person {
        
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
        private MAPMAClient.BookRef.Employee empField;
        
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
        public MAPMAClient.BookRef.Employee emp {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MAPMAClient.BookRef.Employee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MAPMAClient.BookRef.Customer))]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8734/Design_Time_Addresses/Booking", ConfigurationName="BookRef.IBookingServices")]
    public interface IBookingServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Create", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/CreateRespon" +
            "se")]
        int Create(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Create", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/CreateRespon" +
            "se")]
        System.Threading.Tasks.Task<int> CreateAsync(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Get", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetResponse")]
        MAPMAClient.BookRef.Booking Get(int EscID, string username, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Get", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetResponse")]
        System.Threading.Tasks.Task<MAPMAClient.BookRef.Booking> GetAsync(int EscID, string username, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAll", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAllRespon" +
            "se")]
        System.Collections.Generic.List<MAPMAClient.BookRef.Booking> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAll", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAllRespon" +
            "se")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MAPMAClient.BookRef.Booking>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Delete", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/DeleteRespon" +
            "se")]
        void Delete(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Delete", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/DeleteRespon" +
            "se")]
        System.Threading.Tasks.Task DeleteAsync(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAllFromUs" +
            "er", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAllFromUs" +
            "erResponse")]
        System.Collections.Generic.List<MAPMAClient.BookRef.Booking> GetAllFromUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAllFromUs" +
            "er", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/GetAllFromUs" +
            "erResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MAPMAClient.BookRef.Booking>> GetAllFromUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Update", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/UpdateRespon" +
            "se")]
        void Update(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate, int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Update", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/UpdateRespon" +
            "se")]
        System.Threading.Tasks.Task UpdateAsync(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate, int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Deleteweb", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/DeletewebRes" +
            "ponse")]
        void Deleteweb(string username, int ER_ID, System.TimeSpan bookTime, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Deleteweb", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/DeletewebRes" +
            "ponse")]
        System.Threading.Tasks.Task DeletewebAsync(string username, int ER_ID, System.TimeSpan bookTime, System.DateTime Bdate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingServicesChannel : MAPMAClient.BookRef.IBookingServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookingServicesClient : System.ServiceModel.ClientBase<MAPMAClient.BookRef.IBookingServices>, MAPMAClient.BookRef.IBookingServices {
        
        public BookingServicesClient() {
        }
        
        public BookingServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Create(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate) {
            return base.Channel.Create(EmpID, username, ER_ID, bookTime, AOP, Bdate);
        }
        
        public System.Threading.Tasks.Task<int> CreateAsync(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate) {
            return base.Channel.CreateAsync(EmpID, username, ER_ID, bookTime, AOP, Bdate);
        }
        
        public MAPMAClient.BookRef.Booking Get(int EscID, string username, System.DateTime Bdate) {
            return base.Channel.Get(EscID, username, Bdate);
        }
        
        public System.Threading.Tasks.Task<MAPMAClient.BookRef.Booking> GetAsync(int EscID, string username, System.DateTime Bdate) {
            return base.Channel.GetAsync(EscID, username, Bdate);
        }
        
        public System.Collections.Generic.List<MAPMAClient.BookRef.Booking> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MAPMAClient.BookRef.Booking>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Delete(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate) {
            base.Channel.Delete(EmpID, username, ER_ID, bookTime, AOP, Bdate);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate) {
            return base.Channel.DeleteAsync(EmpID, username, ER_ID, bookTime, AOP, Bdate);
        }
        
        public System.Collections.Generic.List<MAPMAClient.BookRef.Booking> GetAllFromUser(string username) {
            return base.Channel.GetAllFromUser(username);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MAPMAClient.BookRef.Booking>> GetAllFromUserAsync(string username) {
            return base.Channel.GetAllFromUserAsync(username);
        }
        
        public void Update(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate, int bookId) {
            base.Channel.Update(EmpID, username, ER_ID, bookTime, AOP, Bdate, bookId);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(int EmpID, string username, int ER_ID, System.TimeSpan bookTime, int AOP, System.DateTime Bdate, int bookId) {
            return base.Channel.UpdateAsync(EmpID, username, ER_ID, bookTime, AOP, Bdate, bookId);
        }
        
        public void Deleteweb(string username, int ER_ID, System.TimeSpan bookTime, System.DateTime Bdate) {
            base.Channel.Deleteweb(username, ER_ID, bookTime, Bdate);
        }
        
        public System.Threading.Tasks.Task DeletewebAsync(string username, int ER_ID, System.TimeSpan bookTime, System.DateTime Bdate) {
            return base.Channel.DeletewebAsync(username, ER_ID, bookTime, Bdate);
        }
    }
}
