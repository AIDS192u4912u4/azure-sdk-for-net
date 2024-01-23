// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The publishing profile of a gallery image version. </summary>
    public partial class GalleryApplicationVersionPublishingProfile : GalleryArtifactPublishingProfileBase
    {
        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionPublishingProfile"/>. </summary>
        /// <param name="source"> The source image from which the Image Version is going to be created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public GalleryApplicationVersionPublishingProfile(UserArtifactSource source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Source = source;
            AdvancedSettings = new ChangeTrackingDictionary<string, string>();
            CustomActions = new ChangeTrackingList<GalleryApplicationCustomAction>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionPublishingProfile"/>. </summary>
        /// <param name="targetRegions"> The target regions where the Image Version is going to be replicated to. This property is updatable. </param>
        /// <param name="replicaCount"> The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable. </param>
        /// <param name="isExcludedFromLatest"> If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version. </param>
        /// <param name="publishedOn"> The timestamp for when the gallery image version is published. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to store the image. This property is not updatable. </param>
        /// <param name="replicationMode"> Optional parameter which specifies the mode to be used for replication. This property is not updatable. </param>
        /// <param name="targetExtendedLocations"> The target extended locations where the Image Version is going to be replicated to. This property is updatable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="source"> The source image from which the Image Version is going to be created. </param>
        /// <param name="manageActions"></param>
        /// <param name="settings"> Additional settings for the VM app that contains the target package and config file name when it is deployed to target VM or VM scale set. </param>
        /// <param name="advancedSettings"> Optional. Additional settings to pass to the vm-application-manager extension. For advanced use only. </param>
        /// <param name="enableHealthCheck"> Optional. Whether or not this application reports health. </param>
        /// <param name="customActions"> A list of custom actions that can be performed with this Gallery Application Version. </param>
        internal GalleryApplicationVersionPublishingProfile(IList<TargetRegion> targetRegions, int? replicaCount, bool? isExcludedFromLatest, DateTimeOffset? publishedOn, DateTimeOffset? endOfLifeOn, ImageStorageAccountType? storageAccountType, GalleryReplicationMode? replicationMode, IList<GalleryTargetExtendedLocation> targetExtendedLocations, IDictionary<string, BinaryData> serializedAdditionalRawData, UserArtifactSource source, UserArtifactManagement manageActions, UserArtifactSettings settings, IDictionary<string, string> advancedSettings, bool? enableHealthCheck, IList<GalleryApplicationCustomAction> customActions) : base(targetRegions, replicaCount, isExcludedFromLatest, publishedOn, endOfLifeOn, storageAccountType, replicationMode, targetExtendedLocations, serializedAdditionalRawData)
        {
            Source = source;
            ManageActions = manageActions;
            Settings = settings;
            AdvancedSettings = advancedSettings;
            EnableHealthCheck = enableHealthCheck;
            CustomActions = customActions;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionPublishingProfile"/> for deserialization. </summary>
        internal GalleryApplicationVersionPublishingProfile()
        {
        }

        /// <summary> The source image from which the Image Version is going to be created. </summary>
        public UserArtifactSource Source { get; set; }
        /// <summary> Gets or sets the manage actions. </summary>
        public UserArtifactManagement ManageActions { get; set; }
        /// <summary> Additional settings for the VM app that contains the target package and config file name when it is deployed to target VM or VM scale set. </summary>
        public UserArtifactSettings Settings { get; set; }
        /// <summary> Optional. Additional settings to pass to the vm-application-manager extension. For advanced use only. </summary>
        public IDictionary<string, string> AdvancedSettings { get; }
        /// <summary> Optional. Whether or not this application reports health. </summary>
        public bool? EnableHealthCheck { get; set; }
        /// <summary> A list of custom actions that can be performed with this Gallery Application Version. </summary>
        public IList<GalleryApplicationCustomAction> CustomActions { get; }
    }
}
