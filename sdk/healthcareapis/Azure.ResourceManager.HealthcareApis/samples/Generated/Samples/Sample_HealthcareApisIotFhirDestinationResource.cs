// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HealthcareApis.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisIotFhirDestinationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnIoTConnectorDestination()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/iotconnectors/iotconnector_fhirdestination_Get.json
            // this example is just showing the usage of "IotConnectorFhirDestination_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotFhirDestinationResource created on azure
            // for more information of creating HealthcareApisIotFhirDestinationResource, please refer to the document of HealthcareApisIotFhirDestinationResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            string fhirDestinationName = "dest1";
            ResourceIdentifier healthcareApisIotFhirDestinationResourceId = HealthcareApisIotFhirDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName);
            HealthcareApisIotFhirDestinationResource healthcareApisIotFhirDestination = client.GetHealthcareApisIotFhirDestinationResource(healthcareApisIotFhirDestinationResourceId);

            // invoke the operation
            HealthcareApisIotFhirDestinationResource result = await healthcareApisIotFhirDestination.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotFhirDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnIoTConnectorDestination()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/iotconnectors/iotconnector_fhirdestination_Delete.json
            // this example is just showing the usage of "IotConnectorFhirDestination_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotFhirDestinationResource created on azure
            // for more information of creating HealthcareApisIotFhirDestinationResource, please refer to the document of HealthcareApisIotFhirDestinationResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            string fhirDestinationName = "dest1";
            ResourceIdentifier healthcareApisIotFhirDestinationResourceId = HealthcareApisIotFhirDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName);
            HealthcareApisIotFhirDestinationResource healthcareApisIotFhirDestination = client.GetHealthcareApisIotFhirDestinationResource(healthcareApisIotFhirDestinationResourceId);

            // invoke the operation
            await healthcareApisIotFhirDestination.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAnIotConnectorFHIRDestination()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2024-03-31/examples/iotconnectors/iotconnector_fhirdestination_Create.json
            // this example is just showing the usage of "IotConnectorFhirDestination_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisIotFhirDestinationResource created on azure
            // for more information of creating HealthcareApisIotFhirDestinationResource, please refer to the document of HealthcareApisIotFhirDestinationResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            string iotConnectorName = "blue";
            string fhirDestinationName = "dest1";
            ResourceIdentifier healthcareApisIotFhirDestinationResourceId = HealthcareApisIotFhirDestinationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName);
            HealthcareApisIotFhirDestinationResource healthcareApisIotFhirDestination = client.GetHealthcareApisIotFhirDestinationResource(healthcareApisIotFhirDestinationResourceId);

            // invoke the operation
            HealthcareApisIotFhirDestinationData data = new HealthcareApisIotFhirDestinationData(HealthcareApisIotIdentityResolutionType.Create, new ResourceIdentifier("subscriptions/11111111-2222-3333-4444-555566667777/resourceGroups/myrg/providers/Microsoft.HealthcareApis/workspaces/myworkspace/fhirservices/myfhirservice"), new HealthcareApisIotMappingProperties
            {
                Content = BinaryData.FromObjectAsJson(new
                {
                    template = new object[]
            {
new
{
template = new
{
codes = new object[]
{
new
{
code = "8867-4",
display = "Heart rate",
system = "http://loinc.org",
}
},
periodInterval = "60",
typeName = "heartrate",
value = new
{
defaultPeriod = "5000",
unit = "count/min",
valueName = "hr",
valueType = "SampledData",
},
},
templateType = "CodeValueFhir",
}
            },
                    templateType = "CollectionFhirTemplate",
                }),
            })
            {
                Location = new AzureLocation("westus"),
            };
            ArmOperation<HealthcareApisIotFhirDestinationResource> lro = await healthcareApisIotFhirDestination.UpdateAsync(WaitUntil.Completed, data);
            HealthcareApisIotFhirDestinationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotFhirDestinationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
