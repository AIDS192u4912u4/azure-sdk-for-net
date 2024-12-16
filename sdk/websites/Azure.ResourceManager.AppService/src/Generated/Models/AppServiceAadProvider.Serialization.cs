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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAadProvider : IUtf8JsonSerializable, IJsonModel<AppServiceAadProvider>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceAadProvider>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppServiceAadProvider>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration"u8);
                writer.WriteObjectValue(Registration, options);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login, options);
            }
            if (Optional.IsDefined(Validation))
            {
                writer.WritePropertyName("validation"u8);
                writer.WriteObjectValue(Validation, options);
            }
            if (Optional.IsDefined(IsAutoProvisioned))
            {
                writer.WritePropertyName("isAutoProvisioned"u8);
                writer.WriteBooleanValue(IsAutoProvisioned.Value);
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

        AppServiceAadProvider IJsonModel<AppServiceAadProvider>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceAadProvider(document.RootElement, options);
        }

        internal static AppServiceAadProvider DeserializeAppServiceAadProvider(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            AppServiceAadRegistration registration = default;
            AppServiceAadLoginFlow login = default;
            AppServiceAadValidation validation = default;
            bool? isAutoProvisioned = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registration = AppServiceAadRegistration.DeserializeAppServiceAadRegistration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    login = AppServiceAadLoginFlow.DeserializeAppServiceAadLoginFlow(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validation = AppServiceAadValidation.DeserializeAppServiceAadValidation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isAutoProvisioned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProvisioned = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppServiceAadProvider(
                enabled,
                registration,
                login,
                validation,
                isAutoProvisioned,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("  enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Registration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Registration))
                {
                    builder.Append("  registration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Registration, options, 2, false, "  registration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Login), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  login: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Login))
                {
                    builder.Append("  login: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Login, options, 2, false, "  login: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Validation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  validation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Validation))
                {
                    builder.Append("  validation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Validation, options, 2, false, "  validation: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAutoProvisioned), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isAutoProvisioned: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAutoProvisioned))
                {
                    builder.Append("  isAutoProvisioned: ");
                    var boolValue = IsAutoProvisioned.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppServiceAadProvider>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support writing '{options.Format}' format.");
            }
        }

        AppServiceAadProvider IPersistableModel<AppServiceAadProvider>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceAadProvider>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceAadProvider(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceAadProvider)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceAadProvider>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
