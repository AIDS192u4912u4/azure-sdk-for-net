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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of CassandraTable and their operations over its parent. </summary>
    public partial class CassandraTableCollection : ArmCollection, IEnumerable<CassandraTable>, IAsyncEnumerable<CassandraTable>
    {
        private readonly ClientDiagnostics _cassandraTableCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _cassandraTableCassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraTableCollection"/> class for mocking. </summary>
        protected CassandraTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CassandraTableCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CassandraTableCollection(ArmResource parent) : base(parent)
        {
            _cassandraTableCassandraResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CassandraTable.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(CassandraTable.ResourceType, out string cassandraTableCassandraResourcesApiVersion);
            _cassandraTableCassandraResourcesRestClient = new CassandraResourcesRestOperations(_cassandraTableCassandraResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cassandraTableCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CassandraKeyspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CassandraKeyspace.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB Cassandra Table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateCassandraTableParameters"> The parameters to provide for the current Cassandra Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateCassandraTableParameters"/> is null. </exception>
        public virtual CassandraTableCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string tableName, CassandraTableCreateUpdateOptions createUpdateCassandraTableParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            if (createUpdateCassandraTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateCassandraTableParameters));
            }

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraTableCassandraResourcesRestClient.CreateUpdateCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters, cancellationToken);
                var operation = new CassandraTableCreateOrUpdateOperation(ArmClient, _cassandraTableCassandraResourcesClientDiagnostics, Pipeline, _cassandraTableCassandraResourcesRestClient.CreateCreateUpdateCassandraTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB Cassandra Table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateCassandraTableParameters"> The parameters to provide for the current Cassandra Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateCassandraTableParameters"/> is null. </exception>
        public async virtual Task<CassandraTableCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string tableName, CassandraTableCreateUpdateOptions createUpdateCassandraTableParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            if (createUpdateCassandraTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateCassandraTableParameters));
            }

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraTableCassandraResourcesRestClient.CreateUpdateCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CassandraTableCreateOrUpdateOperation(ArmClient, _cassandraTableCassandraResourcesClientDiagnostics, Pipeline, _cassandraTableCassandraResourcesRestClient.CreateCreateUpdateCassandraTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, createUpdateCassandraTableParameters).Request, response);
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

        /// <summary> Gets the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CassandraTable> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraTableCassandraResourcesRestClient.GetCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw _cassandraTableCassandraResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<CassandraTable>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraTableCassandraResourcesRestClient.GetCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _cassandraTableCassandraResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CassandraTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CassandraTable> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cassandraTableCassandraResourcesRestClient.GetCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CassandraTable>(null, response.GetRawResponse());
                return Response.FromValue(new CassandraTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<CassandraTable>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cassandraTableCassandraResourcesRestClient.GetCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CassandraTable>(null, response.GetRawResponse());
                return Response.FromValue(new CassandraTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraTable> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CassandraTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cassandraTableCassandraResourcesRestClient.ListCassandraTables(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraTable(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the Cassandra table under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraTable> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CassandraTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cassandraTableCassandraResourcesRestClient.ListCassandraTablesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraTable(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<CassandraTable> IEnumerable<CassandraTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraTable> IAsyncEnumerable<CassandraTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
