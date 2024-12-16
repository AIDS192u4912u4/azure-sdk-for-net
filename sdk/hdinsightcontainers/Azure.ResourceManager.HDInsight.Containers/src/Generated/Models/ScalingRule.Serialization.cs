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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ScalingRule : IUtf8JsonSerializable, IJsonModel<ScalingRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScalingRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScalingRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingRule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("evaluationCount"u8);
            writer.WriteNumberValue(EvaluationCount);
            writer.WritePropertyName("scalingMetric"u8);
            writer.WriteStringValue(ScalingMetric);
            writer.WritePropertyName("comparisonRule"u8);
            writer.WriteObjectValue(ComparisonRule, options);
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

        ScalingRule IJsonModel<ScalingRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingRule(document.RootElement, options);
        }

        internal static ScalingRule DeserializeScalingRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScaleActionType actionType = default;
            int evaluationCount = default;
            string scalingMetric = default;
            HDInsightComparisonRule comparisonRule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ScaleActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evaluationCount"u8))
                {
                    evaluationCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scalingMetric"u8))
                {
                    scalingMetric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("comparisonRule"u8))
                {
                    comparisonRule = HDInsightComparisonRule.DeserializeHDInsightComparisonRule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScalingRule(actionType, evaluationCount, scalingMetric, comparisonRule, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  actionType: ");
                builder.AppendLine($"'{ActionType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EvaluationCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  evaluationCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  evaluationCount: ");
                builder.AppendLine($"{EvaluationCount}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScalingMetric), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scalingMetric: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScalingMetric))
                {
                    builder.Append("  scalingMetric: ");
                    if (ScalingMetric.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ScalingMetric}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ScalingMetric}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComparisonRule), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  comparisonRule: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComparisonRule))
                {
                    builder.Append("  comparisonRule: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ComparisonRule, options, 2, false, "  comparisonRule: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ScalingRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ScalingRule)} does not support writing '{options.Format}' format.");
            }
        }

        ScalingRule IPersistableModel<ScalingRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScalingRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScalingRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScalingRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
