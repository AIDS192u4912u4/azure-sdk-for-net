// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevTestLabs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabFormulaCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_FormulasCreateOrUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Formulas_CreateOrUpdate.json
            // this example is just showing the usage of "Formulas_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabFormulaResource
            DevTestLabFormulaCollection collection = devTestLab.GetDevTestLabFormulas();

            // invoke the operation
            string name = "{formulaName}";
            DevTestLabFormulaData data = new DevTestLabFormulaData(new AzureLocation("{location}"))
            {
                Description = "Formula using a Linux base",
                FormulaContent = new DevTestLabVmCreationContent
                {
                    Location = new AzureLocation("{location}"),
                    Notes = "Ubuntu Server 20.10",
                    Size = "Standard_B1ms",
                    UserName = "user",
                    IsAuthenticationWithSshKey = false,
                    LabSubnetName = "Dtl{labName}Subnet",
                    LabVirtualNetworkId = new ResourceIdentifier("/virtualnetworks/dtl{labName}"),
                    DisallowPublicIPAddress = true,
                    Artifacts = {new DevTestLabArtifactInstallInfo
{
ArtifactId = "/artifactsources/{artifactSourceName}/artifacts/linux-install-nodejs",
Parameters = {},
}},
                    GalleryImageReference = new DevTestLabGalleryImageReference
                    {
                        Offer = "0001-com-ubuntu-server-groovy",
                        Publisher = "canonical",
                        Sku = "20_10",
                        OSType = "Linux",
                        Version = "latest",
                    },
                    NetworkInterface = new DevTestLabNetworkInterface
                    {
                        SharedPublicIPAddressInboundNatRules = {new DevTestLabInboundNatRule
{
TransportProtocol = DevTestLabTransportProtocol.Tcp,
BackendPort = 22,
}},
                    },
                    AllowClaim = false,
                    StorageType = "Standard",
                },
            };
            ArmOperation<DevTestLabFormulaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            DevTestLabFormulaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabFormulaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FormulasGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Formulas_Get.json
            // this example is just showing the usage of "Formulas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabFormulaResource
            DevTestLabFormulaCollection collection = devTestLab.GetDevTestLabFormulas();

            // invoke the operation
            string name = "{formulaName}";
            DevTestLabFormulaResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabFormulaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_FormulasList()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Formulas_List.json
            // this example is just showing the usage of "Formulas_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabFormulaResource
            DevTestLabFormulaCollection collection = devTestLab.GetDevTestLabFormulas();

            // invoke the operation and iterate over the result
            await foreach (DevTestLabFormulaResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabFormulaData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_FormulasGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Formulas_Get.json
            // this example is just showing the usage of "Formulas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabFormulaResource
            DevTestLabFormulaCollection collection = devTestLab.GetDevTestLabFormulas();

            // invoke the operation
            string name = "{formulaName}";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_FormulasGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Formulas_Get.json
            // this example is just showing the usage of "Formulas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabResource created on azure
            // for more information of creating DevTestLabResource, please refer to the document of DevTestLabResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            ResourceIdentifier devTestLabResourceId = DevTestLabResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName);
            DevTestLabResource devTestLab = client.GetDevTestLabResource(devTestLabResourceId);

            // get the collection of this DevTestLabFormulaResource
            DevTestLabFormulaCollection collection = devTestLab.GetDevTestLabFormulas();

            // invoke the operation
            string name = "{formulaName}";
            NullableResponse<DevTestLabFormulaResource> response = await collection.GetIfExistsAsync(name);
            DevTestLabFormulaResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabFormulaData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
