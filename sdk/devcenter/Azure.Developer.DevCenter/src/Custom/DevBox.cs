// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    [CodeGenSuppress("DevBox", typeof(string))]
    public partial class DevBox
    {
        /// <summary> Initializes a new instance of <see cref="DevBox"/>. </summary>
        /// <param name="name"> Display name for the Dev Box. </param>
        /// <param name="poolName"> The name of the Dev Box pool this machine belongs to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="poolName"/> is null. </exception>
        public DevBox(string name, string poolName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(poolName, nameof(poolName));

            Name = name;
            PoolName = poolName;
        }
    }

    public partial class DevBox
    {
        /// <summary> Initializes a new instance of <see cref="DevBox"/>. </summary>
        /// <param name="name"> Display name for the Dev Box. </param>
        /// <param name="projectName"> Name of the project this Dev Box belongs to. </param>
        /// <param name="poolName"> The name of the Dev Box pool this machine belongs to. </param>
        /// <param name="hibernateSupport"> Indicates whether hibernate is enabled/disabled or unknown. </param>
        /// <param name="provisioningState"> The current provisioning state of the Dev Box. </param>
        /// <param name="actionState">
        /// The current action state of the Dev Box. This is state is based on previous
        /// action performed by user.
        /// </param>
        /// <param name="powerState"> The current power state of the Dev Box. </param>
        /// <param name="uniqueId">
        /// A unique identifier for the Dev Box. This is a GUID-formatted string (e.g.
        /// 00000000-0000-0000-0000-000000000000).
        /// </param>
        /// <param name="error"> Provisioning or action error details. Populated only for error states. </param>
        /// <param name="location">
        /// Azure region where this Dev Box is located. This will be the same region as the
        /// Virtual Network it is attached to.
        /// </param>
        /// <param name="osType"> The operating system type of this Dev Box. </param>
        /// <param name="userId"> The AAD object id of the user this Dev Box is assigned to. </param>
        /// <param name="hardwareProfile"> Information about the Dev Box's hardware resources. </param>
        /// <param name="storageProfile"> Storage settings for this Dev Box. </param>
        /// <param name="imageReference"> Information about the image used for this Dev Box. </param>
        /// <param name="createdTime"> Creation time of this Dev Box. </param>
        /// <param name="localAdministratorStatus"> Indicates whether the owner of the Dev Box is a local administrator. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevBox(string name, string projectName, string poolName, HibernateSupport? hibernateSupport, DevBoxProvisioningState? provisioningState, string actionState, PowerState? powerState, Guid? uniqueId, ResponseError error, AzureLocation? location, DevBoxOSType? osType, Guid? userId, DevBoxHardwareProfile hardwareProfile, DevBoxStorageProfile storageProfile, DevBoxImageReference imageReference, DateTimeOffset? createdTime, LocalAdministratorStatus? localAdministratorStatus)
        {
            Name = name;
            ProjectName = projectName;
            PoolName = poolName;
            HibernateSupport = hibernateSupport;
            ProvisioningState = provisioningState;
            ActionState = actionState;
            PowerState = powerState;
            UniqueId = uniqueId;
            Error = error;
            Location = location;
            OSType = osType;
            UserId = userId;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            ImageReference = imageReference;
            CreatedTime = createdTime;
            LocalAdministratorStatus = localAdministratorStatus;
        }
    }
}
