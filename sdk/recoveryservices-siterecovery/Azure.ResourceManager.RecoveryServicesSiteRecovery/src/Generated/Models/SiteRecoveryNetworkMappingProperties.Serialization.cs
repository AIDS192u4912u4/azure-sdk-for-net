// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryNetworkMappingProperties
    {
        internal static SiteRecoveryNetworkMappingProperties DeserializeSiteRecoveryNetworkMappingProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> state = default;
            Optional<string> primaryNetworkFriendlyName = default;
            Optional<ResourceIdentifier> primaryNetworkId = default;
            Optional<string> primaryFabricFriendlyName = default;
            Optional<string> recoveryNetworkFriendlyName = default;
            Optional<ResourceIdentifier> recoveryNetworkId = default;
            Optional<ResourceIdentifier> recoveryFabricArmId = default;
            Optional<string> recoveryFabricFriendlyName = default;
            Optional<NetworkMappingFabricSpecificSettings> fabricSpecificSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNetworkFriendlyName"u8))
                {
                    primaryNetworkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkFriendlyName"u8))
                {
                    recoveryNetworkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricSpecificSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificSettings = NetworkMappingFabricSpecificSettings.DeserializeNetworkMappingFabricSpecificSettings(property.Value);
                    continue;
                }
            }
            return new SiteRecoveryNetworkMappingProperties(state.Value, primaryNetworkFriendlyName.Value, primaryNetworkId.Value, primaryFabricFriendlyName.Value, recoveryNetworkFriendlyName.Value, recoveryNetworkId.Value, recoveryFabricArmId.Value, recoveryFabricFriendlyName.Value, fabricSpecificSettings.Value);
        }
    }
}
