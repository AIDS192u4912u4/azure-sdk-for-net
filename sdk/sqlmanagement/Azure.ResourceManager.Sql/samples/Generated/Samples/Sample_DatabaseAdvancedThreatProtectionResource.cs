// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_DatabaseAdvancedThreatProtectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetADatabaseSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseAdvancedThreatProtectionResource created on azure
            // for more information of creating DatabaseAdvancedThreatProtectionResource, please refer to the document of DatabaseAdvancedThreatProtectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            string databaseName = "testdb";
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            ResourceIdentifier databaseAdvancedThreatProtectionResourceId = DatabaseAdvancedThreatProtectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, advancedThreatProtectionName);
            DatabaseAdvancedThreatProtectionResource databaseAdvancedThreatProtection = client.GetDatabaseAdvancedThreatProtectionResource(databaseAdvancedThreatProtectionResourceId);

            // invoke the operation
            DatabaseAdvancedThreatProtectionResource result = await databaseAdvancedThreatProtection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateADatabaseSAdvancedThreatProtectionSettingsWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsCreateMax.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseAdvancedThreatProtectionResource created on azure
            // for more information of creating DatabaseAdvancedThreatProtectionResource, please refer to the document of DatabaseAdvancedThreatProtectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            string databaseName = "testdb";
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            ResourceIdentifier databaseAdvancedThreatProtectionResourceId = DatabaseAdvancedThreatProtectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, advancedThreatProtectionName);
            DatabaseAdvancedThreatProtectionResource databaseAdvancedThreatProtection = client.GetDatabaseAdvancedThreatProtectionResource(databaseAdvancedThreatProtectionResourceId);

            // invoke the operation
            DatabaseAdvancedThreatProtectionData data = new DatabaseAdvancedThreatProtectionData
            {
                State = AdvancedThreatProtectionState.Enabled,
            };
            ArmOperation<DatabaseAdvancedThreatProtectionResource> lro = await databaseAdvancedThreatProtection.UpdateAsync(WaitUntil.Completed, data);
            DatabaseAdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateADatabaseSAdvancedThreatProtectionSettingsWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsCreateMin.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseAdvancedThreatProtectionResource created on azure
            // for more information of creating DatabaseAdvancedThreatProtectionResource, please refer to the document of DatabaseAdvancedThreatProtectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            string databaseName = "testdb";
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            ResourceIdentifier databaseAdvancedThreatProtectionResourceId = DatabaseAdvancedThreatProtectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, advancedThreatProtectionName);
            DatabaseAdvancedThreatProtectionResource databaseAdvancedThreatProtection = client.GetDatabaseAdvancedThreatProtectionResource(databaseAdvancedThreatProtectionResourceId);

            // invoke the operation
            DatabaseAdvancedThreatProtectionData data = new DatabaseAdvancedThreatProtectionData
            {
                State = AdvancedThreatProtectionState.Disabled,
            };
            ArmOperation<DatabaseAdvancedThreatProtectionResource> lro = await databaseAdvancedThreatProtection.UpdateAsync(WaitUntil.Completed, data);
            DatabaseAdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
