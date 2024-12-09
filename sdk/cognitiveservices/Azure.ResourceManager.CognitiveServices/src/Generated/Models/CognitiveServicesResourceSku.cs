// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account resource sku resource properties. </summary>
    public partial class CognitiveServicesResourceSku
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesResourceSku"/>. </summary>
        internal CognitiveServicesResourceSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesResourceSku"/>. </summary>
        /// <param name="resourceType"> The resource type name. </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="capacity"> The capacity configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesResourceSku(string resourceType, CognitiveServicesSku sku, CognitiveServicesCapacityConfig capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource type name. </summary>
        [WirePath("resourceType")]
        public string ResourceType { get; }
        /// <summary> The resource model definition representing SKU. </summary>
        [WirePath("sku")]
        public CognitiveServicesSku Sku { get; }
        /// <summary> The capacity configuration. </summary>
        [WirePath("capacity")]
        public CognitiveServicesCapacityConfig Capacity { get; }
    }
}
