// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FhirR4ObservationReferenceRange : IUtf8JsonSerializable, IJsonModel<FhirR4ObservationReferenceRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4ObservationReferenceRange>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FhirR4ObservationReferenceRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4ObservationReferenceRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4ObservationReferenceRange)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Low))
            {
                writer.WritePropertyName("low"u8);
                writer.WriteObjectValue(Low, options);
            }
            if (Optional.IsDefined(High))
            {
                writer.WritePropertyName("high"u8);
                writer.WriteObjectValue(High, options);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteObjectValue(Type, options);
            }
            if (Optional.IsCollectionDefined(AppliesTo))
            {
                writer.WritePropertyName("appliesTo"u8);
                writer.WriteStartArray();
                foreach (var item in AppliesTo)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Age))
            {
                writer.WritePropertyName("age"u8);
                writer.WriteObjectValue(Age, options);
            }
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
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

        FhirR4ObservationReferenceRange IJsonModel<FhirR4ObservationReferenceRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4ObservationReferenceRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4ObservationReferenceRange)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4ObservationReferenceRange(document.RootElement, options);
        }

        internal static FhirR4ObservationReferenceRange DeserializeFhirR4ObservationReferenceRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4Quantity low = default;
            FhirR4Quantity high = default;
            FhirR4CodeableConcept type = default;
            IReadOnlyList<FhirR4CodeableConcept> appliesTo = default;
            FhirR4Range age = default;
            string text = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("low"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    low = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("high"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    high = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("appliesTo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4CodeableConcept> array = new List<FhirR4CodeableConcept>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(item, options));
                    }
                    appliesTo = array;
                    continue;
                }
                if (property.NameEquals("age"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    age = FhirR4Range.DeserializeFhirR4Range(property.Value, options);
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FhirR4ObservationReferenceRange(
                low,
                high,
                type,
                appliesTo ?? new ChangeTrackingList<FhirR4CodeableConcept>(),
                age,
                text,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FhirR4ObservationReferenceRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4ObservationReferenceRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4ObservationReferenceRange)} does not support writing '{options.Format}' format.");
            }
        }

        FhirR4ObservationReferenceRange IPersistableModel<FhirR4ObservationReferenceRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4ObservationReferenceRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirR4ObservationReferenceRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4ObservationReferenceRange)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4ObservationReferenceRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FhirR4ObservationReferenceRange FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFhirR4ObservationReferenceRange(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
