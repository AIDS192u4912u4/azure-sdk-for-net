// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServicePlanVirtualNetworkConnectionGatewayResource" /> and their operations.
    /// Each <see cref="AppServicePlanVirtualNetworkConnectionGatewayResource" /> in the collection will belong to the same instance of <see cref="AppServicePlanVirtualNetworkConnectionResource" />.
    /// To get an <see cref="AppServicePlanVirtualNetworkConnectionGatewayCollection" /> instance call the GetAppServicePlanVirtualNetworkConnectionGateways method from an instance of <see cref="AppServicePlanVirtualNetworkConnectionResource" />.
    /// </summary>
    public partial class AppServicePlanVirtualNetworkConnectionGatewayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanVirtualNetworkConnectionGatewayCollection"/> class for mocking. </summary>
        protected AppServicePlanVirtualNetworkConnectionGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanVirtualNetworkConnectionGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServicePlanVirtualNetworkConnectionGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServicePlanVirtualNetworkConnectionGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServicePlanVirtualNetworkConnectionGatewayResource.ResourceType, out string appServicePlanVirtualNetworkConnectionGatewayAppServicePlansApiVersion);
            _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServicePlanVirtualNetworkConnectionGatewayAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServicePlanVirtualNetworkConnectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServicePlanVirtualNetworkConnectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Update a Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_UpdateVnetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> Name of the gateway. Only the 'primary' gateway is supported. </param>
        /// <param name="data"> Definition of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServicePlanVirtualNetworkConnectionGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gatewayName, AppServiceVirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient.UpdateVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServicePlanVirtualNetworkConnectionGatewayResource>(Response.FromValue(new AppServicePlanVirtualNetworkConnectionGatewayResource(Client, response), response.GetRawResponse()));
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
        /// Description for Update a Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_UpdateVnetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> Name of the gateway. Only the 'primary' gateway is supported. </param>
        /// <param name="data"> Definition of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServicePlanVirtualNetworkConnectionGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string gatewayName, AppServiceVirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient.UpdateVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServicePlanVirtualNetworkConnectionGatewayResource>(Response.FromValue(new AppServicePlanVirtualNetworkConnectionGatewayResource(Client, response), response.GetRawResponse()));
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
        /// Description for Get a Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetVnetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the 'primary' gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<AppServicePlanVirtualNetworkConnectionGatewayResource>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServicePlanVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetVnetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the 'primary' gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<AppServicePlanVirtualNetworkConnectionGatewayResource> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServicePlanVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetVnetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the 'primary' gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServicePlans_GetVnetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the 'primary' gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
