// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A HDInsight compute. </summary>
    public partial class MachineLearningHDInsightCompute : MachineLearningComputeProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningHDInsightCompute"/>. </summary>
        public MachineLearningHDInsightCompute()
        {
            ComputeType = ComputeType.HDInsight;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningHDInsightCompute"/>. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="computeLocation"> Location for the underlying compute. </param>
        /// <param name="provisioningState"> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </param>
        /// <param name="description"> The description of the Machine Learning compute. </param>
        /// <param name="createdOn"> The time at which the compute was created. </param>
        /// <param name="modifiedOn"> The time at which the compute was last modified. </param>
        /// <param name="resourceId"> ARM resource id of the underlying compute. </param>
        /// <param name="provisioningErrors"> Errors during provisioning. </param>
        /// <param name="isAttachedCompute"> Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> HDInsight compute properties. </param>
        internal MachineLearningHDInsightCompute(ComputeType computeType, string computeLocation, MachineLearningProvisioningState? provisioningState, string description, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, ResourceIdentifier resourceId, IReadOnlyList<MachineLearningError> provisioningErrors, bool? isAttachedCompute, bool? disableLocalAuth, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningHDInsightProperties properties) : base(computeType, computeLocation, provisioningState, description, createdOn, modifiedOn, resourceId, provisioningErrors, isAttachedCompute, disableLocalAuth, serializedAdditionalRawData)
        {
            Properties = properties;
            ComputeType = computeType;
        }

        /// <summary> HDInsight compute properties. </summary>
        [WirePath("properties")]
        public MachineLearningHDInsightProperties Properties { get; set; }
    }
}
