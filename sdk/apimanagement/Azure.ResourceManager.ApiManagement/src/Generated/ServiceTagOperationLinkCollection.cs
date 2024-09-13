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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceTagOperationLinkResource"/> and their operations.
    /// Each <see cref="ServiceTagOperationLinkResource"/> in the collection will belong to the same instance of <see cref="ApiManagementTagResource"/>.
    /// To get a <see cref="ServiceTagOperationLinkCollection"/> instance call the GetServiceTagOperationLinks method from an instance of <see cref="ApiManagementTagResource"/>.
    /// </summary>
    public partial class ServiceTagOperationLinkCollection : ArmCollection, IEnumerable<ServiceTagOperationLinkResource>, IAsyncEnumerable<ServiceTagOperationLinkResource>
    {
        private readonly ClientDiagnostics _serviceTagOperationLinkTagOperationLinkClientDiagnostics;
        private readonly TagOperationLinkRestOperations _serviceTagOperationLinkTagOperationLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceTagOperationLinkCollection"/> class for mocking. </summary>
        protected ServiceTagOperationLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceTagOperationLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceTagOperationLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceTagOperationLinkTagOperationLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceTagOperationLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceTagOperationLinkResource.ResourceType, out string serviceTagOperationLinkTagOperationLinkApiVersion);
            _serviceTagOperationLinkTagOperationLinkRestClient = new TagOperationLinkRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceTagOperationLinkTagOperationLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementTagResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementTagResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds an operation to the specified tag via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceTagOperationLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string operationLinkId, TagOperationLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceTagOperationLinkTagOperationLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, data, cancellationToken).ConfigureAwait(false);
                var uri = _serviceTagOperationLinkTagOperationLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceTagOperationLinkResource>(Response.FromValue(new ServiceTagOperationLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Adds an operation to the specified tag via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceTagOperationLinkResource> CreateOrUpdate(WaitUntil waitUntil, string operationLinkId, TagOperationLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceTagOperationLinkTagOperationLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, data, cancellationToken);
                var uri = _serviceTagOperationLinkTagOperationLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceTagOperationLinkResource>(Response.FromValue(new ServiceTagOperationLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the operation link for the tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> is null. </exception>
        public virtual async Task<Response<ServiceTagOperationLinkResource>> GetAsync(string operationLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceTagOperationLinkTagOperationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceTagOperationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the operation link for the tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> is null. </exception>
        public virtual Response<ServiceTagOperationLinkResource> Get(string operationLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceTagOperationLinkTagOperationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceTagOperationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of the operation links associated with a tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| operationId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceTagOperationLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceTagOperationLinkResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceTagOperationLinkTagOperationLinkRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceTagOperationLinkTagOperationLinkRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceTagOperationLinkResource(Client, TagOperationLinkContractData.DeserializeTagOperationLinkContractData(e)), _serviceTagOperationLinkTagOperationLinkClientDiagnostics, Pipeline, "ServiceTagOperationLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of the operation links associated with a tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| operationId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceTagOperationLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceTagOperationLinkResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceTagOperationLinkTagOperationLinkRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceTagOperationLinkTagOperationLinkRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceTagOperationLinkResource(Client, TagOperationLinkContractData.DeserializeTagOperationLinkContractData(e)), _serviceTagOperationLinkTagOperationLinkClientDiagnostics, Pipeline, "ServiceTagOperationLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string operationLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceTagOperationLinkTagOperationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> is null. </exception>
        public virtual Response<bool> Exists(string operationLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceTagOperationLinkTagOperationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceTagOperationLinkResource>> GetIfExistsAsync(string operationLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceTagOperationLinkTagOperationLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceTagOperationLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceTagOperationLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/tags/{tagId}/operationLinks/{operationLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TagOperationLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceTagOperationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationLinkId"> Tag-operation link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationLinkId"/> is null. </exception>
        public virtual NullableResponse<ServiceTagOperationLinkResource> GetIfExists(string operationLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationLinkId, nameof(operationLinkId));

            using var scope = _serviceTagOperationLinkTagOperationLinkClientDiagnostics.CreateScope("ServiceTagOperationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceTagOperationLinkTagOperationLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationLinkId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceTagOperationLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceTagOperationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceTagOperationLinkResource> IEnumerable<ServiceTagOperationLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceTagOperationLinkResource> IAsyncEnumerable<ServiceTagOperationLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
