// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container object under Container App Revision Replica. </summary>
    public partial class ContainerAppReplicaContainer
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppReplicaContainer"/>. </summary>
        public ContainerAppReplicaContainer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppReplicaContainer"/>. </summary>
        /// <param name="name"> The Name of the Container. </param>
        /// <param name="containerId"> The Id of the Container. </param>
        /// <param name="isReady"> The container ready status. </param>
        /// <param name="isStarted"> The container start status. </param>
        /// <param name="restartCount"> The container restart count. </param>
        /// <param name="runningState"> Current running state of the container. </param>
        /// <param name="runningStateDetails"> The details of container current running state. </param>
        /// <param name="logStreamEndpoint"> Log Stream endpoint. </param>
        /// <param name="execEndpoint"> Container exec endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppReplicaContainer(string name, string containerId, bool? isReady, bool? isStarted, int? restartCount, ContainerAppContainerRunningState? runningState, string runningStateDetails, string logStreamEndpoint, string execEndpoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ContainerId = containerId;
            IsReady = isReady;
            IsStarted = isStarted;
            RestartCount = restartCount;
            RunningState = runningState;
            RunningStateDetails = runningStateDetails;
            LogStreamEndpoint = logStreamEndpoint;
            ExecEndpoint = execEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Name of the Container. </summary>
        public string Name { get; set; }
        /// <summary> The Id of the Container. </summary>
        public string ContainerId { get; set; }
        /// <summary> The container ready status. </summary>
        public bool? IsReady { get; set; }
        /// <summary> The container start status. </summary>
        public bool? IsStarted { get; set; }
        /// <summary> The container restart count. </summary>
        public int? RestartCount { get; set; }
        /// <summary> Current running state of the container. </summary>
        public ContainerAppContainerRunningState? RunningState { get; }
        /// <summary> The details of container current running state. </summary>
        public string RunningStateDetails { get; }
        /// <summary> Log Stream endpoint. </summary>
        public string LogStreamEndpoint { get; }
        /// <summary> Container exec endpoint. </summary>
        public string ExecEndpoint { get; }
    }
}
