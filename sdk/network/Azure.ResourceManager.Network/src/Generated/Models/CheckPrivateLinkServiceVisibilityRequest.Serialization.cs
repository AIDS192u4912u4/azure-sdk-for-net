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
    public partial class CheckPrivateLinkServiceVisibilityRequest : IUtf8JsonSerializable, IJsonModel<CheckPrivateLinkServiceVisibilityRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckPrivateLinkServiceVisibilityRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CheckPrivateLinkServiceVisibilityRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckPrivateLinkServiceVisibilityRequest)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PrivateLinkServiceAlias))
            {
                writer.WritePropertyName("privateLinkServiceAlias"u8);
                writer.WriteStringValue(PrivateLinkServiceAlias);
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

        CheckPrivateLinkServiceVisibilityRequest IJsonModel<CheckPrivateLinkServiceVisibilityRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckPrivateLinkServiceVisibilityRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckPrivateLinkServiceVisibilityRequest(document.RootElement, options);
        }

        internal static CheckPrivateLinkServiceVisibilityRequest DeserializeCheckPrivateLinkServiceVisibilityRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string privateLinkServiceAlias = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkServiceAlias"u8))
                {
                    privateLinkServiceAlias = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CheckPrivateLinkServiceVisibilityRequest(privateLinkServiceAlias, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckPrivateLinkServiceVisibilityRequest)} does not support writing '{options.Format}' format.");
            }
        }

        CheckPrivateLinkServiceVisibilityRequest IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckPrivateLinkServiceVisibilityRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckPrivateLinkServiceVisibilityRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckPrivateLinkServiceVisibilityRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
