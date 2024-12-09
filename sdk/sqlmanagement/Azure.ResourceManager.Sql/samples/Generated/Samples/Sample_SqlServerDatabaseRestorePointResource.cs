// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerDatabaseRestorePointResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsADatabaseRestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseRestorePointsGet.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseRestorePointResource created on azure
            // for more information of creating SqlServerDatabaseRestorePointResource, please refer to the document of SqlServerDatabaseRestorePointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            string restorePointName = "131546477590000000";
            ResourceIdentifier sqlServerDatabaseRestorePointResourceId = SqlServerDatabaseRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, restorePointName);
            SqlServerDatabaseRestorePointResource sqlServerDatabaseRestorePoint = client.GetSqlServerDatabaseRestorePointResource(sqlServerDatabaseRestorePointResourceId);

            // invoke the operation
            SqlServerDatabaseRestorePointResource result = await sqlServerDatabaseRestorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsADatawarehouseDatabaseRestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DataWarehouseRestorePointsGet.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseRestorePointResource created on azure
            // for more information of creating SqlServerDatabaseRestorePointResource, please refer to the document of SqlServerDatabaseRestorePointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            string restorePointName = "131546477590000000";
            ResourceIdentifier sqlServerDatabaseRestorePointResourceId = SqlServerDatabaseRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, restorePointName);
            SqlServerDatabaseRestorePointResource sqlServerDatabaseRestorePoint = client.GetSqlServerDatabaseRestorePointResource(sqlServerDatabaseRestorePointResourceId);

            // invoke the operation
            SqlServerDatabaseRestorePointResource result = await sqlServerDatabaseRestorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesARestorePoint()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseRestorePointsDelete.json
            // this example is just showing the usage of "RestorePoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseRestorePointResource created on azure
            // for more information of creating SqlServerDatabaseRestorePointResource, please refer to the document of SqlServerDatabaseRestorePointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testserver";
            string databaseName = "testDatabase";
            string restorePointName = "131546477590000000";
            ResourceIdentifier sqlServerDatabaseRestorePointResourceId = SqlServerDatabaseRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, restorePointName);
            SqlServerDatabaseRestorePointResource sqlServerDatabaseRestorePoint = client.GetSqlServerDatabaseRestorePointResource(sqlServerDatabaseRestorePointResourceId);

            // invoke the operation
            await sqlServerDatabaseRestorePoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
