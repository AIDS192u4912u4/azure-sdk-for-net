// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Sftp write settings. </summary>
    public partial class SftpWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of SftpWriteSettings. </summary>
        public SftpWriteSettings()
        {
            StoreWriteSettingsType = "SftpWriteSettings";
        }

        /// <summary> Initializes a new instance of SftpWriteSettings. </summary>
        /// <param name="storeWriteSettingsType"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="operationTimeout"> Specifies the timeout for writing each chunk to SFTP server. Default value: 01:00:00 (one hour). Type: string (or Expression with resultType string). </param>
        /// <param name="useTempFileRename"> Upload to temporary file(s) and rename. Disable this option if your SFTP server doesn't support rename operation. Type: boolean (or Expression with resultType boolean). </param>
        internal SftpWriteSettings(string storeWriteSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, BinaryData copyBehavior, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> operationTimeout, DataFactoryElement<bool> useTempFileRename) : base(storeWriteSettingsType, maxConcurrentConnections, disableMetricsCollection, copyBehavior, additionalProperties)
        {
            OperationTimeout = operationTimeout;
            UseTempFileRename = useTempFileRename;
            StoreWriteSettingsType = storeWriteSettingsType ?? "SftpWriteSettings";
        }

        /// <summary> Specifies the timeout for writing each chunk to SFTP server. Default value: 01:00:00 (one hour). Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> OperationTimeout { get; set; }
        /// <summary> Upload to temporary file(s) and rename. Disable this option if your SFTP server doesn't support rename operation. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> UseTempFileRename { get; set; }
    }
}
