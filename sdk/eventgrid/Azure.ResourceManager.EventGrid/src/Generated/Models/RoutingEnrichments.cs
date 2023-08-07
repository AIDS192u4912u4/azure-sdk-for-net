// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The RoutingEnrichments. </summary>
    public partial class RoutingEnrichments
    {
        /// <summary> Initializes a new instance of RoutingEnrichments. </summary>
        public RoutingEnrichments()
        {
            Static = new ChangeTrackingList<StaticRoutingEnrichment>();
            Dynamic = new ChangeTrackingList<DynamicRoutingEnrichment>();
        }

        /// <summary> Initializes a new instance of RoutingEnrichments. </summary>
        /// <param name="static"></param>
        /// <param name="dynamic"></param>
        internal RoutingEnrichments(IList<StaticRoutingEnrichment> @static, IList<DynamicRoutingEnrichment> @dynamic)
        {
            Static = @static;
            Dynamic = @dynamic;
        }

        /// <summary> Gets the static. </summary>
        public IList<StaticRoutingEnrichment> Static { get; }
        /// <summary> Gets the dynamic. </summary>
        public IList<DynamicRoutingEnrichment> Dynamic { get; }
    }
}
