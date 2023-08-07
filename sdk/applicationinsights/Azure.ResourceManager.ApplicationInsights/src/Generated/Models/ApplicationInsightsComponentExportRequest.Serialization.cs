// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentExportRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecordTypes))
            {
                writer.WritePropertyName("RecordTypes"u8);
                writer.WriteStringValue(RecordTypes);
            }
            if (Optional.IsDefined(DestinationType))
            {
                writer.WritePropertyName("DestinationType"u8);
                writer.WriteStringValue(DestinationType);
            }
            if (Optional.IsDefined(DestinationAddress))
            {
                writer.WritePropertyName("DestinationAddress"u8);
                writer.WriteStringValue(DestinationAddress);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("IsEnabled"u8);
                writer.WriteStringValue(IsEnabled);
            }
            if (Optional.IsDefined(NotificationQueueEnabled))
            {
                writer.WritePropertyName("NotificationQueueEnabled"u8);
                writer.WriteStringValue(NotificationQueueEnabled);
            }
            if (Optional.IsDefined(NotificationQueueUri))
            {
                writer.WritePropertyName("NotificationQueueUri"u8);
                writer.WriteStringValue(NotificationQueueUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DestinationStorageSubscriptionId))
            {
                writer.WritePropertyName("DestinationStorageSubscriptionId"u8);
                writer.WriteStringValue(DestinationStorageSubscriptionId);
            }
            if (Optional.IsDefined(DestinationStorageLocationId))
            {
                writer.WritePropertyName("DestinationStorageLocationId"u8);
                writer.WriteStringValue(DestinationStorageLocationId);
            }
            if (Optional.IsDefined(DestinationAccountId))
            {
                writer.WritePropertyName("DestinationAccountId"u8);
                writer.WriteStringValue(DestinationAccountId);
            }
            writer.WriteEndObject();
        }
    }
}
