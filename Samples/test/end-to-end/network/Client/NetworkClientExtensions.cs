// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NetworkClient.
    /// </summary>
    public static partial class NetworkClientExtensions
    {
            /// <summary>
            /// Checks whether a domain name in the cloudapp.net zone is available for use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the domain name.
            /// </param>
            /// <param name='domainNameLabel'>
            /// The domain name to be verified. It must conform to the following regular
            /// expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
            /// </param>
            public static DnsNameAvailabilityResult CheckDnsNameAvailability(this INetworkClient operations, string location, string domainNameLabel = default(string))
            {
                return operations.CheckDnsNameAvailabilityAsync(location, domainNameLabel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether a domain name in the cloudapp.net zone is available for use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the domain name.
            /// </param>
            /// <param name='domainNameLabel'>
            /// The domain name to be verified. It must conform to the following regular
            /// expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsNameAvailabilityResult> CheckDnsNameAvailabilityAsync(this INetworkClient operations, string location, string domainNameLabel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckDnsNameAvailabilityWithHttpMessagesAsync(location, domainNameLabel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
