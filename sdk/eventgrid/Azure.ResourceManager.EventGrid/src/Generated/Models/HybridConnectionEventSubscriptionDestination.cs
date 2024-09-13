// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the HybridConnection destination for an event subscription. </summary>
    public partial class HybridConnectionEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of <see cref="HybridConnectionEventSubscriptionDestination"/>. </summary>
        public HybridConnectionEventSubscriptionDestination()
        {
            DeliveryAttributeMappings = new ChangeTrackingList<DeliveryAttributeMapping>();
            EndpointType = EndpointType.HybridConnection;
        }

        /// <summary> Initializes a new instance of <see cref="HybridConnectionEventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="resourceId"> The Azure Resource ID of an hybrid connection that is the destination of an event subscription. </param>
        /// <param name="deliveryAttributeMappings">
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </param>
        internal HybridConnectionEventSubscriptionDestination(EndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier resourceId, IList<DeliveryAttributeMapping> deliveryAttributeMappings) : base(endpointType, serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            DeliveryAttributeMappings = deliveryAttributeMappings;
            EndpointType = endpointType;
        }

        /// <summary> The Azure Resource ID of an hybrid connection that is the destination of an event subscription. </summary>
        [WirePath("properties.resourceId")]
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary>
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </summary>
        [WirePath("properties.deliveryAttributeMappings")]
        public IList<DeliveryAttributeMapping> DeliveryAttributeMappings { get; }
    }
}
