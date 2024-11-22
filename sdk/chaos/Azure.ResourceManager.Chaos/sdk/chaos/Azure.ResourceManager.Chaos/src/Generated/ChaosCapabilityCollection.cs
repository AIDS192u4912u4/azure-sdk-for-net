// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ChaosCapabilityResource"/> and their operations.
    /// Each <see cref="ChaosCapabilityResource"/> in the collection will belong to the same instance of <see cref="ChaosTargetResource"/>.
    /// To get a <see cref="ChaosCapabilityCollection"/> instance call the GetChaosCapabilities method from an instance of <see cref="ChaosTargetResource"/>.
    /// </summary>
    public partial class ChaosCapabilityCollection : ArmCollection, IEnumerable<ChaosCapabilityResource>, IAsyncEnumerable<ChaosCapabilityResource>
    {
        private readonly ClientDiagnostics _chaosCapabilityCapabilitiesClientDiagnostics;
        private readonly CapabilitiesRestOperations _chaosCapabilityCapabilitiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ChaosCapabilityCollection"/> class for mocking. </summary>
        protected ChaosCapabilityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosCapabilityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ChaosCapabilityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _chaosCapabilityCapabilitiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ChaosCapabilityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ChaosCapabilityResource.ResourceType, out string chaosCapabilityCapabilitiesApiVersion);
            _chaosCapabilityCapabilitiesRestClient = new CapabilitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, chaosCapabilityCapabilitiesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ChaosTargetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ChaosTargetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Capability resource that extends a Target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="data"> Capability resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ChaosCapabilityResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string capabilityName, ChaosCapabilityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _chaosCapabilityCapabilitiesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, data, cancellationToken).ConfigureAwait(false);
                var uri = _chaosCapabilityCapabilitiesRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ChaosArmOperation<ChaosCapabilityResource>(Response.FromValue(new ChaosCapabilityResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update a Capability resource that extends a Target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="data"> Capability resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ChaosCapabilityResource> CreateOrUpdate(WaitUntil waitUntil, string capabilityName, ChaosCapabilityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _chaosCapabilityCapabilitiesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, data, cancellationToken);
                var uri = _chaosCapabilityCapabilitiesRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ChaosArmOperation<ChaosCapabilityResource>(Response.FromValue(new ChaosCapabilityResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a Capability resource that extends a Target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual async Task<Response<ChaosCapabilityResource>> GetAsync(string capabilityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.Get");
            scope.Start();
            try
            {
                var response = await _chaosCapabilityCapabilitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ChaosCapabilityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Capability resource that extends a Target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual Response<ChaosCapabilityResource> Get(string capabilityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.Get");
            scope.Start();
            try
            {
                var response = _chaosCapabilityCapabilitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ChaosCapabilityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Capability resources that extend a Target resource..
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ChaosCapabilityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ChaosCapabilityResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosCapabilityCapabilitiesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosCapabilityCapabilitiesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ChaosCapabilityResource(Client, ChaosCapabilityData.DeserializeChaosCapabilityData(e)), _chaosCapabilityCapabilitiesClientDiagnostics, Pipeline, "ChaosCapabilityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Capability resources that extend a Target resource..
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ChaosCapabilityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ChaosCapabilityResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosCapabilityCapabilitiesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosCapabilityCapabilitiesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ChaosCapabilityResource(Client, ChaosCapabilityData.DeserializeChaosCapabilityData(e)), _chaosCapabilityCapabilitiesClientDiagnostics, Pipeline, "ChaosCapabilityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string capabilityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _chaosCapabilityCapabilitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual Response<bool> Exists(string capabilityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.Exists");
            scope.Start();
            try
            {
                var response = _chaosCapabilityCapabilitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual async Task<NullableResponse<ChaosCapabilityResource>> GetIfExistsAsync(string capabilityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _chaosCapabilityCapabilitiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ChaosCapabilityResource>(response.GetRawResponse());
                return Response.FromValue(new ChaosCapabilityResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}/capabilities/{capabilityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Capability_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosCapabilityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityName"> String that represents a Capability resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capabilityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityName"/> is null. </exception>
        public virtual NullableResponse<ChaosCapabilityResource> GetIfExists(string capabilityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(capabilityName, nameof(capabilityName));

            using var scope = _chaosCapabilityCapabilitiesClientDiagnostics.CreateScope("ChaosCapabilityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _chaosCapabilityCapabilitiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, capabilityName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ChaosCapabilityResource>(response.GetRawResponse());
                return Response.FromValue(new ChaosCapabilityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ChaosCapabilityResource> IEnumerable<ChaosCapabilityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ChaosCapabilityResource> IAsyncEnumerable<ChaosCapabilityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
