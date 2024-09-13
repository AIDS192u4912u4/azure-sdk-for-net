// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownCopySink))]
    public partial class CopySink : IUtf8JsonSerializable, IJsonModel<CopySink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopySink>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CopySink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopySink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopySink)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySinkType);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                JsonSerializer.Serialize(writer, WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                JsonSerializer.Serialize(writer, WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                JsonSerializer.Serialize(writer, SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                JsonSerializer.Serialize(writer, SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        CopySink IJsonModel<CopySink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopySink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopySink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopySink(document.RootElement, options);
        }

        internal static CopySink DeserializeCopySink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroSink": return AvroSink.DeserializeAvroSink(element, options);
                    case "AzureBlobFSSink": return AzureBlobFSSink.DeserializeAzureBlobFSSink(element, options);
                    case "AzureDatabricksDeltaLakeSink": return AzureDatabricksDeltaLakeSink.DeserializeAzureDatabricksDeltaLakeSink(element, options);
                    case "AzureDataExplorerSink": return AzureDataExplorerSink.DeserializeAzureDataExplorerSink(element, options);
                    case "AzureDataLakeStoreSink": return AzureDataLakeStoreSink.DeserializeAzureDataLakeStoreSink(element, options);
                    case "AzureMySqlSink": return AzureMySqlSink.DeserializeAzureMySqlSink(element, options);
                    case "AzurePostgreSqlSink": return AzurePostgreSqlSink.DeserializeAzurePostgreSqlSink(element, options);
                    case "AzureQueueSink": return AzureQueueSink.DeserializeAzureQueueSink(element, options);
                    case "AzureSearchIndexSink": return AzureSearchIndexSink.DeserializeAzureSearchIndexSink(element, options);
                    case "AzureSqlSink": return AzureSqlSink.DeserializeAzureSqlSink(element, options);
                    case "AzureTableSink": return AzureTableSink.DeserializeAzureTableSink(element, options);
                    case "BinarySink": return BinarySink.DeserializeBinarySink(element, options);
                    case "BlobSink": return DataFactoryBlobSink.DeserializeDataFactoryBlobSink(element, options);
                    case "CommonDataServiceForAppsSink": return CommonDataServiceForAppsSink.DeserializeCommonDataServiceForAppsSink(element, options);
                    case "CosmosDbMongoDbApiSink": return CosmosDBMongoDBApiSink.DeserializeCosmosDBMongoDBApiSink(element, options);
                    case "CosmosDbSqlApiSink": return CosmosDBSqlApiSink.DeserializeCosmosDBSqlApiSink(element, options);
                    case "DelimitedTextSink": return DelimitedTextSink.DeserializeDelimitedTextSink(element, options);
                    case "DocumentDbCollectionSink": return DocumentDBCollectionSink.DeserializeDocumentDBCollectionSink(element, options);
                    case "DynamicsCrmSink": return DynamicsCrmSink.DeserializeDynamicsCrmSink(element, options);
                    case "DynamicsSink": return DynamicsSink.DeserializeDynamicsSink(element, options);
                    case "FileSystemSink": return FileSystemSink.DeserializeFileSystemSink(element, options);
                    case "IcebergSink": return IcebergSink.DeserializeIcebergSink(element, options);
                    case "InformixSink": return InformixSink.DeserializeInformixSink(element, options);
                    case "JsonSink": return JsonSink.DeserializeJsonSink(element, options);
                    case "LakeHouseTableSink": return LakeHouseTableSink.DeserializeLakeHouseTableSink(element, options);
                    case "MicrosoftAccessSink": return MicrosoftAccessSink.DeserializeMicrosoftAccessSink(element, options);
                    case "MongoDbAtlasSink": return MongoDBAtlasSink.DeserializeMongoDBAtlasSink(element, options);
                    case "MongoDbV2Sink": return MongoDBV2Sink.DeserializeMongoDBV2Sink(element, options);
                    case "OdbcSink": return OdbcSink.DeserializeOdbcSink(element, options);
                    case "OracleSink": return OracleSink.DeserializeOracleSink(element, options);
                    case "OrcSink": return OrcSink.DeserializeOrcSink(element, options);
                    case "ParquetSink": return ParquetSink.DeserializeParquetSink(element, options);
                    case "RestSink": return RestSink.DeserializeRestSink(element, options);
                    case "SalesforceServiceCloudSink": return SalesforceServiceCloudSink.DeserializeSalesforceServiceCloudSink(element, options);
                    case "SalesforceServiceCloudV2Sink": return SalesforceServiceCloudV2Sink.DeserializeSalesforceServiceCloudV2Sink(element, options);
                    case "SalesforceSink": return SalesforceSink.DeserializeSalesforceSink(element, options);
                    case "SalesforceV2Sink": return SalesforceV2Sink.DeserializeSalesforceV2Sink(element, options);
                    case "SapCloudForCustomerSink": return SapCloudForCustomerSink.DeserializeSapCloudForCustomerSink(element, options);
                    case "SnowflakeSink": return SnowflakeSink.DeserializeSnowflakeSink(element, options);
                    case "SnowflakeV2Sink": return SnowflakeV2Sink.DeserializeSnowflakeV2Sink(element, options);
                    case "SqlDWSink": return SqlDWSink.DeserializeSqlDWSink(element, options);
                    case "SqlMISink": return SqlMISink.DeserializeSqlMISink(element, options);
                    case "SqlServerSink": return SqlServerSink.DeserializeSqlServerSink(element, options);
                    case "SqlSink": return SqlSink.DeserializeSqlSink(element, options);
                    case "WarehouseSink": return WarehouseSink.DeserializeWarehouseSink(element, options);
                }
            }
            return UnknownCopySink.DeserializeUnknownCopySink(element, options);
        }

        BinaryData IPersistableModel<CopySink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopySink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopySink)} does not support writing '{options.Format}' format.");
            }
        }

        CopySink IPersistableModel<CopySink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopySink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCopySink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopySink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopySink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
