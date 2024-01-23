// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The security context for the container. </summary>
    public partial class ContainerSecurityContextDefinition
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerSecurityContextDefinition"/>. </summary>
        public ContainerSecurityContextDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerSecurityContextDefinition"/>. </summary>
        /// <param name="isPrivileged"> The flag to determine if the container permissions is elevated to Privileged. </param>
        /// <param name="allowPrivilegeEscalation"> A boolean value indicating whether the init process can elevate its privileges. </param>
        /// <param name="capabilities"> The capabilities to add or drop from a container. </param>
        /// <param name="runAsGroup"> Sets the User GID for the container. </param>
        /// <param name="runAsUser"> Sets the User UID for the container. </param>
        /// <param name="seccompProfile"> a base64 encoded string containing the contents of the JSON in the seccomp profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerSecurityContextDefinition(bool? isPrivileged, bool? allowPrivilegeEscalation, ContainerSecurityContextCapabilitiesDefinition capabilities, int? runAsGroup, int? runAsUser, string seccompProfile, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsPrivileged = isPrivileged;
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            Capabilities = capabilities;
            RunAsGroup = runAsGroup;
            RunAsUser = runAsUser;
            SeccompProfile = seccompProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The flag to determine if the container permissions is elevated to Privileged. </summary>
        public bool? IsPrivileged { get; set; }
        /// <summary> A boolean value indicating whether the init process can elevate its privileges. </summary>
        public bool? AllowPrivilegeEscalation { get; set; }
        /// <summary> The capabilities to add or drop from a container. </summary>
        public ContainerSecurityContextCapabilitiesDefinition Capabilities { get; set; }
        /// <summary> Sets the User GID for the container. </summary>
        public int? RunAsGroup { get; set; }
        /// <summary> Sets the User UID for the container. </summary>
        public int? RunAsUser { get; set; }
        /// <summary> a base64 encoded string containing the contents of the JSON in the seccomp profile. </summary>
        public string SeccompProfile { get; set; }
    }
}
