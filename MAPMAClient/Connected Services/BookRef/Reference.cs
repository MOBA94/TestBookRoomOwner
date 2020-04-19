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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8734/Design_Time_Addresses/Booking", ConfigurationName="BookRef.IBookingServices")]
    public interface IBookingServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Create", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/CreateRespon" +
            "se")]
        void Create(int EmpID, string username, int ER_ID, System.DateTime bookTime, int AOP, System.DateTime Bdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/Create", ReplyAction="http://localhost:8734/Design_Time_Addresses/Booking/IBookingServices/CreateRespon" +
            "se")]
        System.Threading.Tasks.Task CreateAsync(int EmpID, string username, int ER_ID, System.DateTime bookTime, int AOP, System.DateTime Bdate);
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
        
        public void Create(int EmpID, string username, int ER_ID, System.DateTime bookTime, int AOP, System.DateTime Bdate) {
            base.Channel.Create(EmpID, username, ER_ID, bookTime, AOP, Bdate);
        }
        
        public System.Threading.Tasks.Task CreateAsync(int EmpID, string username, int ER_ID, System.DateTime bookTime, int AOP, System.DateTime Bdate) {
            return base.Channel.CreateAsync(EmpID, username, ER_ID, bookTime, AOP, Bdate);
        }
    }
}
