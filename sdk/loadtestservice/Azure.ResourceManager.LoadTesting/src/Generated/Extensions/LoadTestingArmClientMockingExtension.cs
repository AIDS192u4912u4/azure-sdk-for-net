// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.LoadTesting;

namespace Azure.ResourceManager.LoadTesting.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class LoadTestingArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="LoadTestingArmClientMockingExtension"/> class for mocking. </summary>
        protected LoadTestingArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadTestingArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadTestingArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal LoadTestingArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="LoadTestingQuotaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LoadTestingQuotaResource.CreateResourceIdentifier" /> to create a <see cref="LoadTestingQuotaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LoadTestingQuotaResource" /> object. </returns>
        public virtual LoadTestingQuotaResource GetLoadTestingQuotaResource(ResourceIdentifier id)
        {
            LoadTestingQuotaResource.ValidateResourceId(id);
            return new LoadTestingQuotaResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LoadTestingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LoadTestingResource.CreateResourceIdentifier" /> to create a <see cref="LoadTestingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LoadTestingResource" /> object. </returns>
        public virtual LoadTestingResource GetLoadTestingResource(ResourceIdentifier id)
        {
            LoadTestingResource.ValidateResourceId(id);
            return new LoadTestingResource(Client, id);
        }
    }
}
