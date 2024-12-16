// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicAppServicesGetContent : IUtf8JsonSerializable, IJsonModel<NewRelicAppServicesGetContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicAppServicesGetContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicAppServicesGetContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicAppServicesGetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicAppServicesGetContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AzureResourceIds))
            {
                writer.WritePropertyName("azureResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in AzureResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("userEmail"u8);
            writer.WriteStringValue(UserEmail);
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

        NewRelicAppServicesGetContent IJsonModel<NewRelicAppServicesGetContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicAppServicesGetContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicAppServicesGetContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicAppServicesGetContent(document.RootElement, options);
        }

        internal static NewRelicAppServicesGetContent DeserializeNewRelicAppServicesGetContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> azureResourceIds = default;
            string userEmail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureResourceIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    azureResourceIds = array;
                    continue;
                }
                if (property.NameEquals("userEmail"u8))
                {
                    userEmail = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicAppServicesGetContent(azureResourceIds ?? new ChangeTrackingList<ResourceIdentifier>(), userEmail, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicAppServicesGetContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicAppServicesGetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicAppServicesGetContent)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicAppServicesGetContent IPersistableModel<NewRelicAppServicesGetContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicAppServicesGetContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicAppServicesGetContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicAppServicesGetContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicAppServicesGetContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
