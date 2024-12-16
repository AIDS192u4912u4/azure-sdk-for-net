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
    public partial class Sample_SynapseSqlPoolColumnResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDatabaseColumn()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolColumnGet.json
            // this example is just showing the usage of "SqlPoolColumns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolColumnResource created on azure
            // for more information of creating SynapseSqlPoolColumnResource, please refer to the document of SynapseSqlPoolColumnResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "serverName";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "table1";
            string columnName = "column1";
            ResourceIdentifier synapseSqlPoolColumnResourceId = SynapseSqlPoolColumnResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName);
            SynapseSqlPoolColumnResource synapseSqlPoolColumn = client.GetSynapseSqlPoolColumnResource(synapseSqlPoolColumnResourceId);

            // invoke the operation
            SynapseSqlPoolColumnResource result = await synapseSqlPoolColumn.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseSqlPoolColumnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task EnableRecommendationSqlPoolSensitivityLabel_EnablesSensitivityRecommendationsOnAGivenColumn()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/RecommendedColumnSensitivityLabelEnable.json
            // this example is just showing the usage of "SqlPoolSensitivityLabels_EnableRecommendation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolColumnResource created on azure
            // for more information of creating SynapseSqlPoolColumnResource, please refer to the document of SynapseSqlPoolColumnResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "myServer";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "myTable";
            string columnName = "myColumn";
            ResourceIdentifier synapseSqlPoolColumnResourceId = SynapseSqlPoolColumnResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName);
            SynapseSqlPoolColumnResource synapseSqlPoolColumn = client.GetSynapseSqlPoolColumnResource(synapseSqlPoolColumnResourceId);

            // invoke the operation
            await synapseSqlPoolColumn.EnableRecommendationSqlPoolSensitivityLabelAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DisableRecommendationSqlPoolSensitivityLabel_DisablesSensitivityRecommendationsOnAGivenColumn()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/RecommendedColumnSensitivityLabelDisable.json
            // this example is just showing the usage of "SqlPoolSensitivityLabels_DisableRecommendation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolColumnResource created on azure
            // for more information of creating SynapseSqlPoolColumnResource, please refer to the document of SynapseSqlPoolColumnResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string workspaceName = "myServer";
            string sqlPoolName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "myTable";
            string columnName = "myColumn";
            ResourceIdentifier synapseSqlPoolColumnResourceId = SynapseSqlPoolColumnResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, columnName);
            SynapseSqlPoolColumnResource synapseSqlPoolColumn = client.GetSynapseSqlPoolColumnResource(synapseSqlPoolColumnResourceId);

            // invoke the operation
            await synapseSqlPoolColumn.DisableRecommendationSqlPoolSensitivityLabelAsync();

            Console.WriteLine("Succeeded");
        }
    }
}
