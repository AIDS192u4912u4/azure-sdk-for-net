// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppComplianceAutomation.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AppComplianceAutomation. </summary>
    public static partial class AppComplianceAutomationExtensions
    {
        private static AppComplianceAutomationArmClientMockingExtension GetAppComplianceAutomationArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new AppComplianceAutomationArmClientMockingExtension(client);
            });
        }

        private static AppComplianceAutomationTenantMockingExtension GetAppComplianceAutomationTenantMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new AppComplianceAutomationTenantMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="ReportResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ReportResource.CreateResourceIdentifier" /> to create a <see cref="ReportResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ReportResource" /> object. </returns>
        public static ReportResource GetReportResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppComplianceAutomationArmClientMockingExtension(client).GetReportResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SnapshotResource.CreateResourceIdentifier" /> to create a <see cref="SnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SnapshotResource" /> object. </returns>
        public static SnapshotResource GetSnapshotResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppComplianceAutomationArmClientMockingExtension(client).GetSnapshotResource(id);
        }

        /// <summary> Gets a collection of ReportResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ReportResources and their operations over a ReportResource. </returns>
        public static ReportResourceCollection GetReportResources(this TenantResource tenantResource)
        {
            return GetAppComplianceAutomationTenantMockingExtension(tenantResource).GetReportResources();
        }

        /// <summary>
        /// Get the AppComplianceAutomation report and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ReportResource>> GetReportResourceAsync(this TenantResource tenantResource, string reportName, CancellationToken cancellationToken = default)
        {
            return await GetAppComplianceAutomationTenantMockingExtension(tenantResource).GetReportResourceAsync(reportName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the AppComplianceAutomation report and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Report_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="reportName"> Report Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ReportResource> GetReportResource(this TenantResource tenantResource, string reportName, CancellationToken cancellationToken = default)
        {
            return GetAppComplianceAutomationTenantMockingExtension(tenantResource).GetReportResource(reportName, cancellationToken);
        }
    }
}
