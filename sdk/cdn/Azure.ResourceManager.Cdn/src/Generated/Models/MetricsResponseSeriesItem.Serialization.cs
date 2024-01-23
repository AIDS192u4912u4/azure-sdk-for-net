// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class MetricsResponseSeriesItem : IUtf8JsonSerializable, IJsonModel<MetricsResponseSeriesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricsResponseSeriesItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MetricsResponseSeriesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricsResponseSeriesItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteObjectValue(item);
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
            writer.WriteEndObject();
        }

        MetricsResponseSeriesItem IJsonModel<MetricsResponseSeriesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricsResponseSeriesItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricsResponseSeriesItem(document.RootElement, options);
        }

        internal static MetricsResponseSeriesItem DeserializeMetricsResponseSeriesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metric = default;
            Optional<MetricsResponseSeriesItemUnit> unit = default;
            Optional<IReadOnlyList<MetricsResponseSeriesPropertiesItemsItem>> groups = default;
            Optional<IReadOnlyList<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new MetricsResponseSeriesItemUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsResponseSeriesPropertiesItemsItem> array = new List<MetricsResponseSeriesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsResponseSeriesPropertiesItemsItem.DeserializeMetricsResponseSeriesPropertiesItemsItem(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems> array = new List<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems.DeserializeComponents1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems(item));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricsResponseSeriesItem(metric.Value, Optional.ToNullable(unit), Optional.ToList(groups), Optional.ToList(data), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricsResponseSeriesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricsResponseSeriesItem)} does not support '{options.Format}' format.");
            }
        }

        MetricsResponseSeriesItem IPersistableModel<MetricsResponseSeriesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricsResponseSeriesItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricsResponseSeriesItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricsResponseSeriesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
