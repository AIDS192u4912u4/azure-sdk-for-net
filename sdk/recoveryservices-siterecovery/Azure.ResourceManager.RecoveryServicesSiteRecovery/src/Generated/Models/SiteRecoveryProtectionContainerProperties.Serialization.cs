// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryProtectionContainerProperties
    {
        internal static SiteRecoveryProtectionContainerProperties DeserializeSiteRecoveryProtectionContainerProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fabricFriendlyName = default;
            Optional<string> friendlyName = default;
            Optional<string> fabricType = default;
            Optional<int> protectedItemCount = default;
            Optional<string> pairingStatus = default;
            Optional<string> role = default;
            Optional<ProtectionContainerFabricSpecificDetails> fabricSpecificDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricFriendlyName"u8))
                {
                    fabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricType"u8))
                {
                    fabricType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pairingStatus"u8))
                {
                    pairingStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificDetails = ProtectionContainerFabricSpecificDetails.DeserializeProtectionContainerFabricSpecificDetails(property.Value);
                    continue;
                }
            }
            return new SiteRecoveryProtectionContainerProperties(fabricFriendlyName.Value, friendlyName.Value, fabricType.Value, Optional.ToNullable(protectedItemCount), pairingStatus.Value, role.Value, fabricSpecificDetails.Value);
        }
    }
}
