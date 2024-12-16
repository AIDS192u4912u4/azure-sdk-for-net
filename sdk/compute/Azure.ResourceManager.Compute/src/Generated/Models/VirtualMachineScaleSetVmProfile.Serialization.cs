// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetVmProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetVmProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetVmProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineScaleSetVmProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetVmProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetVmProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile, options);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile, options);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile, options);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile, options);
            }
            if (Optional.IsDefined(DiagnosticsProfile))
            {
                writer.WritePropertyName("diagnosticsProfile"u8);
                writer.WriteObjectValue(DiagnosticsProfile, options);
            }
            if (Optional.IsDefined(ExtensionProfile))
            {
                writer.WritePropertyName("extensionProfile"u8);
                writer.WriteObjectValue(ExtensionProfile, options);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteStringValue(Priority.Value.ToString());
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy"u8);
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(BillingProfile))
            {
                writer.WritePropertyName("billingProfile"u8);
                writer.WriteObjectValue(BillingProfile, options);
            }
            if (Optional.IsDefined(ScheduledEventsProfile))
            {
                writer.WritePropertyName("scheduledEventsProfile"u8);
                writer.WriteObjectValue(ScheduledEventsProfile, options);
            }
            if (Optional.IsDefined(UserData))
            {
                writer.WritePropertyName("userData"u8);
                writer.WriteStringValue(UserData);
            }
            if (Optional.IsDefined(CapacityReservation))
            {
                writer.WritePropertyName("capacityReservation"u8);
                writer.WriteObjectValue(CapacityReservation, options);
            }
            if (Optional.IsDefined(ApplicationProfile))
            {
                writer.WritePropertyName("applicationProfile"u8);
                writer.WriteObjectValue(ApplicationProfile, options);
            }
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile, options);
            }
            if (Optional.IsDefined(ServiceArtifactReference))
            {
                writer.WritePropertyName("serviceArtifactReference"u8);
                JsonSerializer.Serialize(writer, ServiceArtifactReference);
            }
            if (Optional.IsDefined(SecurityPostureReference))
            {
                writer.WritePropertyName("securityPostureReference"u8);
                writer.WriteObjectValue(SecurityPostureReference, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
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

        VirtualMachineScaleSetVmProfile IJsonModel<VirtualMachineScaleSetVmProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetVmProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetVmProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetVmProfile(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetVmProfile DeserializeVirtualMachineScaleSetVmProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualMachineScaleSetOSProfile osProfile = default;
            VirtualMachineScaleSetStorageProfile storageProfile = default;
            VirtualMachineScaleSetNetworkProfile networkProfile = default;
            SecurityProfile securityProfile = default;
            DiagnosticsProfile diagnosticsProfile = default;
            VirtualMachineScaleSetExtensionProfile extensionProfile = default;
            string licenseType = default;
            VirtualMachinePriorityType? priority = default;
            VirtualMachineEvictionPolicyType? evictionPolicy = default;
            BillingProfile billingProfile = default;
            ComputeScheduledEventsProfile scheduledEventsProfile = default;
            string userData = default;
            CapacityReservationProfile capacityReservation = default;
            ApplicationProfile applicationProfile = default;
            VirtualMachineScaleSetHardwareProfile hardwareProfile = default;
            WritableSubResource serviceArtifactReference = default;
            ComputeSecurityPostureReference securityPostureReference = default;
            DateTimeOffset? timeCreated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = VirtualMachineScaleSetOSProfile.DeserializeVirtualMachineScaleSetOSProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = VirtualMachineScaleSetStorageProfile.DeserializeVirtualMachineScaleSetStorageProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = VirtualMachineScaleSetNetworkProfile.DeserializeVirtualMachineScaleSetNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityProfile = SecurityProfile.DeserializeSecurityProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diagnosticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticsProfile = DiagnosticsProfile.DeserializeDiagnosticsProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extensionProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionProfile = VirtualMachineScaleSetExtensionProfile.DeserializeVirtualMachineScaleSetExtensionProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = new VirtualMachinePriorityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evictionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evictionPolicy = new VirtualMachineEvictionPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfile = BillingProfile.DeserializeBillingProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scheduledEventsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledEventsProfile = ComputeScheduledEventsProfile.DeserializeComputeScheduledEventsProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userData"u8))
                {
                    userData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityReservation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityReservation = CapacityReservationProfile.DeserializeCapacityReservationProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationProfile = ApplicationProfile.DeserializeApplicationProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hardwareProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareProfile = VirtualMachineScaleSetHardwareProfile.DeserializeVirtualMachineScaleSetHardwareProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceArtifactReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceArtifactReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("securityPostureReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityPostureReference = ComputeSecurityPostureReference.DeserializeComputeSecurityPostureReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineScaleSetVmProfile(
                osProfile,
                storageProfile,
                networkProfile,
                securityProfile,
                diagnosticsProfile,
                extensionProfile,
                licenseType,
                priority,
                evictionPolicy,
                billingProfile,
                scheduledEventsProfile,
                userData,
                capacityReservation,
                applicationProfile,
                hardwareProfile,
                serviceArtifactReference,
                securityPostureReference,
                timeCreated,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetVmProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetVmProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetVmProfile)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetVmProfile IPersistableModel<VirtualMachineScaleSetVmProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetVmProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetVmProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetVmProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetVmProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
