// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Partner Destinations operation. </summary>
    internal partial class PartnerDestinationsListResult
    {
        /// <summary> Initializes a new instance of PartnerDestinationsListResult. </summary>
        internal PartnerDestinationsListResult()
        {
            Value = new ChangeTrackingList<PartnerDestinationData>();
        }

        /// <summary> Initializes a new instance of PartnerDestinationsListResult. </summary>
        /// <param name="value"> A collection of partner destinations. </param>
        /// <param name="nextLink"> A link for the next page of partner destinations. </param>
        internal PartnerDestinationsListResult(IReadOnlyList<PartnerDestinationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of partner destinations. </summary>
        public IReadOnlyList<PartnerDestinationData> Value { get; }
        /// <summary> A link for the next page of partner destinations. </summary>
        public string NextLink { get; }
    }
}
