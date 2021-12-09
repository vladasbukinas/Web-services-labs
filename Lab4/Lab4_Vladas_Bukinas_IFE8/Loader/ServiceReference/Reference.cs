﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OfferRequest", Namespace="http://schemas.datacontract.org/2004/07/GRPCtoSOAP")]
    public partial class OfferRequest : object
    {
        
        private int itemCountField;
        
        private int priceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerRequest", Namespace="http://schemas.datacontract.org/2004/07/GRPCtoSOAP")]
    public partial class CustomerRequest : object
    {
        
        private int delayField;
        
        private int idField;
        
        private int itemCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int delay
        {
            get
            {
                return this.delayField;
            }
            set
            {
                this.delayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ICounter")]
    public interface ICounter
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/NeedRefill", ReplyAction="http://tempuri.org/ICounter/NeedRefillResponse")]
        bool NeedRefill();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/NeedRefill", ReplyAction="http://tempuri.org/ICounter/NeedRefillResponse")]
        System.Threading.Tasks.Task<bool> NeedRefillAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/TakeOffer", ReplyAction="http://tempuri.org/ICounter/TakeOfferResponse")]
        bool TakeOffer(ServiceReference.OfferRequest offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/TakeOffer", ReplyAction="http://tempuri.org/ICounter/TakeOfferResponse")]
        System.Threading.Tasks.Task<bool> TakeOfferAsync(ServiceReference.OfferRequest offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/EnterQueue", ReplyAction="http://tempuri.org/ICounter/EnterQueueResponse")]
        int EnterQueue(ServiceReference.CustomerRequest customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/EnterQueue", ReplyAction="http://tempuri.org/ICounter/EnterQueueResponse")]
        System.Threading.Tasks.Task<int> EnterQueueAsync(ServiceReference.CustomerRequest customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/LeaveQueue", ReplyAction="http://tempuri.org/ICounter/LeaveQueueResponse")]
        bool LeaveQueue(ServiceReference.CustomerRequest customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/LeaveQueue", ReplyAction="http://tempuri.org/ICounter/LeaveQueueResponse")]
        System.Threading.Tasks.Task<bool> LeaveQueueAsync(ServiceReference.CustomerRequest customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/IsServed", ReplyAction="http://tempuri.org/ICounter/IsServedResponse")]
        bool IsServed(ServiceReference.CustomerRequest customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounter/IsServed", ReplyAction="http://tempuri.org/ICounter/IsServedResponse")]
        System.Threading.Tasks.Task<bool> IsServedAsync(ServiceReference.CustomerRequest customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ICounterChannel : ServiceReference.ICounter, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class CounterClient : System.ServiceModel.ClientBase<ServiceReference.ICounter>, ServiceReference.ICounter
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CounterClient() : 
                base(CounterClient.GetDefaultBinding(), CounterClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICounter.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CounterClient(EndpointConfiguration endpointConfiguration) : 
                base(CounterClient.GetBindingForEndpoint(endpointConfiguration), CounterClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CounterClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CounterClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CounterClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CounterClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CounterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool NeedRefill()
        {
            return base.Channel.NeedRefill();
        }
        
        public System.Threading.Tasks.Task<bool> NeedRefillAsync()
        {
            return base.Channel.NeedRefillAsync();
        }
        
        public bool TakeOffer(ServiceReference.OfferRequest offer)
        {
            return base.Channel.TakeOffer(offer);
        }
        
        public System.Threading.Tasks.Task<bool> TakeOfferAsync(ServiceReference.OfferRequest offer)
        {
            return base.Channel.TakeOfferAsync(offer);
        }
        
        public int EnterQueue(ServiceReference.CustomerRequest customer)
        {
            return base.Channel.EnterQueue(customer);
        }
        
        public System.Threading.Tasks.Task<int> EnterQueueAsync(ServiceReference.CustomerRequest customer)
        {
            return base.Channel.EnterQueueAsync(customer);
        }
        
        public bool LeaveQueue(ServiceReference.CustomerRequest customer)
        {
            return base.Channel.LeaveQueue(customer);
        }
        
        public System.Threading.Tasks.Task<bool> LeaveQueueAsync(ServiceReference.CustomerRequest customer)
        {
            return base.Channel.LeaveQueueAsync(customer);
        }
        
        public bool IsServed(ServiceReference.CustomerRequest customer)
        {
            return base.Channel.IsServed(customer);
        }
        
        public System.Threading.Tasks.Task<bool> IsServedAsync(ServiceReference.CustomerRequest customer)
        {
            return base.Channel.IsServedAsync(customer);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICounter))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICounter))
            {
                return new System.ServiceModel.EndpointAddress("http://127.0.0.1:5004/Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CounterClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICounter);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CounterClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICounter);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICounter,
        }
    }
}
