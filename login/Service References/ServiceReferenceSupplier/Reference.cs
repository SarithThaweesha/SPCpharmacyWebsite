﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login.ServiceReferenceSupplier {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSupplier.WebServiceSupplierSoap")]
    public interface WebServiceSupplierSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoSupplierId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AutoSupplierId();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoSupplierId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AutoSupplierIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertSupplier", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string insertSupplier(string supplierID, string supplierName, string address, string contact, string email, string username, string password, string confirmPw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertSupplier", ReplyAction="*")]
        System.Threading.Tasks.Task<string> insertSupplierAsync(string supplierID, string supplierName, string address, string contact, string email, string username, string password, string confirmPw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertProposal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string insertProposal(string proposalID, string supplierID, string drugId, string contact, string email, string date, string price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertProposal", ReplyAction="*")]
        System.Threading.Tasks.Task<string> insertProposalAsync(string proposalID, string supplierID, string drugId, string contact, string email, string date, string price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getDrugName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getDrugNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSupplierId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getSupplierId();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSupplierId", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getSupplierIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getDrugId(string drugName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getDrugIdAsync(string drugName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTenders", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getTenders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTenders", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getTendersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSupplierSoapChannel : login.ServiceReferenceSupplier.WebServiceSupplierSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSupplierSoapClient : System.ServiceModel.ClientBase<login.ServiceReferenceSupplier.WebServiceSupplierSoap>, login.ServiceReferenceSupplier.WebServiceSupplierSoap {
        
        public WebServiceSupplierSoapClient() {
        }
        
        public WebServiceSupplierSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSupplierSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSupplierSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSupplierSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AutoSupplierId() {
            return base.Channel.AutoSupplierId();
        }
        
        public System.Threading.Tasks.Task<string> AutoSupplierIdAsync() {
            return base.Channel.AutoSupplierIdAsync();
        }
        
        public string insertSupplier(string supplierID, string supplierName, string address, string contact, string email, string username, string password, string confirmPw) {
            return base.Channel.insertSupplier(supplierID, supplierName, address, contact, email, username, password, confirmPw);
        }
        
        public System.Threading.Tasks.Task<string> insertSupplierAsync(string supplierID, string supplierName, string address, string contact, string email, string username, string password, string confirmPw) {
            return base.Channel.insertSupplierAsync(supplierID, supplierName, address, contact, email, username, password, confirmPw);
        }
        
        public string insertProposal(string proposalID, string supplierID, string drugId, string contact, string email, string date, string price) {
            return base.Channel.insertProposal(proposalID, supplierID, drugId, contact, email, date, price);
        }
        
        public System.Threading.Tasks.Task<string> insertProposalAsync(string proposalID, string supplierID, string drugId, string contact, string email, string date, string price) {
            return base.Channel.insertProposalAsync(proposalID, supplierID, drugId, contact, email, date, price);
        }
        
        public System.Data.DataSet getDrugName() {
            return base.Channel.getDrugName();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getDrugNameAsync() {
            return base.Channel.getDrugNameAsync();
        }
        
        public System.Data.DataSet getSupplierId() {
            return base.Channel.getSupplierId();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getSupplierIdAsync() {
            return base.Channel.getSupplierIdAsync();
        }
        
        public string getDrugId(string drugName) {
            return base.Channel.getDrugId(drugName);
        }
        
        public System.Threading.Tasks.Task<string> getDrugIdAsync(string drugName) {
            return base.Channel.getDrugIdAsync(drugName);
        }
        
        public System.Data.DataSet getTenders() {
            return base.Channel.getTenders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getTendersAsync() {
            return base.Channel.getTendersAsync();
        }
    }
}