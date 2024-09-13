// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Unknown version of DataConnectorsCheckRequirements. </summary>
    internal partial class UnknownDataConnectorsCheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataConnectorsCheckRequirements"/>. </summary>
        /// <param name="kind"> Describes the kind of connector to be checked. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDataConnectorsCheckRequirements(DataConnectorKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDataConnectorsCheckRequirements"/> for deserialization. </summary>
        internal UnknownDataConnectorsCheckRequirements()
        {
        }
    }
}
