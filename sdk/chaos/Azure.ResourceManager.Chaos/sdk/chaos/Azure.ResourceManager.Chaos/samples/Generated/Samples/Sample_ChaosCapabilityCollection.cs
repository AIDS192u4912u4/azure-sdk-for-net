// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ChaosCapabilityCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACapabilityThatExtendsAVirtualMachineTargetResource()
        {
            // Generated from example definition: 2025-01-01/Capabilities_Get.json
            // this example is just showing the usage of "Capability_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosTargetResource created on azure
            // for more information of creating ChaosTargetResource, please refer to the document of ChaosTargetResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            string targetName = "Microsoft-VirtualMachine";
            ResourceIdentifier chaosTargetResourceId = ChaosTargetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentProviderNamespace, parentResourceType, parentResourceName, targetName);
            ChaosTargetResource chaosTarget = client.GetChaosTargetResource(chaosTargetResourceId);

            // get the collection of this ChaosCapabilityResource
            ChaosCapabilityCollection collection = chaosTarget.GetChaosCapabilities();

            // invoke the operation
            string capabilityName = "Shutdown-1.0";
            ChaosCapabilityResource result = await collection.GetAsync(capabilityName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosCapabilityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetACapabilityThatExtendsAVirtualMachineTargetResource()
        {
            // Generated from example definition: 2025-01-01/Capabilities_Get.json
            // this example is just showing the usage of "Capability_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosTargetResource created on azure
            // for more information of creating ChaosTargetResource, please refer to the document of ChaosTargetResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            string targetName = "Microsoft-VirtualMachine";
            ResourceIdentifier chaosTargetResourceId = ChaosTargetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentProviderNamespace, parentResourceType, parentResourceName, targetName);
            ChaosTargetResource chaosTarget = client.GetChaosTargetResource(chaosTargetResourceId);

            // get the collection of this ChaosCapabilityResource
            ChaosCapabilityCollection collection = chaosTarget.GetChaosCapabilities();

            // invoke the operation
            string capabilityName = "Shutdown-1.0";
            bool result = await collection.ExistsAsync(capabilityName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetACapabilityThatExtendsAVirtualMachineTargetResource()
        {
            // Generated from example definition: 2025-01-01/Capabilities_Get.json
            // this example is just showing the usage of "Capability_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosTargetResource created on azure
            // for more information of creating ChaosTargetResource, please refer to the document of ChaosTargetResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            string targetName = "Microsoft-VirtualMachine";
            ResourceIdentifier chaosTargetResourceId = ChaosTargetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentProviderNamespace, parentResourceType, parentResourceName, targetName);
            ChaosTargetResource chaosTarget = client.GetChaosTargetResource(chaosTargetResourceId);

            // get the collection of this ChaosCapabilityResource
            ChaosCapabilityCollection collection = chaosTarget.GetChaosCapabilities();

            // invoke the operation
            string capabilityName = "Shutdown-1.0";
            NullableResponse<ChaosCapabilityResource> response = await collection.GetIfExistsAsync(capabilityName);
            ChaosCapabilityResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ChaosCapabilityData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateUpdateACapabilityThatExtendsAVirtualMachineTargetResource()
        {
            // Generated from example definition: 2025-01-01/Capabilities_CreateOrUpdate.json
            // this example is just showing the usage of "Capability_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosTargetResource created on azure
            // for more information of creating ChaosTargetResource, please refer to the document of ChaosTargetResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            string targetName = "Microsoft-VirtualMachine";
            ResourceIdentifier chaosTargetResourceId = ChaosTargetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentProviderNamespace, parentResourceType, parentResourceName, targetName);
            ChaosTargetResource chaosTarget = client.GetChaosTargetResource(chaosTargetResourceId);

            // get the collection of this ChaosCapabilityResource
            ChaosCapabilityCollection collection = chaosTarget.GetChaosCapabilities();

            // invoke the operation
            string capabilityName = "Shutdown-1.0";
            ChaosCapabilityData data = new ChaosCapabilityData();
            ArmOperation<ChaosCapabilityResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, capabilityName, data);
            ChaosCapabilityResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosCapabilityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllCapabilitiesThatExtendAVirtualMachineTargetResource()
        {
            // Generated from example definition: 2025-01-01/Capabilities_List.json
            // this example is just showing the usage of "Capability_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosTargetResource created on azure
            // for more information of creating ChaosTargetResource, please refer to the document of ChaosTargetResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            string targetName = "Microsoft-VirtualMachine";
            ResourceIdentifier chaosTargetResourceId = ChaosTargetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentProviderNamespace, parentResourceType, parentResourceName, targetName);
            ChaosTargetResource chaosTarget = client.GetChaosTargetResource(chaosTargetResourceId);

            // get the collection of this ChaosCapabilityResource
            ChaosCapabilityCollection collection = chaosTarget.GetChaosCapabilities();

            // invoke the operation and iterate over the result
            await foreach (ChaosCapabilityResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ChaosCapabilityData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
