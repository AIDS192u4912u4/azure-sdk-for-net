// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class NetworkSecurityPerimeterProvisioningIssueProperties : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterProvisioningIssueProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterProvisioningIssueProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityPerimeterProvisioningIssueProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProvisioningIssueProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IssueType))
            {
                writer.WritePropertyName("issueType"u8);
                writer.WriteStringValue(IssueType.Value.ToString());
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        NetworkSecurityPerimeterProvisioningIssueProperties IJsonModel<NetworkSecurityPerimeterProvisioningIssueProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProvisioningIssueProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterProvisioningIssueProperties(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterProvisioningIssueProperties DeserializeNetworkSecurityPerimeterProvisioningIssueProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkSecurityPerimeterProvisioningIssueType? issueType = default;
            NetworkSecurityPerimeterProvisioningIssueSeverity? severity = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issueType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issueType = new NetworkSecurityPerimeterProvisioningIssueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new NetworkSecurityPerimeterProvisioningIssueSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkSecurityPerimeterProvisioningIssueProperties(issueType, severity, description, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IssueType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  issueType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IssueType))
                {
                    builder.Append("  issueType: ");
                    builder.AppendLine($"'{IssueType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Severity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  severity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Severity))
                {
                    builder.Append("  severity: ");
                    builder.AppendLine($"'{Severity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProvisioningIssueProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterProvisioningIssueProperties IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSecurityPerimeterProvisioningIssueProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterProvisioningIssueProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterProvisioningIssueProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
