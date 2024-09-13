// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Properties of the dedicated hsm. </summary>
    public partial class DedicatedHsmProperties
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

        /// <summary> Initializes a new instance of <see cref="DedicatedHsmProperties"/>. </summary>
        public DedicatedHsmProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHsmProperties"/>. </summary>
        /// <param name="networkProfile"> Specifies the network interfaces of the dedicated hsm. </param>
        /// <param name="managementNetworkProfile"> Specifies the management network interfaces of the dedicated hsm. </param>
        /// <param name="stampId"> This field will be used when RP does not support Availability zones. </param>
        /// <param name="statusMessage"> Resource Status Message. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedHsmProperties(DedicatedHsmNetworkProfile networkProfile, DedicatedHsmNetworkProfile managementNetworkProfile, string stampId, string statusMessage, DedicatedHsmJsonWebKeyType? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkProfile = networkProfile;
            ManagementNetworkProfile = managementNetworkProfile;
            StampId = stampId;
            StatusMessage = statusMessage;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the network interfaces of the dedicated hsm. </summary>
        [WirePath("networkProfile")]
        public DedicatedHsmNetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the management network interfaces of the dedicated hsm. </summary>
        [WirePath("managementNetworkProfile")]
        public DedicatedHsmNetworkProfile ManagementNetworkProfile { get; set; }
        /// <summary> This field will be used when RP does not support Availability zones. </summary>
        [WirePath("stampId")]
        public string StampId { get; set; }
        /// <summary> Resource Status Message. </summary>
        [WirePath("statusMessage")]
        public string StatusMessage { get; }
        /// <summary> Provisioning state. </summary>
        [WirePath("provisioningState")]
        public DedicatedHsmJsonWebKeyType? ProvisioningState { get; }
    }
}
