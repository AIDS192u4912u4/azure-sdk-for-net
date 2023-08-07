// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class MachineDisk
    {
        internal static MachineDisk DeserializeMachineDisk(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> capacityGB = default;
            Optional<MachineSkuDiskConnectionType> connection = default;
            Optional<DiskType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacityGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("connection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connection = new MachineSkuDiskConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new DiskType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineDisk(Optional.ToNullable(capacityGB), Optional.ToNullable(connection), Optional.ToNullable(type));
        }
    }
}
