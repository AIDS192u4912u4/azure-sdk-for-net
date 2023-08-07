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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseSqlPoolSecurityAlertPolicyResource" /> and their operations.
    /// Each <see cref="SynapseSqlPoolSecurityAlertPolicyResource" /> in the collection will belong to the same instance of <see cref="SynapseSqlPoolResource" />.
    /// To get a <see cref="SynapseSqlPoolSecurityAlertPolicyCollection" /> instance call the GetSynapseSqlPoolSecurityAlertPolicies method from an instance of <see cref="SynapseSqlPoolResource" />.
    /// </summary>
    public partial class SynapseSqlPoolSecurityAlertPolicyCollection : ArmCollection, IEnumerable<SynapseSqlPoolSecurityAlertPolicyResource>, IAsyncEnumerable<SynapseSqlPoolSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics;
        private readonly SqlPoolSecurityAlertPoliciesRestOperations _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected SynapseSqlPoolSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSqlPoolSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSqlPoolSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSqlPoolSecurityAlertPolicyResource.ResourceType, out string synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesApiVersion);
            _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient = new SqlPoolSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Sql pool's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The Sql pool security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseSqlPoolSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlPoolSecurityAlertPolicyName securityAlertPolicyName, SynapseSqlPoolSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseSqlPoolSecurityAlertPolicyResource>(Response.FromValue(new SynapseSqlPoolSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Sql pool's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The Sql pool security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseSqlPoolSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SqlPoolSecurityAlertPolicyName securityAlertPolicyName, SynapseSqlPoolSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseSqlPoolSecurityAlertPolicyResource>(Response.FromValue(new SynapseSqlPoolSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get a Sql pool's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseSqlPoolSecurityAlertPolicyResource>> GetAsync(SqlPoolSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Sql pool's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseSqlPoolSecurityAlertPolicyResource> Get(SqlPoolSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Sql pool's security alert policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseSqlPoolSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseSqlPoolSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseSqlPoolSecurityAlertPolicyResource(Client, SynapseSqlPoolSecurityAlertPolicyData.DeserializeSynapseSqlPoolSecurityAlertPolicyData(e)), _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics, Pipeline, "SynapseSqlPoolSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Sql pool's security alert policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseSqlPoolSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseSqlPoolSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseSqlPoolSecurityAlertPolicyResource(Client, SynapseSqlPoolSecurityAlertPolicyData.DeserializeSynapseSqlPoolSecurityAlertPolicyData(e)), _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics, Pipeline, "SynapseSqlPoolSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlPoolSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlPoolSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSecurityAlertPolicySqlPoolSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseSqlPoolSecurityAlertPolicyResource> IEnumerable<SynapseSqlPoolSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseSqlPoolSecurityAlertPolicyResource> IAsyncEnumerable<SynapseSqlPoolSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
