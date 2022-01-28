// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ResourceGroup and their operations over its parent. </summary>
    [CodeGenSuppress("GetAllAsGenericResources", typeof(string), typeof(string), typeof(int?), typeof(CancellationToken))]
    [CodeGenSuppress("GetAllAsGenericResourcesAsync", typeof(string), typeof(string), typeof(int?), typeof(CancellationToken))]
    public partial class ResourceGroupCollection : ArmCollection, IEnumerable<ResourceGroup>, IAsyncEnumerable<ResourceGroup>

    {
        /// <summary>
        /// Gets the parent resource of this resource.
        /// </summary>
        protected new Subscription Parent { get {return base.Parent as Subscription;} }

        /// <summary>
        /// Constructs an object used to create a resource group.
        /// </summary>
        /// <param name="location"> The location of the resource group. </param>
        /// <param name="tags"> The tags of the resource group. </param>
        /// <param name="managedBy"> Who the resource group is managed by. </param>
        /// <returns> A builder with <see cref="ResourceGroup"/> and <see cref="ResourceGroupData"/>. </returns>
        /// <exception cref="ArgumentNullException"> Location cannot be null. </exception>
        internal ResourceGroupBuilder Construct(AzureLocation location, IDictionary<string, string> tags = default, string managedBy = default)
        {
            var model = new ResourceGroupData(location);
            if (!(tags is null))
                model.Tags.ReplaceWith(tags);
            model.ManagedBy = managedBy;
            return new ResourceGroupBuilder(this, model);
        }
    }
}
