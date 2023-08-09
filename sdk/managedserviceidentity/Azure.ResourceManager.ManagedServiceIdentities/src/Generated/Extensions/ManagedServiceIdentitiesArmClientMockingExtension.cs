// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagedServiceIdentities;

namespace Azure.ResourceManager.ManagedServiceIdentities.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class ManagedServiceIdentitiesArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ManagedServiceIdentitiesArmClientMockingExtension"/> class for mocking. </summary>
        protected ManagedServiceIdentitiesArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServiceIdentitiesArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedServiceIdentitiesArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal ManagedServiceIdentitiesArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a SystemAssignedIdentityResource along with the instance operations that can be performed on it in the ArmClient. </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <returns> Returns a <see cref="SystemAssignedIdentityResource" /> object. </returns>
        public virtual SystemAssignedIdentityResource GetSystemAssignedIdentity(ResourceIdentifier scope)
        {
            return new SystemAssignedIdentityResource(Client, scope.AppendProviderResource("Microsoft.ManagedIdentity", "identities", "default"));
        }

        /// <summary>
        /// Gets an object representing a <see cref="SystemAssignedIdentityResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SystemAssignedIdentityResource.CreateResourceIdentifier" /> to create a <see cref="SystemAssignedIdentityResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SystemAssignedIdentityResource" /> object. </returns>
        public virtual SystemAssignedIdentityResource GetSystemAssignedIdentityResource(ResourceIdentifier id)
        {
            SystemAssignedIdentityResource.ValidateResourceId(id);
            return new SystemAssignedIdentityResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="UserAssignedIdentityResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UserAssignedIdentityResource.CreateResourceIdentifier" /> to create an <see cref="UserAssignedIdentityResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UserAssignedIdentityResource" /> object. </returns>
        public virtual UserAssignedIdentityResource GetUserAssignedIdentityResource(ResourceIdentifier id)
        {
            UserAssignedIdentityResource.ValidateResourceId(id);
            return new UserAssignedIdentityResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FederatedIdentityCredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FederatedIdentityCredentialResource.CreateResourceIdentifier" /> to create a <see cref="FederatedIdentityCredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FederatedIdentityCredentialResource" /> object. </returns>
        public virtual FederatedIdentityCredentialResource GetFederatedIdentityCredentialResource(ResourceIdentifier id)
        {
            FederatedIdentityCredentialResource.ValidateResourceId(id);
            return new FederatedIdentityCredentialResource(Client, id);
        }
    }
}
