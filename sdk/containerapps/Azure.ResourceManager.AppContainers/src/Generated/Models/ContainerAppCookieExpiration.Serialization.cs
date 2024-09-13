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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCookieExpiration : IUtf8JsonSerializable, IJsonModel<ContainerAppCookieExpiration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppCookieExpiration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppCookieExpiration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCookieExpiration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCookieExpiration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Convention))
            {
                writer.WritePropertyName("convention"u8);
                writer.WriteStringValue(Convention.Value.ToSerialString());
            }
            if (Optional.IsDefined(TimeToExpiration))
            {
                writer.WritePropertyName("timeToExpiration"u8);
                writer.WriteStringValue(TimeToExpiration);
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

        ContainerAppCookieExpiration IJsonModel<ContainerAppCookieExpiration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCookieExpiration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCookieExpiration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCookieExpiration(document.RootElement, options);
        }

        internal static ContainerAppCookieExpiration DeserializeContainerAppCookieExpiration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerAppCookieExpirationConvention? convention = default;
            string timeToExpiration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("convention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    convention = property.Value.GetString().ToContainerAppCookieExpirationConvention();
                    continue;
                }
                if (property.NameEquals("timeToExpiration"u8))
                {
                    timeToExpiration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppCookieExpiration(convention, timeToExpiration, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Convention), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  convention: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Convention))
                {
                    builder.Append("  convention: ");
                    builder.AppendLine($"'{Convention.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeToExpiration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeToExpiration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeToExpiration))
                {
                    builder.Append("  timeToExpiration: ");
                    if (TimeToExpiration.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TimeToExpiration}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TimeToExpiration}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppCookieExpiration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCookieExpiration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCookieExpiration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppCookieExpiration IPersistableModel<ContainerAppCookieExpiration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCookieExpiration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppCookieExpiration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCookieExpiration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppCookieExpiration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
