// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseDedicatedSqlMinimalTlsSettingResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceManagedSqlServerDedicatedSqlMinimalTlsSettings()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlServerDedicatedSQLminimalTlsSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDedicatedSqlMinimalTlsSettingResource created on azure
            // for more information of creating SynapseDedicatedSqlMinimalTlsSettingResource, please refer to the document of SynapseDedicatedSqlMinimalTlsSettingResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "workspace-6852";
            string workspaceName = "workspace-2080";
            string dedicatedSQLminimalTlsSettingsName = "default";
            ResourceIdentifier synapseDedicatedSqlMinimalTlsSettingResourceId = SynapseDedicatedSqlMinimalTlsSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dedicatedSQLminimalTlsSettingsName);
            SynapseDedicatedSqlMinimalTlsSettingResource synapseDedicatedSqlMinimalTlsSetting = client.GetSynapseDedicatedSqlMinimalTlsSettingResource(synapseDedicatedSqlMinimalTlsSettingResourceId);

            // invoke the operation
            SynapseDedicatedSqlMinimalTlsSettingResource result = await synapseDedicatedSqlMinimalTlsSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDedicatedSqlMinimalTlsSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
