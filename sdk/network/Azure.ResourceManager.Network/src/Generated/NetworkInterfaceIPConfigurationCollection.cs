// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkInterfaceIPConfigurationResource"/> and their operations.
    /// Each <see cref="NetworkInterfaceIPConfigurationResource"/> in the collection will belong to the same instance of <see cref="NetworkInterfaceResource"/>.
    /// To get a <see cref="NetworkInterfaceIPConfigurationCollection"/> instance call the GetNetworkInterfaceIPConfigurations method from an instance of <see cref="NetworkInterfaceResource"/>.
    /// </summary>
    public partial class NetworkInterfaceIPConfigurationCollection : ArmCollection, IEnumerable<NetworkInterfaceIPConfigurationResource>, IAsyncEnumerable<NetworkInterfaceIPConfigurationResource>
    {
        private readonly ClientDiagnostics _networkInterfaceIPConfigurationClientDiagnostics;
        private readonly NetworkInterfaceIPConfigurationsRestOperations _networkInterfaceIPConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceIPConfigurationCollection"/> class for mocking. </summary>
        protected NetworkInterfaceIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceIPConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceIPConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceIPConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterfaceIPConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkInterfaceIPConfigurationResource.ResourceType, out string networkInterfaceIPConfigurationApiVersion);
            _networkInterfaceIPConfigurationRestClient = new NetworkInterfaceIPConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkInterfaceIPConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkInterfaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkInterfaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified network interface ip configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual async Task<Response<NetworkInterfaceIPConfigurationResource>> GetAsync(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network interface ip configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceIPConfigurationResource> Get(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all ip configurations in a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceIPConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceIPConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkInterfaceIPConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkInterfaceIPConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceIPConfigurationResource(Client, NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(e)), _networkInterfaceIPConfigurationClientDiagnostics, Pipeline, "NetworkInterfaceIPConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all ip configurations in a network interface.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceIPConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceIPConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkInterfaceIPConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkInterfaceIPConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkInterfaceIPConfigurationResource(Client, NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(e)), _networkInterfaceIPConfigurationClientDiagnostics, Pipeline, "NetworkInterfaceIPConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkInterfaceIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkInterfaceIPConfigurationResource>> GetIfExistsAsync(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceIPConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkInterfaceIPConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/ipConfigurations/{ipConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaceIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkInterfaceIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ipConfigurationName"> The name of the ip configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurationName"/> is null. </exception>
        public virtual NullableResponse<NetworkInterfaceIPConfigurationResource> GetIfExists(string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigurationName, nameof(ipConfigurationName));

            using var scope = _networkInterfaceIPConfigurationClientDiagnostics.CreateScope("NetworkInterfaceIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceIPConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkInterfaceIPConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterfaceIPConfigurationResource> IEnumerable<NetworkInterfaceIPConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterfaceIPConfigurationResource> IAsyncEnumerable<NetworkInterfaceIPConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
