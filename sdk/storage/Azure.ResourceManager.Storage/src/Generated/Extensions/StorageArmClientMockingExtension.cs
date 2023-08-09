// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class StorageArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="StorageArmClientMockingExtension"/> class for mocking. </summary>
        protected StorageArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StorageArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal StorageArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountResource" /> object. </returns>
        public virtual StorageAccountResource GetStorageAccountResource(ResourceIdentifier id)
        {
            StorageAccountResource.ValidateResourceId(id);
            return new StorageAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeletedAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAccountResource.CreateResourceIdentifier" /> to create a <see cref="DeletedAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccountResource" /> object. </returns>
        public virtual DeletedAccountResource GetDeletedAccountResource(ResourceIdentifier id)
        {
            DeletedAccountResource.ValidateResourceId(id);
            return new DeletedAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountManagementPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountManagementPolicyResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountManagementPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountManagementPolicyResource" /> object. </returns>
        public virtual StorageAccountManagementPolicyResource GetStorageAccountManagementPolicyResource(ResourceIdentifier id)
        {
            StorageAccountManagementPolicyResource.ValidateResourceId(id);
            return new StorageAccountManagementPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BlobInventoryPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobInventoryPolicyResource.CreateResourceIdentifier" /> to create a <see cref="BlobInventoryPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicyResource" /> object. </returns>
        public virtual BlobInventoryPolicyResource GetBlobInventoryPolicyResource(ResourceIdentifier id)
        {
            BlobInventoryPolicyResource.ValidateResourceId(id);
            return new BlobInventoryPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StoragePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StoragePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="StoragePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StoragePrivateEndpointConnectionResource" /> object. </returns>
        public virtual StoragePrivateEndpointConnectionResource GetStoragePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            StoragePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new StoragePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ObjectReplicationPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ObjectReplicationPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ObjectReplicationPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicyResource" /> object. </returns>
        public virtual ObjectReplicationPolicyResource GetObjectReplicationPolicyResource(ResourceIdentifier id)
        {
            ObjectReplicationPolicyResource.ValidateResourceId(id);
            return new ObjectReplicationPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageAccountLocalUserResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageAccountLocalUserResource.CreateResourceIdentifier" /> to create a <see cref="StorageAccountLocalUserResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccountLocalUserResource" /> object. </returns>
        public virtual StorageAccountLocalUserResource GetStorageAccountLocalUserResource(ResourceIdentifier id)
        {
            StorageAccountLocalUserResource.ValidateResourceId(id);
            return new StorageAccountLocalUserResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EncryptionScopeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EncryptionScopeResource.CreateResourceIdentifier" /> to create an <see cref="EncryptionScopeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScopeResource" /> object. </returns>
        public virtual EncryptionScopeResource GetEncryptionScopeResource(ResourceIdentifier id)
        {
            EncryptionScopeResource.ValidateResourceId(id);
            return new EncryptionScopeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BlobServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobServiceResource.CreateResourceIdentifier" /> to create a <see cref="BlobServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobServiceResource" /> object. </returns>
        public virtual BlobServiceResource GetBlobServiceResource(ResourceIdentifier id)
        {
            BlobServiceResource.ValidateResourceId(id);
            return new BlobServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BlobContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlobContainerResource.CreateResourceIdentifier" /> to create a <see cref="BlobContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainerResource" /> object. </returns>
        public virtual BlobContainerResource GetBlobContainerResource(ResourceIdentifier id)
        {
            BlobContainerResource.ValidateResourceId(id);
            return new BlobContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ImmutabilityPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ImmutabilityPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ImmutabilityPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicyResource" /> object. </returns>
        public virtual ImmutabilityPolicyResource GetImmutabilityPolicyResource(ResourceIdentifier id)
        {
            ImmutabilityPolicyResource.ValidateResourceId(id);
            return new ImmutabilityPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FileServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileServiceResource.CreateResourceIdentifier" /> to create a <see cref="FileServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileServiceResource" /> object. </returns>
        public virtual FileServiceResource GetFileServiceResource(ResourceIdentifier id)
        {
            FileServiceResource.ValidateResourceId(id);
            return new FileServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FileShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FileShareResource.CreateResourceIdentifier" /> to create a <see cref="FileShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShareResource" /> object. </returns>
        public virtual FileShareResource GetFileShareResource(ResourceIdentifier id)
        {
            FileShareResource.ValidateResourceId(id);
            return new FileShareResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="QueueServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QueueServiceResource.CreateResourceIdentifier" /> to create a <see cref="QueueServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QueueServiceResource" /> object. </returns>
        public virtual QueueServiceResource GetQueueServiceResource(ResourceIdentifier id)
        {
            QueueServiceResource.ValidateResourceId(id);
            return new QueueServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageQueueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageQueueResource.CreateResourceIdentifier" /> to create a <see cref="StorageQueueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageQueueResource" /> object. </returns>
        public virtual StorageQueueResource GetStorageQueueResource(ResourceIdentifier id)
        {
            StorageQueueResource.ValidateResourceId(id);
            return new StorageQueueResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TableServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TableServiceResource.CreateResourceIdentifier" /> to create a <see cref="TableServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableServiceResource" /> object. </returns>
        public virtual TableServiceResource GetTableServiceResource(ResourceIdentifier id)
        {
            TableServiceResource.ValidateResourceId(id);
            return new TableServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TableResource.CreateResourceIdentifier" /> to create a <see cref="TableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableResource" /> object. </returns>
        public virtual TableResource GetTableResource(ResourceIdentifier id)
        {
            TableResource.ValidateResourceId(id);
            return new TableResource(Client, id);
        }
    }
}
