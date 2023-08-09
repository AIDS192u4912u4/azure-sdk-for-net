// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class DataBoxEdgeResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeResourceGroupMockingExtension"/> class for mocking. </summary>
        protected DataBoxEdgeResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataBoxEdgeResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DataBoxEdgeDeviceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataBoxEdgeDeviceResources and their operations over a DataBoxEdgeDeviceResource. </returns>
        public virtual DataBoxEdgeDeviceCollection GetDataBoxEdgeDevices()
        {
            return GetCachedClient(Client => new DataBoxEdgeDeviceCollection(Client, Id));
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataBoxEdgeDeviceResource>> GetDataBoxEdgeDeviceAsync(string deviceName, CancellationToken cancellationToken = default)
        {
            return await GetDataBoxEdgeDevices().GetAsync(deviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevice(string deviceName, CancellationToken cancellationToken = default)
        {
            return GetDataBoxEdgeDevices().Get(deviceName, cancellationToken);
        }
    }
}
