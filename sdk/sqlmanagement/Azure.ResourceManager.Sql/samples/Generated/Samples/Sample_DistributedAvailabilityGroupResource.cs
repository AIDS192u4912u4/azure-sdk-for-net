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
    public partial class Sample_DistributedAvailabilityGroupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheDistributedAvailabilityGroupInfo()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DistributedAvailabilityGroupsGet.json
            // this example is just showing the usage of "DistributedAvailabilityGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DistributedAvailabilityGroupResource created on azure
            // for more information of creating DistributedAvailabilityGroupResource, please refer to the document of DistributedAvailabilityGroupResource
            string subscriptionId = "f2669dff-5f08-45dd-b857-b2a60b72cdc9";
            string resourceGroupName = "testrg";
            string managedInstanceName = "testcl";
            string distributedAvailabilityGroupName = "dag";
            ResourceIdentifier distributedAvailabilityGroupResourceId = DistributedAvailabilityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, distributedAvailabilityGroupName);
            DistributedAvailabilityGroupResource distributedAvailabilityGroup = client.GetDistributedAvailabilityGroupResource(distributedAvailabilityGroupResourceId);

            // invoke the operation
            DistributedAvailabilityGroupResource result = await distributedAvailabilityGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DistributedAvailabilityGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_InitiateADistributedAvailabilityGroupDrop()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DistributedAvailabilityGroupsDelete.json
            // this example is just showing the usage of "DistributedAvailabilityGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DistributedAvailabilityGroupResource created on azure
            // for more information of creating DistributedAvailabilityGroupResource, please refer to the document of DistributedAvailabilityGroupResource
            string subscriptionId = "f2669dff-5f08-45dd-b857-b2a60b72cdc9";
            string resourceGroupName = "testrg";
            string managedInstanceName = "testcl";
            string distributedAvailabilityGroupName = "dag";
            ResourceIdentifier distributedAvailabilityGroupResourceId = DistributedAvailabilityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, distributedAvailabilityGroupName);
            DistributedAvailabilityGroupResource distributedAvailabilityGroup = client.GetDistributedAvailabilityGroupResource(distributedAvailabilityGroupResourceId);

            // invoke the operation
            await distributedAvailabilityGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateTheDistributedAvailabilityGroupReplicationModeBeforeDeletingIt()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DistributedAvailabilityGroupsUpdate.json
            // this example is just showing the usage of "DistributedAvailabilityGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DistributedAvailabilityGroupResource created on azure
            // for more information of creating DistributedAvailabilityGroupResource, please refer to the document of DistributedAvailabilityGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string managedInstanceName = "testcl";
            string distributedAvailabilityGroupName = "dag";
            ResourceIdentifier distributedAvailabilityGroupResourceId = DistributedAvailabilityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, distributedAvailabilityGroupName);
            DistributedAvailabilityGroupResource distributedAvailabilityGroup = client.GetDistributedAvailabilityGroupResource(distributedAvailabilityGroupResourceId);

            // invoke the operation
            DistributedAvailabilityGroupData data = new DistributedAvailabilityGroupData
            {
                ReplicationMode = DistributedAvailabilityGroupReplicationMode.Sync,
            };
            ArmOperation<DistributedAvailabilityGroupResource> lro = await distributedAvailabilityGroup.UpdateAsync(WaitUntil.Completed, data);
            DistributedAvailabilityGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DistributedAvailabilityGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
