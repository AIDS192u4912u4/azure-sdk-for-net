// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationPatch : IUtf8JsonSerializable, IJsonModel<PostgreSqlMigrationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlMigrationPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PostgreSqlMigrationPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support writing '{format}' format.");
            }

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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceDbServerResourceId))
            {
                writer.WritePropertyName("sourceDbServerResourceId"u8);
                writer.WriteStringValue(SourceDbServerResourceId);
            }
            if (Optional.IsDefined(SourceDbServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("sourceDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(SourceDbServerFullyQualifiedDomainName);
            }
            if (Optional.IsDefined(TargetDbServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("targetDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(TargetDbServerFullyQualifiedDomainName);
            }
            if (Optional.IsDefined(SecretParameters))
            {
                writer.WritePropertyName("secretParameters"u8);
                writer.WriteObjectValue(SecretParameters, options);
            }
            if (Optional.IsCollectionDefined(DbsToMigrate))
            {
                writer.WritePropertyName("dbsToMigrate"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToMigrate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SetupLogicalReplicationOnSourceDbIfNeeded))
            {
                writer.WritePropertyName("setupLogicalReplicationOnSourceDbIfNeeded"u8);
                writer.WriteStringValue(SetupLogicalReplicationOnSourceDbIfNeeded.Value.ToString());
            }
            if (Optional.IsDefined(OverwriteDbsInTarget))
            {
                writer.WritePropertyName("overwriteDbsInTarget"u8);
                writer.WriteStringValue(OverwriteDbsInTarget.Value.ToString());
            }
            if (Optional.IsDefined(MigrationWindowStartTimeInUtc))
            {
                writer.WritePropertyName("migrationWindowStartTimeInUtc"u8);
                writer.WriteStringValue(MigrationWindowStartTimeInUtc.Value, "O");
            }
            if (Optional.IsDefined(MigrateRoles))
            {
                writer.WritePropertyName("migrateRoles"u8);
                writer.WriteStringValue(MigrateRoles.Value.ToString());
            }
            if (Optional.IsDefined(StartDataMigration))
            {
                writer.WritePropertyName("startDataMigration"u8);
                writer.WriteStringValue(StartDataMigration.Value.ToString());
            }
            if (Optional.IsDefined(TriggerCutover))
            {
                writer.WritePropertyName("triggerCutover"u8);
                writer.WriteStringValue(TriggerCutover.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbsToTriggerCutoverOn))
            {
                writer.WritePropertyName("dbsToTriggerCutoverOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToTriggerCutoverOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Cancel))
            {
                writer.WritePropertyName("cancel"u8);
                writer.WriteStringValue(Cancel.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbsToCancelMigrationOn))
            {
                writer.WritePropertyName("dbsToCancelMigrationOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToCancelMigrationOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MigrationMode))
            {
                writer.WritePropertyName("migrationMode"u8);
                writer.WriteStringValue(MigrationMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        PostgreSqlMigrationPatch IJsonModel<PostgreSqlMigrationPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationPatch(document.RootElement, options);
        }

        internal static PostgreSqlMigrationPatch DeserializePostgreSqlMigrationPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ResourceIdentifier sourceDbServerResourceId = default;
            string sourceDbServerFullyQualifiedDomainName = default;
            string targetDbServerFullyQualifiedDomainName = default;
            PostgreSqlMigrationSecretParameters secretParameters = default;
            IList<string> dbsToMigrate = default;
            PostgreSqlMigrationLogicalReplicationOnSourceDb? setupLogicalReplicationOnSourceDbIfNeeded = default;
            PostgreSqlMigrationOverwriteDbsInTarget? overwriteDbsInTarget = default;
            DateTimeOffset? migrationWindowStartTimeInUtc = default;
            MigrateRolesEnum? migrateRoles = default;
            PostgreSqlMigrationStartDataMigration? startDataMigration = default;
            PostgreSqlMigrationTriggerCutover? triggerCutover = default;
            IList<string> dbsToTriggerCutoverOn = default;
            PostgreSqlMigrationCancel? cancel = default;
            IList<string> dbsToCancelMigrationOn = default;
            PostgreSqlMigrationMode? migrationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceDbServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDbServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDbServerFullyQualifiedDomainName"u8))
                        {
                            sourceDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDbServerFullyQualifiedDomainName"u8))
                        {
                            targetDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secretParameters = PostgreSqlMigrationSecretParameters.DeserializePostgreSqlMigrationSecretParameters(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dbsToMigrate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToMigrate = array;
                            continue;
                        }
                        if (property0.NameEquals("setupLogicalReplicationOnSourceDbIfNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            setupLogicalReplicationOnSourceDbIfNeeded = new PostgreSqlMigrationLogicalReplicationOnSourceDb(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("overwriteDbsInTarget"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwriteDbsInTarget = new PostgreSqlMigrationOverwriteDbsInTarget(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("migrationWindowStartTimeInUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationWindowStartTimeInUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("migrateRoles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrateRoles = new MigrateRolesEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDataMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDataMigration = new PostgreSqlMigrationStartDataMigration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerCutover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerCutover = new PostgreSqlMigrationTriggerCutover(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToTriggerCutoverOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToTriggerCutoverOn = array;
                            continue;
                        }
                        if (property0.NameEquals("cancel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cancel = new PostgreSqlMigrationCancel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToCancelMigrationOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToCancelMigrationOn = array;
                            continue;
                        }
                        if (property0.NameEquals("migrationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationMode = new PostgreSqlMigrationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PostgreSqlMigrationPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sourceDbServerResourceId,
                sourceDbServerFullyQualifiedDomainName,
                targetDbServerFullyQualifiedDomainName,
                secretParameters,
                dbsToMigrate ?? new ChangeTrackingList<string>(),
                setupLogicalReplicationOnSourceDbIfNeeded,
                overwriteDbsInTarget,
                migrationWindowStartTimeInUtc,
                migrateRoles,
                startDataMigration,
                triggerCutover,
                dbsToTriggerCutoverOn ?? new ChangeTrackingList<string>(),
                cancel,
                dbsToCancelMigrationOn ?? new ChangeTrackingList<string>(),
                migrationMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlMigrationPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlMigrationPatch IPersistableModel<PostgreSqlMigrationPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlMigrationPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlMigrationPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
