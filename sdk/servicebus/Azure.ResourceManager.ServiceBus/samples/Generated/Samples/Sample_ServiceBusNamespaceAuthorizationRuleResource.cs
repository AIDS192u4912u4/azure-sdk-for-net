// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceBus.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusNamespaceAuthorizationRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/NameSpaces/SBNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusNamespaceAuthorizationRuleResource, please refer to the document of ServiceBusNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6914";
            string authorizationRuleName = "sdk-AuthRules-1788";
            ResourceIdentifier serviceBusNamespaceAuthorizationRuleResourceId = ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            ServiceBusNamespaceAuthorizationRuleResource serviceBusNamespaceAuthorizationRule = client.GetServiceBusNamespaceAuthorizationRuleResource(serviceBusNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusNamespaceAuthorizationRuleResource result = await serviceBusNamespaceAuthorizationRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NameSpaceAuthorizationRuleDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/NameSpaces/SBNameSpaceAuthorizationRuleDelete.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusNamespaceAuthorizationRuleResource, please refer to the document of ServiceBusNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-6914";
            string authorizationRuleName = "sdk-AuthRules-1788";
            ResourceIdentifier serviceBusNamespaceAuthorizationRuleResourceId = ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            ServiceBusNamespaceAuthorizationRuleResource serviceBusNamespaceAuthorizationRule = client.GetServiceBusNamespaceAuthorizationRuleResource(serviceBusNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            await serviceBusNamespaceAuthorizationRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NameSpaceAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/NameSpaces/SBNameSpaceAuthorizationRuleCreate.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusNamespaceAuthorizationRuleResource, please refer to the document of ServiceBusNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6914";
            string authorizationRuleName = "sdk-AuthRules-1788";
            ResourceIdentifier serviceBusNamespaceAuthorizationRuleResourceId = ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            ServiceBusNamespaceAuthorizationRuleResource serviceBusNamespaceAuthorizationRule = client.GetServiceBusNamespaceAuthorizationRuleResource(serviceBusNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusAuthorizationRuleData data = new ServiceBusAuthorizationRuleData
            {
                Rights = { ServiceBusAccessRight.Listen, ServiceBusAccessRight.Send },
            };
            ArmOperation<ServiceBusNamespaceAuthorizationRuleResource> lro = await serviceBusNamespaceAuthorizationRule.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusNamespaceAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetKeys_NameSpaceAuthorizationRuleListKey()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/NameSpaces/SBNameSpaceAuthorizationRuleListKey.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusNamespaceAuthorizationRuleResource, please refer to the document of ServiceBusNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-6914";
            string authorizationRuleName = "sdk-AuthRules-1788";
            ResourceIdentifier serviceBusNamespaceAuthorizationRuleResourceId = ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            ServiceBusNamespaceAuthorizationRuleResource serviceBusNamespaceAuthorizationRule = client.GetServiceBusNamespaceAuthorizationRuleResource(serviceBusNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusAccessKeys result = await serviceBusNamespaceAuthorizationRule.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateKeys_NameSpaceAuthorizationRuleRegenerateKey()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/NameSpaces/SBNameSpaceAuthorizationRuleRegenerateKey.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusNamespaceAuthorizationRuleResource, please refer to the document of ServiceBusNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-6914";
            string authorizationRuleName = "sdk-AuthRules-1788";
            ResourceIdentifier serviceBusNamespaceAuthorizationRuleResourceId = ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            ServiceBusNamespaceAuthorizationRuleResource serviceBusNamespaceAuthorizationRule = client.GetServiceBusNamespaceAuthorizationRuleResource(serviceBusNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusRegenerateAccessKeyContent content = new ServiceBusRegenerateAccessKeyContent(ServiceBusAccessKeyType.PrimaryKey);
            ServiceBusAccessKeys result = await serviceBusNamespaceAuthorizationRule.RegenerateKeysAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
