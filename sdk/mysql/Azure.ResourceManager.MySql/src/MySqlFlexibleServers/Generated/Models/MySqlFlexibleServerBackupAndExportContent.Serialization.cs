// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerBackupAndExportContent : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerBackupAndExportContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerBackupAndExportContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MySqlFlexibleServerBackupAndExportContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("targetDetails"u8);
            writer.WriteObjectValue(TargetDetails, options);
        }

        MySqlFlexibleServerBackupAndExportContent IJsonModel<MySqlFlexibleServerBackupAndExportContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerBackupAndExportContent(document.RootElement, options);
        }

        internal static MySqlFlexibleServerBackupAndExportContent DeserializeMySqlFlexibleServerBackupAndExportContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlFlexibleServerBackupStoreDetails targetDetails = default;
            MySqlFlexibleServerBackupSettings backupSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDetails"u8))
                {
                    targetDetails = MySqlFlexibleServerBackupStoreDetails.DeserializeMySqlFlexibleServerBackupStoreDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("backupSettings"u8))
                {
                    backupSettings = MySqlFlexibleServerBackupSettings.DeserializeMySqlFlexibleServerBackupSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MySqlFlexibleServerBackupAndExportContent(backupSettings, serializedAdditionalRawData, targetDetails);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerBackupAndExportContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerBackupAndExportContent IPersistableModel<MySqlFlexibleServerBackupAndExportContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerBackupAndExportContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerBackupAndExportContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
