// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_TenantFileWorkspaceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/CreateFileWorkspace.json
            // this example is just showing the usage of "FileWorkspacesNoSubscription_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantFileWorkspaceResource
            TenantFileWorkspaceCollection collection = tenantResource.GetTenantFileWorkspaces();

            // invoke the operation
            string fileWorkspaceName = "testworkspace";
            ArmOperation<TenantFileWorkspaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fileWorkspaceName);
            TenantFileWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileWorkspaceDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDetailsOfAFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetFileWorkspaceDetails.json
            // this example is just showing the usage of "FileWorkspacesNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantFileWorkspaceResource
            TenantFileWorkspaceCollection collection = tenantResource.GetTenantFileWorkspaces();

            // invoke the operation
            string fileWorkspaceName = "testworkspace";
            TenantFileWorkspaceResource result = await collection.GetAsync(fileWorkspaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileWorkspaceDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDetailsOfAFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetFileWorkspaceDetails.json
            // this example is just showing the usage of "FileWorkspacesNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantFileWorkspaceResource
            TenantFileWorkspaceCollection collection = tenantResource.GetTenantFileWorkspaces();

            // invoke the operation
            string fileWorkspaceName = "testworkspace";
            bool result = await collection.ExistsAsync(fileWorkspaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDetailsOfAFileWorkspace()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetFileWorkspaceDetails.json
            // this example is just showing the usage of "FileWorkspacesNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantFileWorkspaceResource
            TenantFileWorkspaceCollection collection = tenantResource.GetTenantFileWorkspaces();

            // invoke the operation
            string fileWorkspaceName = "testworkspace";
            NullableResponse<TenantFileWorkspaceResource> response = await collection.GetIfExistsAsync(fileWorkspaceName);
            TenantFileWorkspaceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FileWorkspaceDetailData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
