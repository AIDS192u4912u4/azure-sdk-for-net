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
    public partial class StatusCodesBasedTrigger : IUtf8JsonSerializable, IJsonModel<StatusCodesBasedTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatusCodesBasedTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StatusCodesBasedTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatusCodesBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatusCodesBasedTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteNumberValue(Status.Value);
            }
            if (Optional.IsDefined(SubStatus))
            {
                writer.WritePropertyName("subStatus"u8);
                writer.WriteNumberValue(SubStatus.Value);
            }
            if (Optional.IsDefined(Win32Status))
            {
                writer.WritePropertyName("win32Status"u8);
                writer.WriteNumberValue(Win32Status.Value);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(TimeInterval))
            {
                writer.WritePropertyName("timeInterval"u8);
                writer.WriteStringValue(TimeInterval);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
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

        StatusCodesBasedTrigger IJsonModel<StatusCodesBasedTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatusCodesBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatusCodesBasedTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatusCodesBasedTrigger(document.RootElement, options);
        }

        internal static StatusCodesBasedTrigger DeserializeStatusCodesBasedTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> status = default;
            Optional<int> subStatus = default;
            Optional<int> win32Status = default;
            Optional<int> count = default;
            Optional<string> timeInterval = default;
            Optional<string> path = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subStatus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("win32Status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    win32Status = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeInterval"u8))
                {
                    timeInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatusCodesBasedTrigger(Optional.ToNullable(status), Optional.ToNullable(subStatus), Optional.ToNullable(win32Status), Optional.ToNullable(count), timeInterval.Value, path.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StatusCodesBasedTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatusCodesBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StatusCodesBasedTrigger)} does not support '{options.Format}' format.");
            }
        }

        StatusCodesBasedTrigger IPersistableModel<StatusCodesBasedTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatusCodesBasedTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStatusCodesBasedTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StatusCodesBasedTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StatusCodesBasedTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
