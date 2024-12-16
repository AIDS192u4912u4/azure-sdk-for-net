// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountBusinessIdentity : IUtf8JsonSerializable, IJsonModel<IntegrationAccountBusinessIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountBusinessIdentity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationAccountBusinessIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBusinessIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountBusinessIdentity)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("qualifier"u8);
            writer.WriteStringValue(Qualifier);
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
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

        IntegrationAccountBusinessIdentity IJsonModel<IntegrationAccountBusinessIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBusinessIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountBusinessIdentity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountBusinessIdentity(document.RootElement, options);
        }

        internal static IntegrationAccountBusinessIdentity DeserializeIntegrationAccountBusinessIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string qualifier = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qualifier"u8))
                {
                    qualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationAccountBusinessIdentity(qualifier, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationAccountBusinessIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBusinessIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountBusinessIdentity)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationAccountBusinessIdentity IPersistableModel<IntegrationAccountBusinessIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountBusinessIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountBusinessIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountBusinessIdentity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountBusinessIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
