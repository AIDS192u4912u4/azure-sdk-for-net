// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> NodePoolAdministratorConfigurationPatch represents the patching capabilities for the administrator configuration. </summary>
    internal partial class NodePoolAdministratorConfigurationPatch
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

        /// <summary> Initializes a new instance of <see cref="NodePoolAdministratorConfigurationPatch"/>. </summary>
        public NodePoolAdministratorConfigurationPatch()
        {
            SshPublicKeys = new ChangeTrackingList<NetworkCloudSshPublicKey>();
        }

        /// <summary> Initializes a new instance of <see cref="NodePoolAdministratorConfigurationPatch"/>. </summary>
        /// <param name="sshPublicKeys"> SshPublicKey represents the public key used to authenticate with a resource through SSH. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NodePoolAdministratorConfigurationPatch(IList<NetworkCloudSshPublicKey> sshPublicKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SshPublicKeys = sshPublicKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SshPublicKey represents the public key used to authenticate with a resource through SSH. </summary>
        public IList<NetworkCloudSshPublicKey> SshPublicKeys { get; }
    }
}
