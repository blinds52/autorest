// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Network interface and all its associated security rules.
    /// </summary>
    public partial class SecurityGroupNetworkInterface
    {
        /// <summary>
        /// Initializes a new instance of the SecurityGroupNetworkInterface
        /// class.
        /// </summary>
        public SecurityGroupNetworkInterface()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityGroupNetworkInterface
        /// class.
        /// </summary>
        /// <param name="id">ID of the network interface.</param>
        public SecurityGroupNetworkInterface(string id = default(string), SecurityRuleAssociations securityRuleAssociations = default(SecurityRuleAssociations))
        {
            Id = id;
            SecurityRuleAssociations = securityRuleAssociations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the network interface.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "securityRuleAssociations")]
        public SecurityRuleAssociations SecurityRuleAssociations { get; set; }

    }
}
