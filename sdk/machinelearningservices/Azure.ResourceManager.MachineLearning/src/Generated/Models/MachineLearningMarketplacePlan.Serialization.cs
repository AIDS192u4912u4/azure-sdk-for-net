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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningMarketplacePlan : IUtf8JsonSerializable, IJsonModel<MachineLearningMarketplacePlan>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningMarketplacePlan>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningMarketplacePlan>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningMarketplacePlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningMarketplacePlan)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PublisherId))
            {
                if (PublisherId != null)
                {
                    writer.WritePropertyName("publisherId"u8);
                    writer.WriteStringValue(PublisherId);
                }
                else
                {
                    writer.WriteNull("publisherId");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(OfferId))
            {
                if (OfferId != null)
                {
                    writer.WritePropertyName("offerId"u8);
                    writer.WriteStringValue(OfferId);
                }
                else
                {
                    writer.WriteNull("offerId");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(PlanId))
            {
                if (PlanId != null)
                {
                    writer.WritePropertyName("planId"u8);
                    writer.WriteStringValue(PlanId);
                }
                else
                {
                    writer.WriteNull("planId");
                }
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

        MachineLearningMarketplacePlan IJsonModel<MachineLearningMarketplacePlan>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningMarketplacePlan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningMarketplacePlan)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningMarketplacePlan(document.RootElement, options);
        }

        internal static MachineLearningMarketplacePlan DeserializeMachineLearningMarketplacePlan(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publisherId = default;
            string offerId = default;
            string planId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        publisherId = null;
                        continue;
                    }
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        offerId = null;
                        continue;
                    }
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        planId = null;
                        continue;
                    }
                    planId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningMarketplacePlan(publisherId, offerId, planId, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublisherId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publisherId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublisherId))
                {
                    builder.Append("  publisherId: ");
                    if (PublisherId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PublisherId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PublisherId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OfferId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  offerId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OfferId))
                {
                    builder.Append("  offerId: ");
                    if (OfferId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OfferId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OfferId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PlanId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  planId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PlanId))
                {
                    builder.Append("  planId: ");
                    if (PlanId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PlanId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PlanId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningMarketplacePlan>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningMarketplacePlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningMarketplacePlan)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningMarketplacePlan IPersistableModel<MachineLearningMarketplacePlan>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningMarketplacePlan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningMarketplacePlan(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningMarketplacePlan)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningMarketplacePlan>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
