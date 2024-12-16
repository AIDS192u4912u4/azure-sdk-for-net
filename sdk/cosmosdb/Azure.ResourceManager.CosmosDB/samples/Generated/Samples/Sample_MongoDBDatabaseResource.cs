// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_MongoDBDatabaseResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBMongoDBDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBDatabaseGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoDBDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseResource created on azure
            // for more information of creating MongoDBDatabaseResource, please refer to the document of MongoDBDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseResourceId = MongoDBDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseResource mongoDBDatabase = client.GetMongoDBDatabaseResource(mongoDBDatabaseResourceId);

            // invoke the operation
            MongoDBDatabaseResource result = await mongoDBDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CosmosDBMongoDBDatabaseDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBDatabaseDelete.json
            // this example is just showing the usage of "MongoDBResources_DeleteMongoDBDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseResource created on azure
            // for more information of creating MongoDBDatabaseResource, please refer to the document of MongoDBDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseResourceId = MongoDBDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseResource mongoDBDatabase = client.GetMongoDBDatabaseResource(mongoDBDatabaseResourceId);

            // invoke the operation
            await mongoDBDatabase.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CosmosDBMongoDBDatabaseCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBDatabaseCreateUpdate.json
            // this example is just showing the usage of "MongoDBResources_CreateUpdateMongoDBDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseResource created on azure
            // for more information of creating MongoDBDatabaseResource, please refer to the document of MongoDBDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseResourceId = MongoDBDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseResource mongoDBDatabase = client.GetMongoDBDatabaseResource(mongoDBDatabaseResourceId);

            // invoke the operation
            MongoDBDatabaseCreateOrUpdateContent content = new MongoDBDatabaseCreateOrUpdateContent(new AzureLocation("West US"), new MongoDBDatabaseResourceInfo("databaseName"))
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags = { },
            };
            ArmOperation<MongoDBDatabaseResource> lro = await mongoDBDatabase.UpdateAsync(WaitUntil.Completed, content);
            MongoDBDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CosmosDBMongoDBDatabaseRestore()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBDatabaseRestore.json
            // this example is just showing the usage of "MongoDBResources_CreateUpdateMongoDBDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseResource created on azure
            // for more information of creating MongoDBDatabaseResource, please refer to the document of MongoDBDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseResourceId = MongoDBDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseResource mongoDBDatabase = client.GetMongoDBDatabaseResource(mongoDBDatabaseResourceId);

            // invoke the operation
            MongoDBDatabaseCreateOrUpdateContent content = new MongoDBDatabaseCreateOrUpdateContent(new AzureLocation("West US"), new MongoDBDatabaseResourceInfo("databaseName")
            {
                RestoreParameters = new ResourceRestoreParameters
                {
                    RestoreSource = "/subscriptions/subid/providers/Microsoft.DocumentDB/locations/WestUS/restorableDatabaseAccounts/restorableDatabaseAccountId",
                    RestoreTimestampInUtc = DateTimeOffset.Parse("2022-07-20T18:28:00Z"),
                    IsRestoreWithTtlDisabled = false,
                },
                CreateMode = CosmosDBAccountCreateMode.Restore,
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags = { },
            };
            ArmOperation<MongoDBDatabaseResource> lro = await mongoDBDatabase.UpdateAsync(WaitUntil.Completed, content);
            MongoDBDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task MongoDBDatabasePartitionMerge_CosmosDBMongoDBDatabasePartitionMerge()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBMongoDBDatabasePartitionMerge.json
            // this example is just showing the usage of "MongoDBResources_MongoDBDatabasePartitionMerge" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBDatabaseResource created on azure
            // for more information of creating MongoDBDatabaseResource, please refer to the document of MongoDBDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier mongoDBDatabaseResourceId = MongoDBDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            MongoDBDatabaseResource mongoDBDatabase = client.GetMongoDBDatabaseResource(mongoDBDatabaseResourceId);

            // invoke the operation
            MergeParameters mergeParameters = new MergeParameters
            {
                IsDryRun = false,
            };
            ArmOperation<PhysicalPartitionStorageInfoCollection> lro = await mongoDBDatabase.MongoDBDatabasePartitionMergeAsync(WaitUntil.Completed, mergeParameters);
            PhysicalPartitionStorageInfoCollection result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
