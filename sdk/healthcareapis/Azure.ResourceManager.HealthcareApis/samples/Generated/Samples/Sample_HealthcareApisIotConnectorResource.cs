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
using NUnit.Framework;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisIotConnectorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnIoTConnector()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/iotconnectors/iotconnector_Get.json
            // this example is just showing the usage of "IotConnectors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // invoke the operation
            HealthcareApisIotConnectorResource result = await healthcareApisIotConnector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnIoTConnector()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/iotconnectors/iotconnector_Delete.json
            // this example is just showing the usage of "IotConnectors_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // invoke the operation
            await healthcareApisIotConnector.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnIoTConnector()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/iotconnectors/iotconnector_Patch.json
            // this example is just showing the usage of "IotConnectors_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotConnectorResource created on azure
            // for more information of creating HealthcareApisIotConnectorResource, please refer to the document of HealthcareApisIotConnectorResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            ResourceIdentifier healthcareApisIotConnectorResourceId = HealthcareApisIotConnectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName);
            HealthcareApisIotConnectorResource healthcareApisIotConnector = client.GetHealthcareApisIotConnectorResource(healthcareApisIotConnectorResourceId);

            // invoke the operation
            HealthcareApisIotConnectorPatch patch = new HealthcareApisIotConnectorPatch
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string"
},
            };
            ArmOperation<HealthcareApisIotConnectorResource> lro = await healthcareApisIotConnector.UpdateAsync(WaitUntil.Completed, patch);
            HealthcareApisIotConnectorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
