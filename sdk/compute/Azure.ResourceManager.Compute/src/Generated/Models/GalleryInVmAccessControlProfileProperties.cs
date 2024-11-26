// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a gallery inVMAccessControlProfile. </summary>
    public partial class GalleryInVmAccessControlProfileProperties : GalleryResourceProfilePropertiesBase
    {
        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlProfileProperties"/>. </summary>
        /// <param name="osType"> This property allows you to specify the OS type of the VMs/VMSS for which this profile can be used against. Possible values are: 'Windows' or 'Linux'. </param>
        /// <param name="applicableHostEndpoint"> This property allows you to specify the Endpoint type for which this profile is defining the access control for. Possible values are: 'WireServer' or 'IMDS'. </param>
        public GalleryInVmAccessControlProfileProperties(SupportedOperatingSystemType osType, EndpointType applicableHostEndpoint)
        {
            OSType = osType;
            ApplicableHostEndpoint = applicableHostEndpoint;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlProfileProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="description"> The description of this gallery inVMAccessControlProfile resources. This property is updatable. </param>
        /// <param name="osType"> This property allows you to specify the OS type of the VMs/VMSS for which this profile can be used against. Possible values are: 'Windows' or 'Linux'. </param>
        /// <param name="applicableHostEndpoint"> This property allows you to specify the Endpoint type for which this profile is defining the access control for. Possible values are: 'WireServer' or 'IMDS'. </param>
        internal GalleryInVmAccessControlProfileProperties(GalleryProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, string description, SupportedOperatingSystemType osType, EndpointType applicableHostEndpoint) : base(provisioningState, serializedAdditionalRawData)
        {
            Description = description;
            OSType = osType;
            ApplicableHostEndpoint = applicableHostEndpoint;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlProfileProperties"/> for deserialization. </summary>
        internal GalleryInVmAccessControlProfileProperties()
        {
        }

        /// <summary> The description of this gallery inVMAccessControlProfile resources. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> This property allows you to specify the OS type of the VMs/VMSS for which this profile can be used against. Possible values are: 'Windows' or 'Linux'. </summary>
        public SupportedOperatingSystemType OSType { get; set; }
        /// <summary> This property allows you to specify the Endpoint type for which this profile is defining the access control for. Possible values are: 'WireServer' or 'IMDS'. </summary>
        public EndpointType ApplicableHostEndpoint { get; set; }
    }
}
