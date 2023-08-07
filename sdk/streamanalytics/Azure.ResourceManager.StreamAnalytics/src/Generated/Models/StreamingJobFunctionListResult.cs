// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Object containing a list of functions under a streaming job. </summary>
    internal partial class StreamingJobFunctionListResult
    {
        /// <summary> Initializes a new instance of StreamingJobFunctionListResult. </summary>
        internal StreamingJobFunctionListResult()
        {
            Value = new ChangeTrackingList<StreamingJobFunctionData>();
        }

        /// <summary> Initializes a new instance of StreamingJobFunctionListResult. </summary>
        /// <param name="value"> A list of functions under a streaming job. Populated by a 'List' operation. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal StreamingJobFunctionListResult(IReadOnlyList<StreamingJobFunctionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of functions under a streaming job. Populated by a 'List' operation. </summary>
        public IReadOnlyList<StreamingJobFunctionData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
