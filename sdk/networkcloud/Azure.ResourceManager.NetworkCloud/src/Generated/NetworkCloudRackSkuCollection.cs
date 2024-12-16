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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudRackSkuResource"/> and their operations.
    /// Each <see cref="NetworkCloudRackSkuResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="NetworkCloudRackSkuCollection"/> instance call the GetNetworkCloudRackSkus method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class NetworkCloudRackSkuCollection : ArmCollection, IEnumerable<NetworkCloudRackSkuResource>, IAsyncEnumerable<NetworkCloudRackSkuResource>
    {
        private readonly ClientDiagnostics _networkCloudRackSkuRackSkusClientDiagnostics;
        private readonly RackSkusRestOperations _networkCloudRackSkuRackSkusRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudRackSkuCollection"/> class for mocking. </summary>
        protected NetworkCloudRackSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudRackSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudRackSkuCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudRackSkuRackSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudRackSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudRackSkuResource.ResourceType, out string networkCloudRackSkuRackSkusApiVersion);
            _networkCloudRackSkuRackSkusRestClient = new RackSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudRackSkuRackSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the properties of the provided rack SKU.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudRackSkuResource>> GetAsync(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _networkCloudRackSkuRackSkusClientDiagnostics.CreateScope("NetworkCloudRackSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudRackSkuRackSkusRestClient.GetAsync(Id.SubscriptionId, rackSkuName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of the provided rack SKU.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual Response<NetworkCloudRackSkuResource> Get(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _networkCloudRackSkuRackSkusClientDiagnostics.CreateScope("NetworkCloudRackSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudRackSkuRackSkusRestClient.Get(Id.SubscriptionId, rackSkuName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of rack SKUs in the provided subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudRackSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudRackSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudRackSkuRackSkusRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudRackSkuRackSkusRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudRackSkuResource(Client, NetworkCloudRackSkuData.DeserializeNetworkCloudRackSkuData(e)), _networkCloudRackSkuRackSkusClientDiagnostics, Pipeline, "NetworkCloudRackSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of rack SKUs in the provided subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudRackSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudRackSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudRackSkuRackSkusRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudRackSkuRackSkusRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudRackSkuResource(Client, NetworkCloudRackSkuData.DeserializeNetworkCloudRackSkuData(e)), _networkCloudRackSkuRackSkusClientDiagnostics, Pipeline, "NetworkCloudRackSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _networkCloudRackSkuRackSkusClientDiagnostics.CreateScope("NetworkCloudRackSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudRackSkuRackSkusRestClient.GetAsync(Id.SubscriptionId, rackSkuName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual Response<bool> Exists(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _networkCloudRackSkuRackSkusClientDiagnostics.CreateScope("NetworkCloudRackSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudRackSkuRackSkusRestClient.Get(Id.SubscriptionId, rackSkuName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudRackSkuResource>> GetIfExistsAsync(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _networkCloudRackSkuRackSkusClientDiagnostics.CreateScope("NetworkCloudRackSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudRackSkuRackSkusRestClient.GetAsync(Id.SubscriptionId, rackSkuName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudRackSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackSkuResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkCloudRackSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudRackSkuResource> GetIfExists(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _networkCloudRackSkuRackSkusClientDiagnostics.CreateScope("NetworkCloudRackSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudRackSkuRackSkusRestClient.Get(Id.SubscriptionId, rackSkuName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudRackSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudRackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudRackSkuResource> IEnumerable<NetworkCloudRackSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudRackSkuResource> IAsyncEnumerable<NetworkCloudRackSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
