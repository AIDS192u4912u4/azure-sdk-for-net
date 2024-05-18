// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.ClientModel.Primitives;
using System.Threading.Tasks;
using System.Threading;
using System;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    [CodeGenType("MySqlFlexibleServersExtensions")]
    public static partial class FlexibleServersExtensions
    {
        /// <summary>
        /// Get the operation detailed status for a long running operation.
        /// </summary>
        /// <param name="operation"> The long-running operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operation"/> is null or the long-running operation doesn't support get detailed status. </exception>
        public static async Task<Response<OperationProgressResult>> GetDetailedStatusAsync(this ArmOperation<MySqlFlexibleServerBackupAndExportResult> operation, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(operation, nameof(operation));
            Response response = await operation.UpdateStatusAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue(ModelReaderWriter.Read<OperationProgressResult>(response.Content), response);
        }

        /// <summary>
        /// Get the operation detailed status for a long running operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/operationProgress/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationProgress_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operation"> The long-running operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operation"/> is null or the long-running operation doesn't support get detailed status. </exception>
        public static Response<OperationProgressResult> GetDetailedStatus<T>(this ArmOperation<MySqlFlexibleServerBackupAndExportResult> operation, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(operation, nameof(operation));
            Response response = operation.UpdateStatus(cancellationToken);
            return Response.FromValue(ModelReaderWriter.Read<OperationProgressResult>(response.Content), response);
        }
    }
}
