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
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class PolicyInsightsTenantMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="PolicyInsightsTenantMockingExtension"/> class for mocking. </summary>
        protected PolicyInsightsTenantMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyInsightsTenantMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyInsightsTenantMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PolicyMetadataResources in the TenantResource. </summary>
        /// <returns> An object representing collection of PolicyMetadataResources and their operations over a PolicyMetadataResource. </returns>
        public virtual PolicyMetadataCollection GetAllPolicyMetadata()
        {
            return GetCachedClient(Client => new PolicyMetadataCollection(Client, Id));
        }

        /// <summary>
        /// Get policy metadata resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyMetadata_GetResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the policy metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PolicyMetadataResource>> GetPolicyMetadataAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetAllPolicyMetadata().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get policy metadata resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyMetadata_GetResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the policy metadata resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<PolicyMetadataResource> GetPolicyMetadata(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetAllPolicyMetadata().Get(resourceName, cancellationToken);
        }
    }
}
