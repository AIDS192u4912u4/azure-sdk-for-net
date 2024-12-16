// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_AdminRuleGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsSecurityAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleCollectionGet.json
            // this example is just showing the usage of "AdminRuleCollections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // invoke the operation
            AdminRuleGroupResource result = await adminRuleGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdminRuleGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesAnAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleCollectionDelete.json
            // this example is just showing the usage of "AdminRuleCollections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // invoke the operation
            bool? force = false;
            await adminRuleGroup.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAnAdminRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleCollectionPut.json
            // this example is just showing the usage of "AdminRuleCollections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // invoke the operation
            AdminRuleGroupData data = new AdminRuleGroupData
            {
                Description = "A sample policy",
                AppliesToGroups = { new NetworkManagerSecurityGroupItem(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager/networkGroups/testGroup")) },
            };
            ArmOperation<AdminRuleGroupResource> lro = await adminRuleGroup.UpdateAsync(WaitUntil.Completed, data);
            AdminRuleGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AdminRuleGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
