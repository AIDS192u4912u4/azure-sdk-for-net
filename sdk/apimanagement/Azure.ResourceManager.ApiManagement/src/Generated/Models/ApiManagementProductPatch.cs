// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Product Update parameters. </summary>
    public partial class ApiManagementProductPatch
    {
        /// <summary> Initializes a new instance of ApiManagementProductPatch. </summary>
        public ApiManagementProductPatch()
        {
        }

        /// <summary> Product description. May include HTML formatting tags. </summary>
        public string Description { get; set; }
        /// <summary> Product terms of use. Developers trying to subscribe to the product will be presented and required to accept these terms before they can complete the subscription process. </summary>
        public string Terms { get; set; }
        /// <summary> Whether a product subscription is required for accessing APIs included in this product. If true, the product is referred to as "protected" and a valid subscription key is required for a request to an API included in the product to succeed. If false, the product is referred to as "open" and requests to an API included in the product can be made without a subscription key. If property is omitted when creating a new product it's value is assumed to be true. </summary>
        public bool? IsSubscriptionRequired { get; set; }
        /// <summary> whether subscription approval is required. If false, new subscriptions will be approved automatically enabling developers to call the product’s APIs immediately after subscribing. If true, administrators must manually approve the subscription before the developer can any of the product’s APIs. Can be present only if subscriptionRequired property is present and has a value of false. </summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary> Whether the number of subscriptions a user can have to this product at the same time. Set to null or omit to allow unlimited per user subscriptions. Can be present only if subscriptionRequired property is present and has a value of false. </summary>
        public int? SubscriptionsLimit { get; set; }
        /// <summary> whether product is published or not. Published products are discoverable by users of developer portal. Non published products are visible only to administrators. Default state of Product is notPublished. </summary>
        public ApiManagementProductState? State { get; set; }
        /// <summary> Product name. </summary>
        public string DisplayName { get; set; }
    }
}
