// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Contains the IPTag associated with the object. </summary>
    public partial class ContainerServiceIPTag
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceIPTag"/>. </summary>
        public ContainerServiceIPTag()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceIPTag"/>. </summary>
        /// <param name="ipTagType"> The IP tag type. Example: RoutingPreference. </param>
        /// <param name="tag"> The value of the IP tag associated with the public IP. Example: Internet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceIPTag(string ipTagType, string tag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPTagType = ipTagType;
            Tag = tag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IP tag type. Example: RoutingPreference. </summary>
        [WirePath("ipTagType")]
        public string IPTagType { get; set; }
        /// <summary> The value of the IP tag associated with the public IP. Example: Internet. </summary>
        [WirePath("tag")]
        public string Tag { get; set; }
    }
}
