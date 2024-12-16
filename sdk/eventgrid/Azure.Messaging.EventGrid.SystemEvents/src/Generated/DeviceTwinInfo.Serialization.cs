// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceTwinInfo : IUtf8JsonSerializable, IJsonModel<DeviceTwinInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceTwinInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceTwinInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceTwinInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceTwinInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType);
            }
            if (Optional.IsDefined(CloudToDeviceMessageCount))
            {
                writer.WritePropertyName("cloudToDeviceMessageCount"u8);
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(ConnectionState);
            }
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(LastActivityTime))
            {
                writer.WritePropertyName("lastActivityTime"u8);
                writer.WriteStringValue(LastActivityTime);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties, options);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StatusUpdateTime))
            {
                writer.WritePropertyName("statusUpdateTime"u8);
                writer.WriteStringValue(StatusUpdateTime);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            writer.WritePropertyName("x509Thumbprint"u8);
            writer.WriteObjectValue(X509Thumbprint, options);
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

        DeviceTwinInfo IJsonModel<DeviceTwinInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceTwinInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceTwinInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceTwinInfo(document.RootElement, options);
        }

        internal static DeviceTwinInfo DeserializeDeviceTwinInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authenticationType = default;
            float? cloudToDeviceMessageCount = default;
            string connectionState = default;
            string deviceId = default;
            string etag = default;
            string lastActivityTime = default;
            DeviceTwinInfoProperties properties = default;
            string status = default;
            string statusUpdateTime = default;
            float? version = default;
            DeviceTwinInfoX509Thumbprint x509Thumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    connectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    lastActivityTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = DeviceTwinInfoProperties.DeserializeDeviceTwinInfoProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusUpdateTime"u8))
                {
                    statusUpdateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"u8))
                {
                    x509Thumbprint = DeviceTwinInfoX509Thumbprint.DeserializeDeviceTwinInfoX509Thumbprint(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceTwinInfo(
                authenticationType,
                cloudToDeviceMessageCount,
                connectionState,
                deviceId,
                etag,
                lastActivityTime,
                properties,
                status,
                statusUpdateTime,
                version,
                x509Thumbprint,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceTwinInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceTwinInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceTwinInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceTwinInfo IPersistableModel<DeviceTwinInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceTwinInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceTwinInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceTwinInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceTwinInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeviceTwinInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeviceTwinInfo(document.RootElement);
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
