// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The custom setup of running cmdkey commands. </summary>
    public partial class SynapseCmdkeySetup : SynapseCustomSetupBase
    {
        /// <summary> Initializes a new instance of SynapseCmdkeySetup. </summary>
        /// <param name="targetName"> The server name of data source access. </param>
        /// <param name="userName"> The user name of data source access. </param>
        /// <param name="password">
        /// The password of data source access.
        /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSecureString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public SynapseCmdkeySetup(BinaryData targetName, BinaryData userName, SynapseSecretBase password)
        {
            Argument.AssertNotNull(targetName, nameof(targetName));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            TargetName = targetName;
            UserName = userName;
            Password = password;
            CustomSetupBaseType = "CmdkeySetup";
        }

        /// <summary> Initializes a new instance of SynapseCmdkeySetup. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="targetName"> The server name of data source access. </param>
        /// <param name="userName"> The user name of data source access. </param>
        /// <param name="password">
        /// The password of data source access.
        /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSecureString"/>.
        /// </param>
        internal SynapseCmdkeySetup(string customSetupBaseType, BinaryData targetName, BinaryData userName, SynapseSecretBase password) : base(customSetupBaseType)
        {
            TargetName = targetName;
            UserName = userName;
            Password = password;
            CustomSetupBaseType = customSetupBaseType ?? "CmdkeySetup";
        }

        /// <summary>
        /// The server name of data source access.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData TargetName { get; set; }
        /// <summary>
        /// The user name of data source access.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData UserName { get; set; }
        /// <summary>
        /// The password of data source access.
        /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSecureString"/>.
        /// </summary>
        public SynapseSecretBase Password { get; set; }
    }
}
