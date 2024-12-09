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
    public partial class Sample_DdosCustomPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDDoSCustomPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DdosCustomPolicyGet.json
            // this example is just showing the usage of "DdosCustomPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DdosCustomPolicyResource created on azure
            // for more information of creating DdosCustomPolicyResource, please refer to the document of DdosCustomPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ddosCustomPolicyName = "test-ddos-custom-policy";
            ResourceIdentifier ddosCustomPolicyResourceId = DdosCustomPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ddosCustomPolicyName);
            DdosCustomPolicyResource ddosCustomPolicy = client.GetDdosCustomPolicyResource(ddosCustomPolicyResourceId);

            // invoke the operation
            DdosCustomPolicyResource result = await ddosCustomPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DdosCustomPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteDDoSCustomPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DdosCustomPolicyDelete.json
            // this example is just showing the usage of "DdosCustomPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DdosCustomPolicyResource created on azure
            // for more information of creating DdosCustomPolicyResource, please refer to the document of DdosCustomPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ddosCustomPolicyName = "test-ddos-custom-policy";
            ResourceIdentifier ddosCustomPolicyResourceId = DdosCustomPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ddosCustomPolicyName);
            DdosCustomPolicyResource ddosCustomPolicy = client.GetDdosCustomPolicyResource(ddosCustomPolicyResourceId);

            // invoke the operation
            await ddosCustomPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DDoSCustomPolicyUpdateTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DdosCustomPolicyUpdateTags.json
            // this example is just showing the usage of "DdosCustomPolicies_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DdosCustomPolicyResource created on azure
            // for more information of creating DdosCustomPolicyResource, please refer to the document of DdosCustomPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ddosCustomPolicyName = "test-ddos-custom-policy";
            ResourceIdentifier ddosCustomPolicyResourceId = DdosCustomPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ddosCustomPolicyName);
            DdosCustomPolicyResource ddosCustomPolicy = client.GetDdosCustomPolicyResource(ddosCustomPolicyResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            DdosCustomPolicyResource result = await ddosCustomPolicy.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DdosCustomPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
