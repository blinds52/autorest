// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Http listener of an application gateway.
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayHttpListener : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        public ApplicationGatewayHttpListener()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="frontendIPConfiguration">Frontend IP configuration
        /// resource of an application gateway.</param>
        /// <param name="frontendPort">Frontend port resource of an application
        /// gateway.</param>
        /// <param name="protocol">Protocol. Possible values are: 'Http' and
        /// 'Https'. Possible values include: 'Http', 'Https'</param>
        /// <param name="hostName">Host name of HTTP listener.</param>
        /// <param name="sslCertificate">SSL certificate resource of an
        /// application gateway.</param>
        /// <param name="requireServerNameIndication">Applicable only if
        /// protocol is https. Enables SNI for multi-hosting.</param>
        /// <param name="provisioningState">Provisioning state of the HTTP
        /// listener resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewayHttpListener(string id = default(string), SubResource frontendIPConfiguration = default(SubResource), SubResource frontendPort = default(SubResource), string protocol = default(string), string hostName = default(string), SubResource sslCertificate = default(SubResource), bool? requireServerNameIndication = default(bool?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Protocol = protocol;
            HostName = hostName;
            SslCertificate = sslCertificate;
            RequireServerNameIndication = requireServerNameIndication;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frontend IP configuration resource of an application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPort")]
        public SubResource FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets protocol. Possible values are: 'Http' and 'Https'.
        /// Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets host name of HTTP listener.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets SSL certificate resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificate")]
        public SubResource SslCertificate { get; set; }

        /// <summary>
        /// Gets or sets applicable only if protocol is https. Enables SNI for
        /// multi-hosting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requireServerNameIndication")]
        public bool? RequireServerNameIndication { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the HTTP listener resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}