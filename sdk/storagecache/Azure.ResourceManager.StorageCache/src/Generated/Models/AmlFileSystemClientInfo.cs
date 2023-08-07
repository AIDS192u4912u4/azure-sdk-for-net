// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> AML file system client information. </summary>
    public partial class AmlFileSystemClientInfo
    {
        /// <summary> Initializes a new instance of AmlFileSystemClientInfo. </summary>
        internal AmlFileSystemClientInfo()
        {
        }

        /// <summary> Initializes a new instance of AmlFileSystemClientInfo. </summary>
        /// <param name="mgsAddress"> The IPv4 address used by clients to mount the AML file system's Lustre Management Service (MGS). </param>
        /// <param name="mountCommand"> Recommended command to mount the AML file system. </param>
        /// <param name="lustreVersion"> The version of Lustre running in the AML file system. </param>
        /// <param name="containerStorageInterface"> Container Storage Interface information for the AML file system. </param>
        internal AmlFileSystemClientInfo(string mgsAddress, string mountCommand, string lustreVersion, AmlFileSystemContainerStorageInterface containerStorageInterface)
        {
            MgsAddress = mgsAddress;
            MountCommand = mountCommand;
            LustreVersion = lustreVersion;
            ContainerStorageInterface = containerStorageInterface;
        }

        /// <summary> The IPv4 address used by clients to mount the AML file system's Lustre Management Service (MGS). </summary>
        public string MgsAddress { get; }
        /// <summary> Recommended command to mount the AML file system. </summary>
        public string MountCommand { get; }
        /// <summary> The version of Lustre running in the AML file system. </summary>
        public string LustreVersion { get; }
        /// <summary> Container Storage Interface information for the AML file system. </summary>
        public AmlFileSystemContainerStorageInterface ContainerStorageInterface { get; }
    }
}
