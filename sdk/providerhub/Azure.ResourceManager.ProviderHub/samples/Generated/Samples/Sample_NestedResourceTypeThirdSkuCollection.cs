// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ProviderHub.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_NestedResourceTypeThirdSkuCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SkusCreateOrUpdateNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_CreateOrUpdateNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_CreateOrUpdateNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeThirdSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            NestedResourceTypeThirdSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird);

            // invoke the operation
            string sku = "testSku";
            ResourceTypeSkuData data = new ResourceTypeSkuData
            {
                Properties = new ResourceTypeSkuProperties(new ResourceTypeSkuSetting[]
            {
new ResourceTypeSkuSetting("freeSku")
{
Tier = "Tier1",
Kind = "Standard",
},
new ResourceTypeSkuSetting("premiumSku")
{
Tier = "Tier2",
Kind = "Premium",
Costs = {new ResourceTypeSkuCost("xxx")},
}
            }),
            };
            ArmOperation<NestedResourceTypeThirdSkuResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sku, data);
            NestedResourceTypeThirdSkuResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SkusGetNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_GetNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeThirdSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            NestedResourceTypeThirdSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird);

            // invoke the operation
            string sku = "testSku";
            NestedResourceTypeThirdSkuResource result = await collection.GetAsync(sku);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SkusListByResourceTypeRegistrationsNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_ListByResourceTypeRegistrationsNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_ListByResourceTypeRegistrationsNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeThirdSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            NestedResourceTypeThirdSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird);

            // invoke the operation and iterate over the result
            await foreach (NestedResourceTypeThirdSkuResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ResourceTypeSkuData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SkusGetNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_GetNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeThirdSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            NestedResourceTypeThirdSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird);

            // invoke the operation
            string sku = "testSku";
            bool result = await collection.ExistsAsync(sku);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SkusGetNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/stable/2020-11-20/examples/Skus_GetNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // get the collection of this NestedResourceTypeThirdSkuResource
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            NestedResourceTypeThirdSkuCollection collection = resourceTypeRegistration.GetNestedResourceTypeThirdSkus(nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird);

            // invoke the operation
            string sku = "testSku";
            NullableResponse<NestedResourceTypeThirdSkuResource> response = await collection.GetIfExistsAsync(sku);
            NestedResourceTypeThirdSkuResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ResourceTypeSkuData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
