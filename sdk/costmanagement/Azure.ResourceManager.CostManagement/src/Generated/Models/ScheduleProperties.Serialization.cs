// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ScheduleProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToString());
            if (Optional.IsDefined(HourOfDay))
            {
                writer.WritePropertyName("hourOfDay"u8);
                writer.WriteNumberValue(HourOfDay.Value);
            }
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeeksOfMonth))
            {
                writer.WritePropertyName("weeksOfMonth"u8);
                writer.WriteStartArray();
                foreach (var item in WeeksOfMonth)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DayOfMonth))
            {
                writer.WritePropertyName("dayOfMonth"u8);
                writer.WriteNumberValue(DayOfMonth.Value);
            }
            writer.WritePropertyName("startDate"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endDate"u8);
            writer.WriteStringValue(EndOn, "O");
            writer.WriteEndObject();
        }

        internal static ScheduleProperties DeserializeScheduleProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleFrequency frequency = default;
            Optional<int> hourOfDay = default;
            Optional<IList<ScheduledActionDaysOfWeek>> daysOfWeek = default;
            Optional<IList<ScheduledActionWeeksOfMonth>> weeksOfMonth = default;
            Optional<int> dayOfMonth = default;
            DateTimeOffset startDate = default;
            DateTimeOffset endDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequency"u8))
                {
                    frequency = new ScheduleFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourOfDay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hourOfDay = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("daysOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScheduledActionDaysOfWeek> array = new List<ScheduledActionDaysOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScheduledActionDaysOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("weeksOfMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScheduledActionWeeksOfMonth> array = new List<ScheduledActionWeeksOfMonth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScheduledActionWeeksOfMonth(item.GetString()));
                    }
                    weeksOfMonth = array;
                    continue;
                }
                if (property.NameEquals("dayOfMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfMonth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ScheduleProperties(frequency, Optional.ToNullable(hourOfDay), Optional.ToList(daysOfWeek), Optional.ToList(weeksOfMonth), Optional.ToNullable(dayOfMonth), startDate, endDate);
        }
    }
}
