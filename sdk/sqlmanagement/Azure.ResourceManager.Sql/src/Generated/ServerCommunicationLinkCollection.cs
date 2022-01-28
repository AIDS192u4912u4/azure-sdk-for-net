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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerCommunicationLink and their operations over its parent. </summary>
    public partial class ServerCommunicationLinkCollection : ArmCollection, IEnumerable<ServerCommunicationLink>, IAsyncEnumerable<ServerCommunicationLink>
    {
        private readonly ClientDiagnostics _serverCommunicationLinkClientDiagnostics;
        private readonly ServerCommunicationLinksRestOperations _serverCommunicationLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerCommunicationLinkCollection"/> class for mocking. </summary>
        protected ServerCommunicationLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerCommunicationLinkCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerCommunicationLinkCollection(ArmResource parent) : base(parent)
        {
            _serverCommunicationLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerCommunicationLink.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ServerCommunicationLink.ResourceType, out string serverCommunicationLinkApiVersion);
            _serverCommunicationLinkRestClient = new ServerCommunicationLinksRestOperations(_serverCommunicationLinkClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverCommunicationLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_CreateOrUpdate
        /// <summary> Creates a server communication link. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServerCommunicationLinkCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string communicationLinkName, ServerCommunicationLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters, cancellationToken);
                var operation = new ServerCommunicationLinkCreateOrUpdateOperation(ArmClient, _serverCommunicationLinkClientDiagnostics, Pipeline, _serverCommunicationLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_CreateOrUpdate
        /// <summary> Creates a server communication link. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="parameters"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerCommunicationLinkCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string communicationLinkName, ServerCommunicationLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerCommunicationLinkCreateOrUpdateOperation(ArmClient, _serverCommunicationLinkClientDiagnostics, Pipeline, _serverCommunicationLinkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_Get
        /// <summary> Returns a server communication link. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<ServerCommunicationLink> Get(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken);
                if (response.Value == null)
                    throw _serverCommunicationLinkClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_Get
        /// <summary> Returns a server communication link. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public async virtual Task<Response<ServerCommunicationLink>> GetAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverCommunicationLinkClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerCommunicationLink(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<ServerCommunicationLink> GetIfExists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverCommunicationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerCommunicationLink>(null, response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public async virtual Task<Response<ServerCommunicationLink>> GetIfExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverCommunicationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerCommunicationLink>(null, response.GetRawResponse());
                return Response.FromValue(new ServerCommunicationLink(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(communicationLinkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_ListByServer
        /// <summary> Gets a list of server communication links. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerCommunicationLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerCommunicationLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerCommunicationLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverCommunicationLinkRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerCommunicationLink(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerCommunicationLinks_ListByServer
        /// <summary> Gets a list of server communication links. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerCommunicationLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerCommunicationLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerCommunicationLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverCommunicationLinkClientDiagnostics.CreateScope("ServerCommunicationLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverCommunicationLinkRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerCommunicationLink(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<ServerCommunicationLink> IEnumerable<ServerCommunicationLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerCommunicationLink> IAsyncEnumerable<ServerCommunicationLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
