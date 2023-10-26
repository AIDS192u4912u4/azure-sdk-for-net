// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class IntegrationAccountAgreementData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("agreementType"u8);
            writer.WriteStringValue(AgreementType.ToSerialString());
            writer.WritePropertyName("hostPartner"u8);
            writer.WriteStringValue(HostPartner);
            writer.WritePropertyName("guestPartner"u8);
            writer.WriteStringValue(GuestPartner);
            writer.WritePropertyName("hostIdentity"u8);
            writer.WriteObjectValue(HostIdentity);
            writer.WritePropertyName("guestIdentity"u8);
            writer.WriteObjectValue(GuestIdentity);
            writer.WritePropertyName("content"u8);
            writer.WriteObjectValue(Content);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IntegrationAccountAgreementData DeserializeIntegrationAccountAgreementData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> changedTime = default;
            Optional<BinaryData> metadata = default;
            IntegrationAccountAgreementType agreementType = default;
            string hostPartner = default;
            string guestPartner = default;
            IntegrationAccountBusinessIdentity hostIdentity = default;
            IntegrationAccountBusinessIdentity guestIdentity = default;
            IntegrationAccountAgreementContent content = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("agreementType"u8))
                        {
                            agreementType = property0.Value.GetString().ToIntegrationAccountAgreementType();
                            continue;
                        }
                        if (property0.NameEquals("hostPartner"u8))
                        {
                            hostPartner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("guestPartner"u8))
                        {
                            guestPartner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostIdentity"u8))
                        {
                            hostIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("guestIdentity"u8))
                        {
                            guestIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("content"u8))
                        {
                            content = IntegrationAccountAgreementContent.DeserializeIntegrationAccountAgreementContent(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IntegrationAccountAgreementData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(createdTime), Optional.ToNullable(changedTime), metadata.Value, agreementType, hostPartner, guestPartner, hostIdentity, guestIdentity, content);
        }
    }
}
