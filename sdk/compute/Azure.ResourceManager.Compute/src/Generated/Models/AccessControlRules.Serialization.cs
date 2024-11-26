// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class AccessControlRules : IUtf8JsonSerializable, IJsonModel<AccessControlRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessControlRules>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AccessControlRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlRules)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Privileges))
            {
                writer.WritePropertyName("privileges"u8);
                writer.WriteStartArray();
                foreach (var item in Privileges)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Roles))
            {
                writer.WritePropertyName("roles"u8);
                writer.WriteStartArray();
                foreach (var item in Roles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Identities))
            {
                writer.WritePropertyName("identities"u8);
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RoleAssignments))
            {
                writer.WritePropertyName("roleAssignments"u8);
                writer.WriteStartArray();
                foreach (var item in RoleAssignments)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AccessControlRules IJsonModel<AccessControlRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlRules)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessControlRules(document.RootElement, options);
        }

        internal static AccessControlRules DeserializeAccessControlRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AccessControlRulesPrivilege> privileges = default;
            IList<AccessControlRulesRole> roles = default;
            IList<AccessControlRulesIdentity> identities = default;
            IList<AccessControlRulesRoleAssignment> roleAssignments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privileges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessControlRulesPrivilege> array = new List<AccessControlRulesPrivilege>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlRulesPrivilege.DeserializeAccessControlRulesPrivilege(item, options));
                    }
                    privileges = array;
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessControlRulesRole> array = new List<AccessControlRulesRole>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlRulesRole.DeserializeAccessControlRulesRole(item, options));
                    }
                    roles = array;
                    continue;
                }
                if (property.NameEquals("identities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessControlRulesIdentity> array = new List<AccessControlRulesIdentity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlRulesIdentity.DeserializeAccessControlRulesIdentity(item, options));
                    }
                    identities = array;
                    continue;
                }
                if (property.NameEquals("roleAssignments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessControlRulesRoleAssignment> array = new List<AccessControlRulesRoleAssignment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlRulesRoleAssignment.DeserializeAccessControlRulesRoleAssignment(item, options));
                    }
                    roleAssignments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AccessControlRules(privileges ?? new ChangeTrackingList<AccessControlRulesPrivilege>(), roles ?? new ChangeTrackingList<AccessControlRulesRole>(), identities ?? new ChangeTrackingList<AccessControlRulesIdentity>(), roleAssignments ?? new ChangeTrackingList<AccessControlRulesRoleAssignment>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessControlRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessControlRules)} does not support writing '{options.Format}' format.");
            }
        }

        AccessControlRules IPersistableModel<AccessControlRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessControlRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessControlRules)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessControlRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
