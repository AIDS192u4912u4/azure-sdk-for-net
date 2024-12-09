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
    public partial class MediaLiveEventIncomingStreamReceivedEventData : IUtf8JsonSerializable, IJsonModel<MediaLiveEventIncomingStreamReceivedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaLiveEventIncomingStreamReceivedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaLiveEventIncomingStreamReceivedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaLiveEventIncomingStreamReceivedEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IngestUrl))
            {
                writer.WritePropertyName("ingestUrl"u8);
                writer.WriteStringValue(IngestUrl);
            }
            if (Optional.IsDefined(TrackType))
            {
                writer.WritePropertyName("trackType"u8);
                writer.WriteStringValue(TrackType);
            }
            if (Optional.IsDefined(TrackName))
            {
                writer.WritePropertyName("trackName"u8);
                writer.WriteStringValue(TrackName);
            }
            if (Optional.IsDefined(Bitrate))
            {
                writer.WritePropertyName("bitrate"u8);
                writer.WriteNumberValue(Bitrate.Value);
            }
            if (Optional.IsDefined(EncoderIp))
            {
                writer.WritePropertyName("encoderIp"u8);
                writer.WriteStringValue(EncoderIp);
            }
            if (Optional.IsDefined(EncoderPort))
            {
                writer.WritePropertyName("encoderPort"u8);
                writer.WriteStringValue(EncoderPort);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(Timescale))
            {
                writer.WritePropertyName("timescale"u8);
                writer.WriteStringValue(Timescale);
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

        MediaLiveEventIncomingStreamReceivedEventData IJsonModel<MediaLiveEventIncomingStreamReceivedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaLiveEventIncomingStreamReceivedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventIncomingStreamReceivedEventData(document.RootElement, options);
        }

        internal static MediaLiveEventIncomingStreamReceivedEventData DeserializeMediaLiveEventIncomingStreamReceivedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ingestUrl = default;
            string trackType = default;
            string trackName = default;
            long? bitrate = default;
            string encoderIp = default;
            string encoderPort = default;
            string timestamp = default;
            string duration = default;
            string timescale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"u8))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackType"u8))
                {
                    trackType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackName"u8))
                {
                    trackName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitrate = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("encoderIp"u8))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"u8))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescale"u8))
                {
                    timescale = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MediaLiveEventIncomingStreamReceivedEventData(
                ingestUrl,
                trackType,
                trackName,
                bitrate,
                encoderIp,
                encoderPort,
                timestamp,
                duration,
                timescale,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaLiveEventIncomingStreamReceivedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MediaLiveEventIncomingStreamReceivedEventData IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaLiveEventIncomingStreamReceivedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaLiveEventIncomingStreamReceivedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaLiveEventIncomingStreamReceivedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MediaLiveEventIncomingStreamReceivedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMediaLiveEventIncomingStreamReceivedEventData(document.RootElement);
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
