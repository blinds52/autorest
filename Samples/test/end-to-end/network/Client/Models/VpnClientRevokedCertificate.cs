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
    /// VPN client revoked certificate of virtual network gateway.
    /// </summary>
    [JsonTransformation]
    public partial class VpnClientRevokedCertificate : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientRevokedCertificate
        /// class.
        /// </summary>
        public VpnClientRevokedCertificate()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnClientRevokedCertificate
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="thumbprint">The revoked VPN client certificate
        /// thumbprint.</param>
        /// <param name="provisioningState">The provisioning state of the VPN
        /// client revoked certificate resource. Possible values are:
        /// 'Updating', 'Deleting', and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VpnClientRevokedCertificate(string id = default(string), string thumbprint = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Thumbprint = thumbprint;
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
        /// Gets or sets the revoked VPN client certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VPN client revoked certificate
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
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
