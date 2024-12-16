// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class InformationProtectionKeyword : IUtf8JsonSerializable, IJsonModel<InformationProtectionKeyword>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformationProtectionKeyword>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InformationProtectionKeyword>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformationProtectionKeyword>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformationProtectionKeyword)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(Custom))
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteBooleanValue(Custom.Value);
            }
            if (Optional.IsDefined(CanBeNumeric))
            {
                writer.WritePropertyName("canBeNumeric"u8);
                writer.WriteBooleanValue(CanBeNumeric.Value);
            }
            if (Optional.IsDefined(Excluded))
            {
                writer.WritePropertyName("excluded"u8);
                writer.WriteBooleanValue(Excluded.Value);
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

        InformationProtectionKeyword IJsonModel<InformationProtectionKeyword>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformationProtectionKeyword>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformationProtectionKeyword)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformationProtectionKeyword(document.RootElement, options);
        }

        internal static InformationProtectionKeyword DeserializeInformationProtectionKeyword(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pattern = default;
            bool? custom = default;
            bool? canBeNumeric = default;
            bool? excluded = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pattern"u8))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("canBeNumeric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canBeNumeric = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("excluded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excluded = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InformationProtectionKeyword(pattern, custom, canBeNumeric, excluded, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InformationProtectionKeyword>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformationProtectionKeyword>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InformationProtectionKeyword)} does not support writing '{options.Format}' format.");
            }
        }

        InformationProtectionKeyword IPersistableModel<InformationProtectionKeyword>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformationProtectionKeyword>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInformationProtectionKeyword(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InformationProtectionKeyword)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InformationProtectionKeyword>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
