// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterHttpProxyConfig : IUtf8JsonSerializable, IJsonModel<ManagedClusterHttpProxyConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterHttpProxyConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterHttpProxyConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HttpProxy))
            {
                writer.WritePropertyName("httpProxy"u8);
                writer.WriteStringValue(HttpProxy);
            }
            if (Optional.IsDefined(HttpsProxy))
            {
                writer.WritePropertyName("httpsProxy"u8);
                writer.WriteStringValue(HttpsProxy);
            }
            if (Optional.IsCollectionDefined(NoProxy))
            {
                writer.WritePropertyName("noProxy"u8);
                writer.WriteStartArray();
                foreach (var item in NoProxy)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedCA))
            {
                writer.WritePropertyName("trustedCa"u8);
                writer.WriteStringValue(TrustedCA);
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

        ManagedClusterHttpProxyConfig IJsonModel<ManagedClusterHttpProxyConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterHttpProxyConfig(document.RootElement, options);
        }

        internal static ManagedClusterHttpProxyConfig DeserializeManagedClusterHttpProxyConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string httpProxy = default;
            string httpsProxy = default;
            IList<string> noProxy = default;
            string trustedCA = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpProxy"u8))
                {
                    httpProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsProxy"u8))
                {
                    httpsProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("noProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    noProxy = array;
                    continue;
                }
                if (property.NameEquals("trustedCa"u8))
                {
                    trustedCA = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterHttpProxyConfig(httpProxy, httpsProxy, noProxy ?? new ChangeTrackingList<string>(), trustedCA, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpProxy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  httpProxy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpProxy))
                {
                    builder.Append("  httpProxy: ");
                    if (HttpProxy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HttpProxy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HttpProxy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpsProxy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  httpsProxy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpsProxy))
                {
                    builder.Append("  httpsProxy: ");
                    if (HttpsProxy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HttpsProxy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HttpsProxy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NoProxy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  noProxy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NoProxy))
                {
                    if (NoProxy.Any())
                    {
                        builder.Append("  noProxy: ");
                        builder.AppendLine("[");
                        foreach (var item in NoProxy)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrustedCA), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trustedCa: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TrustedCA))
                {
                    builder.Append("  trustedCa: ");
                    if (TrustedCA.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TrustedCA}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TrustedCA}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterHttpProxyConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterHttpProxyConfig IPersistableModel<ManagedClusterHttpProxyConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterHttpProxyConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterHttpProxyConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
