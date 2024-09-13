// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> An properties abstract Query item for entity. </summary>
    public partial class EntityQueryItemProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EntityQueryItemProperties"/>. </summary>
        internal EntityQueryItemProperties()
        {
            DataTypes = new ChangeTrackingList<EntityQueryItemPropertiesDataTypesItem>();
            RequiredInputFieldsSets = new ChangeTrackingList<IList<string>>();
        }

        /// <summary> Initializes a new instance of <see cref="EntityQueryItemProperties"/>. </summary>
        /// <param name="dataTypes"> Data types for template. </param>
        /// <param name="inputEntityType"> The type of the entity. </param>
        /// <param name="requiredInputFieldsSets"> Data types for template. </param>
        /// <param name="entitiesFilter"> The query applied only to entities matching to all filters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityQueryItemProperties(IReadOnlyList<EntityQueryItemPropertiesDataTypesItem> dataTypes, SecurityInsightsEntityType? inputEntityType, IReadOnlyList<IList<string>> requiredInputFieldsSets, BinaryData entitiesFilter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataTypes = dataTypes;
            InputEntityType = inputEntityType;
            RequiredInputFieldsSets = requiredInputFieldsSets;
            EntitiesFilter = entitiesFilter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Data types for template. </summary>
        [WirePath("dataTypes")]
        public IReadOnlyList<EntityQueryItemPropertiesDataTypesItem> DataTypes { get; }
        /// <summary> The type of the entity. </summary>
        [WirePath("inputEntityType")]
        public SecurityInsightsEntityType? InputEntityType { get; }
        /// <summary> Data types for template. </summary>
        [WirePath("requiredInputFieldsSets")]
        public IReadOnlyList<IList<string>> RequiredInputFieldsSets { get; }
        /// <summary>
        /// The query applied only to entities matching to all filters
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("entitiesFilter")]
        public BinaryData EntitiesFilter { get; }
    }
}
