// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryAlert data model.
    /// Implements the Alert class.
    /// </summary>
    public partial class SiteRecoveryAlertData : ResourceData
    {
        /// <summary> Initializes a new instance of SiteRecoveryAlertData. </summary>
        internal SiteRecoveryAlertData()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Alert related data. </param>
        /// <param name="location"> Resource Location. </param>
        internal SiteRecoveryAlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryAlertProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> Alert related data. </summary>
        public SiteRecoveryAlertProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
