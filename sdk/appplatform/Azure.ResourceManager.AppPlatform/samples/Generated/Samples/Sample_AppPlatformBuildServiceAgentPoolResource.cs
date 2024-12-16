// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppPlatform.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformBuildServiceAgentPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BuildServiceAgentPoolGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildServiceAgentPool_Get.json
            // this example is just showing the usage of "BuildServiceAgentPool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildServiceAgentPoolResource created on azure
            // for more information of creating AppPlatformBuildServiceAgentPoolResource, please refer to the document of AppPlatformBuildServiceAgentPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string agentPoolName = "default";
            ResourceIdentifier appPlatformBuildServiceAgentPoolResourceId = AppPlatformBuildServiceAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, agentPoolName);
            AppPlatformBuildServiceAgentPoolResource appPlatformBuildServiceAgentPool = client.GetAppPlatformBuildServiceAgentPoolResource(appPlatformBuildServiceAgentPoolResourceId);

            // invoke the operation
            AppPlatformBuildServiceAgentPoolResource result = await appPlatformBuildServiceAgentPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBuildServiceAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BuildServiceAgentPoolUpdatePut()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildServiceAgentPool_UpdatePut.json
            // this example is just showing the usage of "BuildServiceAgentPool_UpdatePut" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildServiceAgentPoolResource created on azure
            // for more information of creating AppPlatformBuildServiceAgentPoolResource, please refer to the document of AppPlatformBuildServiceAgentPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string agentPoolName = "default";
            ResourceIdentifier appPlatformBuildServiceAgentPoolResourceId = AppPlatformBuildServiceAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, agentPoolName);
            AppPlatformBuildServiceAgentPoolResource appPlatformBuildServiceAgentPool = client.GetAppPlatformBuildServiceAgentPoolResource(appPlatformBuildServiceAgentPoolResourceId);

            // invoke the operation
            AppPlatformBuildServiceAgentPoolData data = new AppPlatformBuildServiceAgentPoolData
            {
                Properties = new AppPlatformBuildServiceAgentPoolProperties
                {
                    PoolSize = new BuildServiceAgentPoolSizeProperties
                    {
                        Name = "S3",
                    },
                },
            };
            ArmOperation<AppPlatformBuildServiceAgentPoolResource> lro = await appPlatformBuildServiceAgentPool.UpdateAsync(WaitUntil.Completed, data);
            AppPlatformBuildServiceAgentPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBuildServiceAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
