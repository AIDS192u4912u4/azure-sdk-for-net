// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlFirewallRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlFirewallRuleResource
            CosmosDBForPostgreSqlFirewallRuleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            CosmosDBForPostgreSqlFirewallRuleData data = new CosmosDBForPostgreSqlFirewallRuleData(IPAddress.Parse("0.0.0.0"), IPAddress.Parse("255.255.255.255"));
            ArmOperation<CosmosDBForPostgreSqlFirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallRuleName, data);
            CosmosDBForPostgreSqlFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlFirewallRuleResource
            CosmosDBForPostgreSqlFirewallRuleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            CosmosDBForPostgreSqlFirewallRuleResource result = await collection.GetAsync(firewallRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListFirewallRulesOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleListByCluster.json
            // this example is just showing the usage of "FirewallRules_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlFirewallRuleResource
            CosmosDBForPostgreSqlFirewallRuleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlFirewallRules();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBForPostgreSqlFirewallRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlFirewallRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetTheFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlFirewallRuleResource
            CosmosDBForPostgreSqlFirewallRuleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            bool result = await collection.ExistsAsync(firewallRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetTheFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlFirewallRuleResource
            CosmosDBForPostgreSqlFirewallRuleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            NullableResponse<CosmosDBForPostgreSqlFirewallRuleResource> response = await collection.GetIfExistsAsync(firewallRuleName);
            CosmosDBForPostgreSqlFirewallRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlFirewallRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
