// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class TrafficAnalyticsProperties : IUtf8JsonSerializable, IJsonModel<TrafficAnalyticsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficAnalyticsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrafficAnalyticsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficAnalyticsProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TrafficAnalyticsConfiguration))
            {
                writer.WritePropertyName("networkWatcherFlowAnalyticsConfiguration"u8);
                writer.WriteObjectValue(TrafficAnalyticsConfiguration, options);
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

        TrafficAnalyticsProperties IJsonModel<TrafficAnalyticsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficAnalyticsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficAnalyticsProperties(document.RootElement, options);
        }

        internal static TrafficAnalyticsProperties DeserializeTrafficAnalyticsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrafficAnalyticsConfigurationProperties networkWatcherFlowAnalyticsConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkWatcherFlowAnalyticsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkWatcherFlowAnalyticsConfiguration = TrafficAnalyticsConfigurationProperties.DeserializeTrafficAnalyticsConfigurationProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TrafficAnalyticsProperties(networkWatcherFlowAnalyticsConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrafficAnalyticsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficAnalyticsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        TrafficAnalyticsProperties IPersistableModel<TrafficAnalyticsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficAnalyticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficAnalyticsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficAnalyticsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficAnalyticsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
