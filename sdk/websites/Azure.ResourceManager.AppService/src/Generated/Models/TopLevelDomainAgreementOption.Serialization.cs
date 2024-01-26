// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TopLevelDomainAgreementOption : IUtf8JsonSerializable, IJsonModel<TopLevelDomainAgreementOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TopLevelDomainAgreementOption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TopLevelDomainAgreementOption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopLevelDomainAgreementOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopLevelDomainAgreementOption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IncludePrivacy))
            {
                writer.WritePropertyName("includePrivacy"u8);
                writer.WriteBooleanValue(IncludePrivacy.Value);
            }
            if (Optional.IsDefined(IsForTransfer))
            {
                writer.WritePropertyName("forTransfer"u8);
                writer.WriteBooleanValue(IsForTransfer.Value);
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

        TopLevelDomainAgreementOption IJsonModel<TopLevelDomainAgreementOption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopLevelDomainAgreementOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TopLevelDomainAgreementOption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTopLevelDomainAgreementOption(document.RootElement, options);
        }

        internal static TopLevelDomainAgreementOption DeserializeTopLevelDomainAgreementOption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> includePrivacy = default;
            Optional<bool> forTransfer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includePrivacy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includePrivacy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("forTransfer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forTransfer = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TopLevelDomainAgreementOption(Optional.ToNullable(includePrivacy), Optional.ToNullable(forTransfer), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TopLevelDomainAgreementOption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopLevelDomainAgreementOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TopLevelDomainAgreementOption)} does not support '{options.Format}' format.");
            }
        }

        TopLevelDomainAgreementOption IPersistableModel<TopLevelDomainAgreementOption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TopLevelDomainAgreementOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTopLevelDomainAgreementOption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TopLevelDomainAgreementOption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TopLevelDomainAgreementOption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
