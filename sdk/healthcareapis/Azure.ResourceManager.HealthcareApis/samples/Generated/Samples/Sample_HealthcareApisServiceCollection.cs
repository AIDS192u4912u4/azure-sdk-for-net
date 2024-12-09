// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisServiceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAServiceWithAllParameters()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceCreate.json
            // this example is just showing the usage of "Services_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            HealthcareApisServiceData data = new HealthcareApisServiceData(new AzureLocation("westus2"), HealthcareApisKind.FhirR4)
            {
                Properties = new HealthcareApisServiceProperties
                {
                    AccessPolicies = { new HealthcareApisServiceAccessPolicyEntry("c487e7d1-3210-41a3-8ccc-e9372b78da47"), new HealthcareApisServiceAccessPolicyEntry("5b307da8-43d4-492b-8b66-b0294ade872f") },
                    CosmosDbConfiguration = new HealthcareApisServiceCosmosDbConfiguration
                    {
                        OfferThroughput = 1000,
                        KeyVaultKeyUri = new Uri("https://my-vault.vault.azure.net/keys/my-key"),
                    },
                    AuthenticationConfiguration = new HealthcareApisServiceAuthenticationConfiguration
                    {
                        Authority = "https://login.microsoftonline.com/abfde7b2-df0f-47e6-aabf-2462b07508dc",
                        Audience = "https://azurehealthcareapis.com",
                        IsSmartProxyEnabled = true,
                    },
                    CorsConfiguration = new HealthcareApisServiceCorsConfiguration
                    {
                        Origins = { "*" },
                        Headers = { "*" },
                        Methods = { "DELETE", "GET", "OPTIONS", "PATCH", "POST", "PUT" },
                        MaxAge = 1440,
                        AllowCredentials = false,
                    },
                    ExportStorageAccountName = "existingStorageAccount",
                    PrivateEndpointConnections = { },
                    PublicNetworkAccess = HealthcareApisPublicNetworkAccess.Disabled,
                },
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags = { },
            };
            ArmOperation<HealthcareApisServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            HealthcareApisServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAServiceWithAllParametersAndCMKEnabledInADataSovereignRegion()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceCreateInDataSovereignRegionWithCmkEnabled.json
            // this example is just showing the usage of "Services_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            HealthcareApisServiceData data = new HealthcareApisServiceData(new AzureLocation("Southeast Asia"), HealthcareApisKind.FhirR4)
            {
                Properties = new HealthcareApisServiceProperties
                {
                    AccessPolicies = { new HealthcareApisServiceAccessPolicyEntry("c487e7d1-3210-41a3-8ccc-e9372b78da47"), new HealthcareApisServiceAccessPolicyEntry("5b307da8-43d4-492b-8b66-b0294ade872f") },
                    CosmosDbConfiguration = new HealthcareApisServiceCosmosDbConfiguration
                    {
                        OfferThroughput = 1000,
                        KeyVaultKeyUri = new Uri("https://my-vault.vault.azure.net/keys/my-key"),
                        CrossTenantCmkApplicationId = Guid.Parse("de3fbeef-8c3a-428e-8b9f-4d229c8a85f4"),
                    },
                    AuthenticationConfiguration = new HealthcareApisServiceAuthenticationConfiguration
                    {
                        Authority = "https://login.microsoftonline.com/abfde7b2-df0f-47e6-aabf-2462b07508dc",
                        Audience = "https://azurehealthcareapis.com",
                        IsSmartProxyEnabled = true,
                    },
                    CorsConfiguration = new HealthcareApisServiceCorsConfiguration
                    {
                        Origins = { "*" },
                        Headers = { "*" },
                        Methods = { "DELETE", "GET", "OPTIONS", "PATCH", "POST", "PUT" },
                        MaxAge = 1440,
                        AllowCredentials = false,
                    },
                    ExportStorageAccountName = "existingStorageAccount",
                    PrivateEndpointConnections = { },
                    PublicNetworkAccess = HealthcareApisPublicNetworkAccess.Disabled,
                },
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags = { },
            };
            ArmOperation<HealthcareApisServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            HealthcareApisServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAServiceWithMinimumParameters()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceCreateMinimum.json
            // this example is just showing the usage of "Services_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service2";
            HealthcareApisServiceData data = new HealthcareApisServiceData(new AzureLocation("westus2"), HealthcareApisKind.FhirR4)
            {
                Properties = new HealthcareApisServiceProperties
                {
                    AccessPolicies = { new HealthcareApisServiceAccessPolicyEntry("c487e7d1-3210-41a3-8ccc-e9372b78da47") },
                },
                Tags = { },
            };
            ArmOperation<HealthcareApisServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            HealthcareApisServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetMetadata()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceGet.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            HealthcareApisServiceResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetMetadataForCMKEnabledServiceInDataSovereignRegion()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceGetInDataSovereignRegionWithCmkEnabled.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            HealthcareApisServiceResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllServicesInResourceGroup()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceListByResourceGroup.json
            // this example is just showing the usage of "Services_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgname";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation and iterate over the result
            await foreach (HealthcareApisServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetMetadata()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceGet.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetMetadataForCMKEnabledServiceInDataSovereignRegion()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceGetInDataSovereignRegionWithCmkEnabled.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetMetadata()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceGet.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            NullableResponse<HealthcareApisServiceResource> response = await collection.GetIfExistsAsync(resourceName);
            HealthcareApisServiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisServiceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetMetadataForCMKEnabledServiceInDataSovereignRegion()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/legacy/ServiceGetInDataSovereignRegionWithCmkEnabled.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HealthcareApisServiceResource
            HealthcareApisServiceCollection collection = resourceGroupResource.GetHealthcareApisServices();

            // invoke the operation
            string resourceName = "service1";
            NullableResponse<HealthcareApisServiceResource> response = await collection.GetIfExistsAsync(resourceName);
            HealthcareApisServiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisServiceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
