// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBShardKeySetting : IUtf8JsonSerializable, IJsonModel<MongoDBShardKeySetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBShardKeySetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBShardKeySetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBShardKeySetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBShardKeySetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fields"u8);
            writer.WriteStartArray();
            foreach (var item in Fields)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(IsUnique))
            {
                writer.WritePropertyName("isUnique"u8);
                writer.WriteBooleanValue(IsUnique.Value);
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

        MongoDBShardKeySetting IJsonModel<MongoDBShardKeySetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBShardKeySetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBShardKeySetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBShardKeySetting(document.RootElement, options);
        }

        internal static MongoDBShardKeySetting DeserializeMongoDBShardKeySetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MongoDBShardKeyField> fields = default;
            Optional<bool> isUnique = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fields"u8))
                {
                    List<MongoDBShardKeyField> array = new List<MongoDBShardKeyField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBShardKeyField.DeserializeMongoDBShardKeyField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("isUnique"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isUnique = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBShardKeySetting(fields, Optional.ToNullable(isUnique), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBShardKeySetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBShardKeySetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBShardKeySetting)} does not support '{options.Format}' format.");
            }
        }

        MongoDBShardKeySetting IPersistableModel<MongoDBShardKeySetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBShardKeySetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBShardKeySetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBShardKeySetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBShardKeySetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
