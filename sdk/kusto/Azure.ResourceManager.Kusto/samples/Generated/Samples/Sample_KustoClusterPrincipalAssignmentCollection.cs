// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Kusto.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Kusto.Samples
{
    public partial class Sample_KustoClusterPrincipalAssignmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_KustoClusterPrincipalAssignmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoClusterPrincipalAssignmentsCreateOrUpdate.json
            // this example is just showing the usage of "ClusterPrincipalAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoClusterResource created on azure
            // for more information of creating KustoClusterResource, please refer to the document of KustoClusterResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            ResourceIdentifier kustoClusterResourceId = KustoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            KustoClusterResource kustoCluster = client.GetKustoClusterResource(kustoClusterResourceId);

            // get the collection of this KustoClusterPrincipalAssignmentResource
            KustoClusterPrincipalAssignmentCollection collection = kustoCluster.GetKustoClusterPrincipalAssignments();

            // invoke the operation
            string principalAssignmentName = "kustoprincipal1";
            KustoClusterPrincipalAssignmentData data = new KustoClusterPrincipalAssignmentData
            {
                ClusterPrincipalId = "87654321-1234-1234-1234-123456789123",
                Role = KustoClusterPrincipalRole.AllDatabasesAdmin,
                TenantId = Guid.Parse("12345678-1234-1234-1234-123456789123"),
                PrincipalType = KustoPrincipalAssignmentType.App,
            };
            ArmOperation<KustoClusterPrincipalAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, principalAssignmentName, data);
            KustoClusterPrincipalAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoClusterPrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoClusterPrincipalAssignmentsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoClusterPrincipalAssignmentsGet.json
            // this example is just showing the usage of "ClusterPrincipalAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoClusterResource created on azure
            // for more information of creating KustoClusterResource, please refer to the document of KustoClusterResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            ResourceIdentifier kustoClusterResourceId = KustoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            KustoClusterResource kustoCluster = client.GetKustoClusterResource(kustoClusterResourceId);

            // get the collection of this KustoClusterPrincipalAssignmentResource
            KustoClusterPrincipalAssignmentCollection collection = kustoCluster.GetKustoClusterPrincipalAssignments();

            // invoke the operation
            string principalAssignmentName = "kustoprincipal1";
            KustoClusterPrincipalAssignmentResource result = await collection.GetAsync(principalAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoClusterPrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_KustoPrincipalAssignmentsList()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoClusterPrincipalAssignmentsList.json
            // this example is just showing the usage of "ClusterPrincipalAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoClusterResource created on azure
            // for more information of creating KustoClusterResource, please refer to the document of KustoClusterResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            ResourceIdentifier kustoClusterResourceId = KustoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            KustoClusterResource kustoCluster = client.GetKustoClusterResource(kustoClusterResourceId);

            // get the collection of this KustoClusterPrincipalAssignmentResource
            KustoClusterPrincipalAssignmentCollection collection = kustoCluster.GetKustoClusterPrincipalAssignments();

            // invoke the operation and iterate over the result
            await foreach (KustoClusterPrincipalAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KustoClusterPrincipalAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_KustoClusterPrincipalAssignmentsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoClusterPrincipalAssignmentsGet.json
            // this example is just showing the usage of "ClusterPrincipalAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoClusterResource created on azure
            // for more information of creating KustoClusterResource, please refer to the document of KustoClusterResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            ResourceIdentifier kustoClusterResourceId = KustoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            KustoClusterResource kustoCluster = client.GetKustoClusterResource(kustoClusterResourceId);

            // get the collection of this KustoClusterPrincipalAssignmentResource
            KustoClusterPrincipalAssignmentCollection collection = kustoCluster.GetKustoClusterPrincipalAssignments();

            // invoke the operation
            string principalAssignmentName = "kustoprincipal1";
            bool result = await collection.ExistsAsync(principalAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_KustoClusterPrincipalAssignmentsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoClusterPrincipalAssignmentsGet.json
            // this example is just showing the usage of "ClusterPrincipalAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoClusterResource created on azure
            // for more information of creating KustoClusterResource, please refer to the document of KustoClusterResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            ResourceIdentifier kustoClusterResourceId = KustoClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            KustoClusterResource kustoCluster = client.GetKustoClusterResource(kustoClusterResourceId);

            // get the collection of this KustoClusterPrincipalAssignmentResource
            KustoClusterPrincipalAssignmentCollection collection = kustoCluster.GetKustoClusterPrincipalAssignments();

            // invoke the operation
            string principalAssignmentName = "kustoprincipal1";
            NullableResponse<KustoClusterPrincipalAssignmentResource> response = await collection.GetIfExistsAsync(principalAssignmentName);
            KustoClusterPrincipalAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KustoClusterPrincipalAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
