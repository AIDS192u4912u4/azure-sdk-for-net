// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateDetectionOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("series"u8);
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (Optional.IsDefined(CustomInterval))
            {
                writer.WritePropertyName("customInterval"u8);
                writer.WriteNumberValue(CustomInterval.Value);
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period"u8);
                writer.WriteNumberValue(Period.Value);
            }
            if (Optional.IsDefined(MaxAnomalyRatio))
            {
                writer.WritePropertyName("maxAnomalyRatio"u8);
                writer.WriteNumberValue(MaxAnomalyRatio.Value);
            }
            if (Optional.IsDefined(Sensitivity))
            {
                writer.WritePropertyName("sensitivity"u8);
                writer.WriteNumberValue(Sensitivity.Value);
            }
            if (Optional.IsDefined(ImputeMode))
            {
                writer.WritePropertyName("imputeMode"u8);
                writer.WriteStringValue(ImputeMode.Value.ToString());
            }
            if (Optional.IsDefined(ImputeFixedValue))
            {
                writer.WritePropertyName("imputeFixedValue"u8);
                writer.WriteNumberValue(ImputeFixedValue.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
