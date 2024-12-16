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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBSqlClientEncryptionKeyResource"/> and their operations.
    /// Each <see cref="CosmosDBSqlClientEncryptionKeyResource"/> in the collection will belong to the same instance of <see cref="CosmosDBSqlDatabaseResource"/>.
    /// To get a <see cref="CosmosDBSqlClientEncryptionKeyCollection"/> instance call the GetCosmosDBSqlClientEncryptionKeys method from an instance of <see cref="CosmosDBSqlDatabaseResource"/>.
    /// </summary>
    public partial class CosmosDBSqlClientEncryptionKeyCollection : ArmCollection, IEnumerable<CosmosDBSqlClientEncryptionKeyResource>, IAsyncEnumerable<CosmosDBSqlClientEncryptionKeyResource>
    {
        private readonly ClientDiagnostics _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlClientEncryptionKeyCollection"/> class for mocking. </summary>
        protected CosmosDBSqlClientEncryptionKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlClientEncryptionKeyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBSqlClientEncryptionKeyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBSqlClientEncryptionKeyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBSqlClientEncryptionKeyResource.ResourceType, out string cosmosDBSqlClientEncryptionKeySqlResourcesApiVersion);
            _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlClientEncryptionKeySqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBSqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBSqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a ClientEncryptionKey. This API is meant to be invoked via tools such as the Azure Powershell (instead of directly).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="content"> The parameters to provide for the client encryption key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlClientEncryptionKeyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clientEncryptionKeyName, CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateUpdateClientEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlClientEncryptionKeyResource>(new CosmosDBSqlClientEncryptionKeyOperationSource(Client), _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateCreateUpdateClientEncryptionKeyRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a ClientEncryptionKey. This API is meant to be invoked via tools such as the Azure Powershell (instead of directly).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="content"> The parameters to provide for the client encryption key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlClientEncryptionKeyResource> CreateOrUpdate(WaitUntil waitUntil, string clientEncryptionKeyName, CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateUpdateClientEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlClientEncryptionKeyResource>(new CosmosDBSqlClientEncryptionKeyOperationSource(Client), _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateCreateUpdateClientEncryptionKeyRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the ClientEncryptionKey under an existing Azure Cosmos DB SQL database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBSqlClientEncryptionKeyResource>> GetAsync(string clientEncryptionKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlClientEncryptionKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ClientEncryptionKey under an existing Azure Cosmos DB SQL database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> is null. </exception>
        public virtual Response<CosmosDBSqlClientEncryptionKeyResource> Get(string clientEncryptionKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlClientEncryptionKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the ClientEncryptionKeys under an existing Azure Cosmos DB SQL database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListClientEncryptionKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBSqlClientEncryptionKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBSqlClientEncryptionKeyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateListClientEncryptionKeysRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBSqlClientEncryptionKeyResource(Client, CosmosDBSqlClientEncryptionKeyData.DeserializeCosmosDBSqlClientEncryptionKeyData(e)), _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlClientEncryptionKeyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the ClientEncryptionKeys under an existing Azure Cosmos DB SQL database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListClientEncryptionKeys</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBSqlClientEncryptionKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBSqlClientEncryptionKeyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.CreateListClientEncryptionKeysRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBSqlClientEncryptionKeyResource(Client, CosmosDBSqlClientEncryptionKeyData.DeserializeCosmosDBSqlClientEncryptionKeyData(e)), _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlClientEncryptionKeyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clientEncryptionKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> is null. </exception>
        public virtual Response<bool> Exists(string clientEncryptionKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBSqlClientEncryptionKeyResource>> GetIfExistsAsync(string clientEncryptionKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlClientEncryptionKeyResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlClientEncryptionKeyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/clientEncryptionKeys/{clientEncryptionKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetClientEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBSqlClientEncryptionKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientEncryptionKeyName"> Cosmos DB ClientEncryptionKey name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clientEncryptionKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clientEncryptionKeyName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBSqlClientEncryptionKeyResource> GetIfExists(string clientEncryptionKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clientEncryptionKeyName, nameof(clientEncryptionKeyName));

            using var scope = _cosmosDBSqlClientEncryptionKeySqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlClientEncryptionKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlClientEncryptionKeySqlResourcesRestClient.GetClientEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientEncryptionKeyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlClientEncryptionKeyResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlClientEncryptionKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBSqlClientEncryptionKeyResource> IEnumerable<CosmosDBSqlClientEncryptionKeyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBSqlClientEncryptionKeyResource> IAsyncEnumerable<CosmosDBSqlClientEncryptionKeyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
