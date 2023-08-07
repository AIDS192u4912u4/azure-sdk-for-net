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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="EventGridNamespaceClientResource" /> and their operations.
    /// Each <see cref="EventGridNamespaceClientResource" /> in the collection will belong to the same instance of <see cref="EventGridNamespaceResource" />.
    /// To get an <see cref="EventGridNamespaceClientCollection" /> instance call the GetEventGridNamespaceClients method from an instance of <see cref="EventGridNamespaceResource" />.
    /// </summary>
    public partial class EventGridNamespaceClientCollection : ArmCollection, IEnumerable<EventGridNamespaceClientResource>, IAsyncEnumerable<EventGridNamespaceClientResource>
    {
        private readonly ClientDiagnostics _eventGridNamespaceClientClientsClientDiagnostics;
        private readonly ClientsRestOperations _eventGridNamespaceClientClientsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespaceClientCollection"/> class for mocking. </summary>
        protected EventGridNamespaceClientCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridNamespaceClientCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventGridNamespaceClientCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventGridNamespaceClientClientsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", EventGridNamespaceClientResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventGridNamespaceClientResource.ResourceType, out string eventGridNamespaceClientClientsApiVersion);
            _eventGridNamespaceClientClientsRestClient = new ClientsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventGridNamespaceClientClientsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a client with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients/{clientName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clientName"> The client name. </param>
        /// <param name="data"> Client information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridNamespaceClientResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clientName, EventGridNamespaceClientData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientName, nameof(clientName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespaceClientClientsClientDiagnostics.CreateScope("EventGridNamespaceClientCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventGridNamespaceClientClientsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridNamespaceClientResource>(new EventGridNamespaceClientOperationSource(Client), _eventGridNamespaceClientClientsClientDiagnostics, Pipeline, _eventGridNamespaceClientClientsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a client with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients/{clientName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clientName"> The client name. </param>
        /// <param name="data"> Client information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridNamespaceClientResource> CreateOrUpdate(WaitUntil waitUntil, string clientName, EventGridNamespaceClientData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientName, nameof(clientName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridNamespaceClientClientsClientDiagnostics.CreateScope("EventGridNamespaceClientCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventGridNamespaceClientClientsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridNamespaceClientResource>(new EventGridNamespaceClientOperationSource(Client), _eventGridNamespaceClientClientsClientDiagnostics, Pipeline, _eventGridNamespaceClientClientsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a client.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients/{clientName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> Name of the client. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        public virtual async Task<Response<EventGridNamespaceClientResource>> GetAsync(string clientName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientName, nameof(clientName));

            using var scope = _eventGridNamespaceClientClientsClientDiagnostics.CreateScope("EventGridNamespaceClientCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventGridNamespaceClientClientsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespaceClientResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a client.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients/{clientName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> Name of the client. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        public virtual Response<EventGridNamespaceClientResource> Get(string clientName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientName, nameof(clientName));

            using var scope = _eventGridNamespaceClientClientsClientDiagnostics.CreateScope("EventGridNamespaceClientCollection.Get");
            scope.Start();
            try
            {
                var response = _eventGridNamespaceClientClientsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridNamespaceClientResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the permission bindings under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventGridNamespaceClientResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventGridNamespaceClientResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridNamespaceClientClientsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridNamespaceClientClientsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventGridNamespaceClientResource(Client, EventGridNamespaceClientData.DeserializeEventGridNamespaceClientData(e)), _eventGridNamespaceClientClientsClientDiagnostics, Pipeline, "EventGridNamespaceClientCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the permission bindings under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventGridNamespaceClientResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventGridNamespaceClientResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridNamespaceClientClientsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridNamespaceClientClientsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventGridNamespaceClientResource(Client, EventGridNamespaceClientData.DeserializeEventGridNamespaceClientData(e)), _eventGridNamespaceClientClientsClientDiagnostics, Pipeline, "EventGridNamespaceClientCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients/{clientName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> Name of the client. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clientName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientName, nameof(clientName));

            using var scope = _eventGridNamespaceClientClientsClientDiagnostics.CreateScope("EventGridNamespaceClientCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventGridNamespaceClientClientsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/clients/{clientName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clients_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientName"> Name of the client. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientName"/> is null. </exception>
        public virtual Response<bool> Exists(string clientName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientName, nameof(clientName));

            using var scope = _eventGridNamespaceClientClientsClientDiagnostics.CreateScope("EventGridNamespaceClientCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventGridNamespaceClientClientsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventGridNamespaceClientResource> IEnumerable<EventGridNamespaceClientResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventGridNamespaceClientResource> IAsyncEnumerable<EventGridNamespaceClientResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
