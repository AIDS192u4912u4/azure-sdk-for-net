// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm
{
    public partial class ScVmmHybridIdentityMetadataData : IUtf8JsonSerializable, IJsonModel<ScVmmHybridIdentityMetadataData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScVmmHybridIdentityMetadataData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScVmmHybridIdentityMetadataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHybridIdentityMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmHybridIdentityMetadataData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceUid))
            {
                writer.WritePropertyName("resourceUid"u8);
                writer.WriteStringValue(ResourceUid);
            }
            if (Optional.IsDefined(PublicKey))
            {
                writer.WritePropertyName("publicKey"u8);
                writer.WriteStringValue(PublicKey);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ScVmmHybridIdentityMetadataData IJsonModel<ScVmmHybridIdentityMetadataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHybridIdentityMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmHybridIdentityMetadataData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScVmmHybridIdentityMetadataData(document.RootElement, options);
        }

        internal static ScVmmHybridIdentityMetadataData DeserializeScVmmHybridIdentityMetadataData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string resourceUid = default;
            string publicKey = default;
            ScVmmProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceUid"u8))
                        {
                            resourceUid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicKey"u8))
                        {
                            publicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ScVmmProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScVmmHybridIdentityMetadataData(
                id,
                name,
                type,
                systemData,
                resourceUid,
                publicKey,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScVmmHybridIdentityMetadataData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHybridIdentityMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScVmmHybridIdentityMetadataData)} does not support writing '{options.Format}' format.");
            }
        }

        ScVmmHybridIdentityMetadataData IPersistableModel<ScVmmHybridIdentityMetadataData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHybridIdentityMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScVmmHybridIdentityMetadataData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScVmmHybridIdentityMetadataData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScVmmHybridIdentityMetadataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
