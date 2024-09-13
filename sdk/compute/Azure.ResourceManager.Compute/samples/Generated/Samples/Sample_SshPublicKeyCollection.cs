// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_SshPublicKeyCollection
    {
        // SshPublicKey_ListByResourceGroup_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SshPublicKeyListByResourceGroupMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/sshPublicKeyExamples/SshPublicKey_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SshPublicKeyResource
            SshPublicKeyCollection collection = resourceGroupResource.GetSshPublicKeys();

            // invoke the operation and iterate over the result
            await foreach (SshPublicKeyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SshPublicKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SshPublicKey_ListByResourceGroup_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SshPublicKeyListByResourceGroupMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/sshPublicKeyExamples/SshPublicKey_ListByResourceGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "SshPublicKeys_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SshPublicKeyResource
            SshPublicKeyCollection collection = resourceGroupResource.GetSshPublicKeys();

            // invoke the operation and iterate over the result
            await foreach (SshPublicKeyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SshPublicKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create a new SSH public key resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewSSHPublicKeyResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/sshPublicKeyExamples/SshPublicKey_Create.json
            // this example is just showing the usage of "SshPublicKeys_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SshPublicKeyResource
            SshPublicKeyCollection collection = resourceGroupResource.GetSshPublicKeys();

            // invoke the operation
            string sshPublicKeyName = "mySshPublicKeyName";
            SshPublicKeyData data = new SshPublicKeyData(new AzureLocation("westus"))
            {
                PublicKey = "{ssh-rsa public key}",
            };
            ArmOperation<SshPublicKeyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sshPublicKeyName, data);
            SshPublicKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SshPublicKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an ssh public key.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnSshPublicKey()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/sshPublicKeyExamples/SshPublicKey_Get.json
            // this example is just showing the usage of "SshPublicKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SshPublicKeyResource
            SshPublicKeyCollection collection = resourceGroupResource.GetSshPublicKeys();

            // invoke the operation
            string sshPublicKeyName = "mySshPublicKeyName";
            SshPublicKeyResource result = await collection.GetAsync(sshPublicKeyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SshPublicKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an ssh public key.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnSshPublicKey()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/sshPublicKeyExamples/SshPublicKey_Get.json
            // this example is just showing the usage of "SshPublicKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SshPublicKeyResource
            SshPublicKeyCollection collection = resourceGroupResource.GetSshPublicKeys();

            // invoke the operation
            string sshPublicKeyName = "mySshPublicKeyName";
            bool result = await collection.ExistsAsync(sshPublicKeyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an ssh public key.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnSshPublicKey()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/sshPublicKeyExamples/SshPublicKey_Get.json
            // this example is just showing the usage of "SshPublicKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SshPublicKeyResource
            SshPublicKeyCollection collection = resourceGroupResource.GetSshPublicKeys();

            // invoke the operation
            string sshPublicKeyName = "mySshPublicKeyName";
            NullableResponse<SshPublicKeyResource> response = await collection.GetIfExistsAsync(sshPublicKeyName);
            SshPublicKeyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SshPublicKeyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
