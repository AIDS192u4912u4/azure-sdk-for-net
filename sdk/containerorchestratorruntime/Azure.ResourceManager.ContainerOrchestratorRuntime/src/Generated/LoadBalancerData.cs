// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerOrchestratorRuntime.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    /// <summary>
    /// A class representing the LoadBalancer data model.
    /// A LoadBalancer resource for an Arc connected cluster (Microsoft.Kubernetes/connectedClusters)
    /// </summary>
    public partial class LoadBalancerData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LoadBalancerData"/>. </summary>
        public LoadBalancerData()
        {
            Addresses = new ChangeTrackingList<string>();
            ServiceSelector = new ChangeTrackingDictionary<string, string>();
            BgpPeers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="addresses"> IP Range. </param>
        /// <param name="serviceSelector"> A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services with label "a=b", then please specify {"a": "b"} in the field. </param>
        /// <param name="advertiseMode"> Advertise Mode. </param>
        /// <param name="bgpPeers"> The list of BGP peers it should advertise to. Null or empty means to advertise to all peers. </param>
        /// <param name="provisioningState"> Resource provision state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadBalancerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<string> addresses, IDictionary<string, string> serviceSelector, AdvertiseMode? advertiseMode, IList<string> bgpPeers, ContainerOrchestratorProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Addresses = addresses;
            ServiceSelector = serviceSelector;
            AdvertiseMode = advertiseMode;
            BgpPeers = bgpPeers;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP Range. </summary>
        public IList<string> Addresses { get; }
        /// <summary> A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services with label "a=b", then please specify {"a": "b"} in the field. </summary>
        public IDictionary<string, string> ServiceSelector { get; }
        /// <summary> Advertise Mode. </summary>
        public AdvertiseMode? AdvertiseMode { get; set; }
        /// <summary> The list of BGP peers it should advertise to. Null or empty means to advertise to all peers. </summary>
        public IList<string> BgpPeers { get; }
        /// <summary> Resource provision state. </summary>
        public ContainerOrchestratorProvisioningState? ProvisioningState { get; }
    }
}
