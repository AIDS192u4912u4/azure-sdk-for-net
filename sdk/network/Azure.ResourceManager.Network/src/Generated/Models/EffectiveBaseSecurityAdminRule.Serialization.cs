// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    [PersistableModelProxy(typeof(UnknownEffectiveBaseSecurityAdminRule))]
    public partial class EffectiveBaseSecurityAdminRule : IUtf8JsonSerializable, IJsonModel<EffectiveBaseSecurityAdminRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EffectiveBaseSecurityAdminRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EffectiveBaseSecurityAdminRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveBaseSecurityAdminRule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ConfigurationDescription))
            {
                writer.WritePropertyName("configurationDescription"u8);
                writer.WriteStringValue(ConfigurationDescription);
            }
            if (Optional.IsDefined(RuleCollectionDescription))
            {
                writer.WritePropertyName("ruleCollectionDescription"u8);
                writer.WriteStringValue(RuleCollectionDescription);
            }
            if (Optional.IsCollectionDefined(RuleCollectionAppliesToGroups))
            {
                writer.WritePropertyName("ruleCollectionAppliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionAppliesToGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        EffectiveBaseSecurityAdminRule IJsonModel<EffectiveBaseSecurityAdminRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EffectiveBaseSecurityAdminRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveBaseSecurityAdminRule(document.RootElement, options);
        }

        internal static EffectiveBaseSecurityAdminRule DeserializeEffectiveBaseSecurityAdminRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return EffectiveSecurityAdminRule.DeserializeEffectiveSecurityAdminRule(element, options);
                    case "Default": return EffectiveDefaultSecurityAdminRule.DeserializeEffectiveDefaultSecurityAdminRule(element, options);
                }
            }
            return UnknownEffectiveBaseSecurityAdminRule.DeserializeUnknownEffectiveBaseSecurityAdminRule(element, options);
        }

        BinaryData IPersistableModel<EffectiveBaseSecurityAdminRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EffectiveBaseSecurityAdminRule)} does not support writing '{options.Format}' format.");
            }
        }

        EffectiveBaseSecurityAdminRule IPersistableModel<EffectiveBaseSecurityAdminRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EffectiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEffectiveBaseSecurityAdminRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EffectiveBaseSecurityAdminRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EffectiveBaseSecurityAdminRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
