// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MachineLearningResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MachineLearningResourceGroupMockingExtension"/> class for mocking. </summary>
        protected MachineLearningResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MachineLearningWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MachineLearningWorkspaceResources and their operations over a MachineLearningWorkspaceResource. </returns>
        public virtual MachineLearningWorkspaceCollection GetMachineLearningWorkspaces()
        {
            return GetCachedClient(Client => new MachineLearningWorkspaceCollection(Client, Id));
        }

        /// <summary>
        /// Gets the properties of the specified machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MachineLearningWorkspaceResource>> GetMachineLearningWorkspaceAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetMachineLearningWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified machine learning workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<MachineLearningWorkspaceResource> GetMachineLearningWorkspace(string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetMachineLearningWorkspaces().Get(workspaceName, cancellationToken);
        }
    }
}
