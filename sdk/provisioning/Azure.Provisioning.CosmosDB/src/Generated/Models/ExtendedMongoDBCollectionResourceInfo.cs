// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The ExtendedMongoDBCollectionResourceInfo.
/// </summary>
public partial class ExtendedMongoDBCollectionResourceInfo : MongoDBCollectionResourceInfo
{
    /// <summary>
    /// A system generated property. A unique identifier.
    /// </summary>
    public BicepValue<string> Rid { get => _rid; }
    private readonly BicepValue<string> _rid;

    /// <summary>
    /// A system generated property that denotes the last updated timestamp of
    /// the resource.
    /// </summary>
    public BicepValue<float> Timestamp { get => _timestamp; }
    private readonly BicepValue<float> _timestamp;

    /// <summary>
    /// A system generated property representing the resource etag required for
    /// optimistic concurrency control.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Creates a new ExtendedMongoDBCollectionResourceInfo.
    /// </summary>
    public ExtendedMongoDBCollectionResourceInfo() : base()
    {
        _rid = BicepValue<string>.DefineProperty(this, "Rid", ["_rid"], isOutput: true);
        _timestamp = BicepValue<float>.DefineProperty(this, "Timestamp", ["_ts"], isOutput: true);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["_etag"], isOutput: true);
    }
}
