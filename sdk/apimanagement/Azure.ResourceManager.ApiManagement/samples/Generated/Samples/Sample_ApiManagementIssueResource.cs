// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementIssueResource
    {
        // ApiManagementGetIssue
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetIssue()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetIssue.json
            // this example is just showing the usage of "Issue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementIssueResource created on azure
            // for more information of creating ApiManagementIssueResource, please refer to the document of ApiManagementIssueResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier apiManagementIssueResourceId = ApiManagementIssueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, issueId);
            ApiManagementIssueResource apiManagementIssue = client.GetApiManagementIssueResource(apiManagementIssueResourceId);

            // invoke the operation
            ApiManagementIssueResource result = await apiManagementIssue.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IssueContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
