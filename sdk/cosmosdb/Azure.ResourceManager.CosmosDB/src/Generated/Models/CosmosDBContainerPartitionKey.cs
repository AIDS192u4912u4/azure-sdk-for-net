// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The configuration of the partition key to be used for partitioning data into multiple partitions. </summary>
    public partial class CosmosDBContainerPartitionKey
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBContainerPartitionKey"/>. </summary>
        public CosmosDBContainerPartitionKey()
        {
            Paths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBContainerPartitionKey"/>. </summary>
        /// <param name="paths"> List of paths using which data within the container can be partitioned. </param>
        /// <param name="kind"> Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum) are supported for container create. </param>
        /// <param name="version"> Indicates the version of the partition key definition. </param>
        /// <param name="isSystemKey"> Indicates if the container is using a system generated partition key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBContainerPartitionKey(IList<string> paths, CosmosDBPartitionKind? kind, int? version, bool? isSystemKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Paths = paths;
            Kind = kind;
            Version = version;
            IsSystemKey = isSystemKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of paths using which data within the container can be partitioned. </summary>
        public IList<string> Paths { get; }
        /// <summary> Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum) are supported for container create. </summary>
        public CosmosDBPartitionKind? Kind { get; set; }
        /// <summary> Indicates the version of the partition key definition. </summary>
        public int? Version { get; set; }
        /// <summary> Indicates if the container is using a system generated partition key. </summary>
        public bool? IsSystemKey { get; }
    }
}
