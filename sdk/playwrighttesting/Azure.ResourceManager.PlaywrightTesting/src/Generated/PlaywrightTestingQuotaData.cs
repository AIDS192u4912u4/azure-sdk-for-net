// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PlaywrightTesting.Models;

namespace Azure.ResourceManager.PlaywrightTesting
{
    /// <summary>
    /// A class representing the PlaywrightTestingQuota data model.
    /// A quota resource
    /// </summary>
    public partial class PlaywrightTestingQuotaData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PlaywrightTestingQuotaData"/>. </summary>
        public PlaywrightTestingQuotaData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PlaywrightTestingQuotaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="freeTrial"> The free-trial quota. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PlaywrightTestingQuotaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, FreeTrialProperties freeTrial, PlaywrightTestingProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            FreeTrial = freeTrial;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The free-trial quota. </summary>
        public FreeTrialProperties FreeTrial { get; set; }
        /// <summary> The status of the last operation. </summary>
        public PlaywrightTestingProvisioningState? ProvisioningState { get; }
    }
}
