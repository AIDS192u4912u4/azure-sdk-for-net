// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootSiteErrorSummaryModel : IUtf8JsonSerializable, IJsonModel<SpringBootSiteErrorSummaryModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootSiteErrorSummaryModel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SpringBootSiteErrorSummaryModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteErrorSummaryModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteErrorSummaryModel)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AffectedResourceType))
            {
                writer.WritePropertyName("affectedResourceType"u8);
                writer.WriteStringValue(AffectedResourceType);
            }
            if (Optional.IsDefined(AffectedObjectsCount))
            {
                writer.WritePropertyName("affectedObjectsCount"u8);
                writer.WriteNumberValue(AffectedObjectsCount.Value);
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

        SpringBootSiteErrorSummaryModel IJsonModel<SpringBootSiteErrorSummaryModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteErrorSummaryModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteErrorSummaryModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootSiteErrorSummaryModel(document.RootElement, options);
        }

        internal static SpringBootSiteErrorSummaryModel DeserializeSpringBootSiteErrorSummaryModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string affectedResourceType = default;
            long? affectedObjectsCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("affectedResourceType"u8))
                {
                    affectedResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    affectedObjectsCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SpringBootSiteErrorSummaryModel(affectedResourceType, affectedObjectsCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpringBootSiteErrorSummaryModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteErrorSummaryModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteErrorSummaryModel)} does not support writing '{options.Format}' format.");
            }
        }

        SpringBootSiteErrorSummaryModel IPersistableModel<SpringBootSiteErrorSummaryModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteErrorSummaryModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSpringBootSiteErrorSummaryModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteErrorSummaryModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootSiteErrorSummaryModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
