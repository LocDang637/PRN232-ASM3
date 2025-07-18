﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoachLocDpxServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CoachesLocDpx", Namespace="http://schemas.datacontract.org/2004/07/SmokeQuit.SoapAPIServices.LocDPX.SoapMode" +
        "ls")]
    public partial class CoachesLocDpx : object
    {
        
        private string BioField;
        
        private int CoachesLocDpxidField;
        
        private System.Nullable<System.DateTime> CreatedAtField;
        
        private string EmailField;
        
        private string FullNameField;
        
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bio
        {
            get
            {
                return this.BioField;
            }
            set
            {
                this.BioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CoachesLocDpxid
        {
            get
            {
                return this.CoachesLocDpxidField;
            }
            set
            {
                this.CoachesLocDpxidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName
        {
            get
            {
                return this.FullNameField;
            }
            set
            {
                this.FullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CoachLocDpxServiceReference.ICoachLocDpxSoapService")]
    public interface ICoachLocDpxSoapService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICoachLocDpxSoapService/GetAll", ReplyAction="http://tempuri.org/ICoachLocDpxSoapService/GetAllResponse")]
        System.Threading.Tasks.Task<CoachLocDpxServiceReference.CoachesLocDpx[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public interface ICoachLocDpxSoapServiceChannel : CoachLocDpxServiceReference.ICoachLocDpxSoapService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public partial class CoachLocDpxSoapServiceClient : System.ServiceModel.ClientBase<CoachLocDpxServiceReference.ICoachLocDpxSoapService>, CoachLocDpxServiceReference.ICoachLocDpxSoapService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CoachLocDpxSoapServiceClient() : 
                base(CoachLocDpxSoapServiceClient.GetDefaultBinding(), CoachLocDpxSoapServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICoachLocDpxSoapService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoachLocDpxSoapServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CoachLocDpxSoapServiceClient.GetBindingForEndpoint(endpointConfiguration), CoachLocDpxSoapServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoachLocDpxSoapServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CoachLocDpxSoapServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoachLocDpxSoapServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CoachLocDpxSoapServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CoachLocDpxSoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<CoachLocDpxServiceReference.CoachesLocDpx[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        #if !NET6_0_OR_GREATER
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        #endif
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICoachLocDpxSoapService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICoachLocDpxSoapService))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7234/CoachService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CoachLocDpxSoapServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICoachLocDpxSoapService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CoachLocDpxSoapServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICoachLocDpxSoapService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICoachLocDpxSoapService,
        }
    }
}
