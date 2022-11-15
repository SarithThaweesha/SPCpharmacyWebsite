﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login.ServiceReferenceManageDtls {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceManageDtls.WebServiceManageSoap")]
    public interface WebServiceManageSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string placeOrder(string orderID, string drugName, string drugQty, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<string> placeOrderAsync(string orderID, string drugName, string drugQty, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrderPh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string placeOrderPh(string orderID, string pharmacyName, string contact, string drugName, string drugQty, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrderPh", ReplyAction="*")]
        System.Threading.Tasks.Task<string> placeOrderPhAsync(string orderID, string pharmacyName, string contact, string drugName, string drugQty, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSPCorders", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getSPCorders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSPCorders", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getSPCordersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPharmacyOrders", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getPharmacyOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPharmacyOrders", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getPharmacyOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerStaff", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string registerStaff(string staffID, string staffName, string address, string contact, string email, string username, string password, string confirmPw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerStaff", ReplyAction="*")]
        System.Threading.Tasks.Task<string> registerStaffAsync(string staffID, string staffName, string address, string contact, string email, string username, string password, string confirmPw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerPharmacies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string registerPharmacies(string pharmacyID, string pharmacyName, string address, string contact, string email, string username, string password, string confirmPw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerPharmacies", ReplyAction="*")]
        System.Threading.Tasks.Task<string> registerPharmaciesAsync(string pharmacyID, string pharmacyName, string address, string contact, string email, string username, string password, string confirmPw);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceManageSoapChannel : login.ServiceReferenceManageDtls.WebServiceManageSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceManageSoapClient : System.ServiceModel.ClientBase<login.ServiceReferenceManageDtls.WebServiceManageSoap>, login.ServiceReferenceManageDtls.WebServiceManageSoap {
        
        public WebServiceManageSoapClient() {
        }
        
        public WebServiceManageSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceManageSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceManageSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceManageSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string placeOrder(string orderID, string drugName, string drugQty, string date) {
            return base.Channel.placeOrder(orderID, drugName, drugQty, date);
        }
        
        public System.Threading.Tasks.Task<string> placeOrderAsync(string orderID, string drugName, string drugQty, string date) {
            return base.Channel.placeOrderAsync(orderID, drugName, drugQty, date);
        }
        
        public string placeOrderPh(string orderID, string pharmacyName, string contact, string drugName, string drugQty, string date) {
            return base.Channel.placeOrderPh(orderID, pharmacyName, contact, drugName, drugQty, date);
        }
        
        public System.Threading.Tasks.Task<string> placeOrderPhAsync(string orderID, string pharmacyName, string contact, string drugName, string drugQty, string date) {
            return base.Channel.placeOrderPhAsync(orderID, pharmacyName, contact, drugName, drugQty, date);
        }
        
        public System.Data.DataSet getSPCorders() {
            return base.Channel.getSPCorders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getSPCordersAsync() {
            return base.Channel.getSPCordersAsync();
        }
        
        public System.Data.DataSet getPharmacyOrders() {
            return base.Channel.getPharmacyOrders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getPharmacyOrdersAsync() {
            return base.Channel.getPharmacyOrdersAsync();
        }
        
        public string registerStaff(string staffID, string staffName, string address, string contact, string email, string username, string password, string confirmPw) {
            return base.Channel.registerStaff(staffID, staffName, address, contact, email, username, password, confirmPw);
        }
        
        public System.Threading.Tasks.Task<string> registerStaffAsync(string staffID, string staffName, string address, string contact, string email, string username, string password, string confirmPw) {
            return base.Channel.registerStaffAsync(staffID, staffName, address, contact, email, username, password, confirmPw);
        }
        
        public string registerPharmacies(string pharmacyID, string pharmacyName, string address, string contact, string email, string username, string password, string confirmPw) {
            return base.Channel.registerPharmacies(pharmacyID, pharmacyName, address, contact, email, username, password, confirmPw);
        }
        
        public System.Threading.Tasks.Task<string> registerPharmaciesAsync(string pharmacyID, string pharmacyName, string address, string contact, string email, string username, string password, string confirmPw) {
            return base.Channel.registerPharmaciesAsync(pharmacyID, pharmacyName, address, contact, email, username, password, confirmPw);
        }
    }
}
