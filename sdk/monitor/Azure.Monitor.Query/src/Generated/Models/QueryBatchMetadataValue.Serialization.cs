// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class QueryBatchMetadataValue
    {
        internal static QueryBatchMetadataValue DeserializeQueryBatchMetadataValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<QueryBatchLocalizableString> name = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = QueryBatchLocalizableString.DeserializeQueryBatchLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new QueryBatchMetadataValue(name.Value, value.Value);
        }
    }
}
