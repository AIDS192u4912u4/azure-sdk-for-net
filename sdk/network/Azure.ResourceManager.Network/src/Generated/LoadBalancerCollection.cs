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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of LoadBalancer and their operations over its parent. </summary>
    public partial class LoadBalancerCollection : ArmCollection, IEnumerable<LoadBalancer>, IAsyncEnumerable<LoadBalancer>
    {
        private readonly ClientDiagnostics _loadBalancerClientDiagnostics;
        private readonly LoadBalancersRestOperations _loadBalancerRestClient;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancerCollection"/> class for mocking. </summary>
        protected LoadBalancerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancerCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal LoadBalancerCollection(ArmResource parent) : base(parent)
        {
            _loadBalancerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", LoadBalancer.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(LoadBalancer.ResourceType, out string loadBalancerApiVersion);
            _loadBalancerRestClient = new LoadBalancersRestOperations(_loadBalancerClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, loadBalancerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a load balancer. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual LoadBalancerCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string loadBalancerName, LoadBalancerData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, parameters, cancellationToken);
                var operation = new LoadBalancerCreateOrUpdateOperation(ArmClient, _loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, parameters).Request, response);
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

        /// <summary> Creates or updates a load balancer. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<LoadBalancerCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string loadBalancerName, LoadBalancerData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new LoadBalancerCreateOrUpdateOperation(ArmClient, _loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, parameters).Request, response);
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

        /// <summary> Gets the specified load balancer. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual Response<LoadBalancer> Get(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, expand, cancellationToken);
                if (response.Value == null)
                    throw _loadBalancerClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancer(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> GetAsync(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _loadBalancerClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual Response<LoadBalancer> GetIfExists(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<LoadBalancer>(null, response.GetRawResponse());
                return Response.FromValue(new LoadBalancer(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> GetIfExistsAsync(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, loadBalancerName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<LoadBalancer>(null, response.GetRawResponse());
                return Response.FromValue(new LoadBalancer(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual Response<bool> Exists(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(loadBalancerName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(loadBalancerName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadBalancer> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LoadBalancer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the load balancers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadBalancer> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LoadBalancer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="LoadBalancer" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LoadBalancer.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="LoadBalancer" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LoadBalancer.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LoadBalancer> IEnumerable<LoadBalancer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadBalancer> IAsyncEnumerable<LoadBalancer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
