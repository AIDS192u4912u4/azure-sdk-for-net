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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing a collection of <see cref="StreamAnalyticsPrivateEndpointResource" /> and their operations.
    /// Each <see cref="StreamAnalyticsPrivateEndpointResource" /> in the collection will belong to the same instance of <see cref="StreamAnalyticsClusterResource" />.
    /// To get a <see cref="StreamAnalyticsPrivateEndpointCollection" /> instance call the GetStreamAnalyticsPrivateEndpoints method from an instance of <see cref="StreamAnalyticsClusterResource" />.
    /// </summary>
    public partial class StreamAnalyticsPrivateEndpointCollection : ArmCollection, IEnumerable<StreamAnalyticsPrivateEndpointResource>, IAsyncEnumerable<StreamAnalyticsPrivateEndpointResource>
    {
        private readonly ClientDiagnostics _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics;
        private readonly PrivateEndpointsRestOperations _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StreamAnalyticsPrivateEndpointCollection"/> class for mocking. </summary>
        protected StreamAnalyticsPrivateEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamAnalyticsPrivateEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StreamAnalyticsPrivateEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", StreamAnalyticsPrivateEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StreamAnalyticsPrivateEndpointResource.ResourceType, out string streamAnalyticsPrivateEndpointPrivateEndpointsApiVersion);
            _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient = new PrivateEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamAnalyticsPrivateEndpointPrivateEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StreamAnalyticsClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StreamAnalyticsClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Stream Analytics Private Endpoint or replaces an already existing Private Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="data"> The definition of the private endpoint that will be used to create a new cluster or replace the existing one. </param>
        /// <param name="ifMatch"> The ETag of the resource. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing record set. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StreamAnalyticsPrivateEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointName, StreamAnalyticsPrivateEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics.CreateScope("StreamAnalyticsPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsPrivateEndpointResource>(Response.FromValue(new StreamAnalyticsPrivateEndpointResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a Stream Analytics Private Endpoint or replaces an already existing Private Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="data"> The definition of the private endpoint that will be used to create a new cluster or replace the existing one. </param>
        /// <param name="ifMatch"> The ETag of the resource. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new resource to be created, but to prevent updating an existing record set. Other values will result in a 412 Pre-condition Failed response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StreamAnalyticsPrivateEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointName, StreamAnalyticsPrivateEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics.CreateScope("StreamAnalyticsPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsPrivateEndpointResource>(Response.FromValue(new StreamAnalyticsPrivateEndpointResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified Private Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual async Task<Response<StreamAnalyticsPrivateEndpointResource>> GetAsync(string privateEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics.CreateScope("StreamAnalyticsPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamAnalyticsPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified Private Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<StreamAnalyticsPrivateEndpointResource> Get(string privateEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics.CreateScope("StreamAnalyticsPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamAnalyticsPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the private endpoints in the cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StreamAnalyticsPrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StreamAnalyticsPrivateEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StreamAnalyticsPrivateEndpointResource(Client, StreamAnalyticsPrivateEndpointData.DeserializeStreamAnalyticsPrivateEndpointData(e)), _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics, Pipeline, "StreamAnalyticsPrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the private endpoints in the cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StreamAnalyticsPrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StreamAnalyticsPrivateEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StreamAnalyticsPrivateEndpointResource(Client, StreamAnalyticsPrivateEndpointData.DeserializeStreamAnalyticsPrivateEndpointData(e)), _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics, Pipeline, "StreamAnalyticsPrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics.CreateScope("StreamAnalyticsPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/clusters/{clusterName}/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _streamAnalyticsPrivateEndpointPrivateEndpointsClientDiagnostics.CreateScope("StreamAnalyticsPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _streamAnalyticsPrivateEndpointPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StreamAnalyticsPrivateEndpointResource> IEnumerable<StreamAnalyticsPrivateEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StreamAnalyticsPrivateEndpointResource> IAsyncEnumerable<StreamAnalyticsPrivateEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
