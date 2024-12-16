// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Blob restore parameters.
/// </summary>
public partial class BlobRestoreContent : ProvisionableConstruct
{
    /// <summary>
    /// Restore blob to the specified time.
    /// </summary>
    public BicepValue<DateTimeOffset> TimeToRestore 
    {
        get { Initialize(); return _timeToRestore!; }
        set { Initialize(); _timeToRestore!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _timeToRestore;

    /// <summary>
    /// Blob ranges to restore.
    /// </summary>
    public BicepList<BlobRestoreRange> BlobRanges 
    {
        get { Initialize(); return _blobRanges!; }
        set { Initialize(); _blobRanges!.Assign(value); }
    }
    private BicepList<BlobRestoreRange>? _blobRanges;

    /// <summary>
    /// Creates a new BlobRestoreContent.
    /// </summary>
    public BlobRestoreContent()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of BlobRestoreContent.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _timeToRestore = DefineProperty<DateTimeOffset>("TimeToRestore", ["timetoRestore"]);
        _blobRanges = DefineListProperty<BlobRestoreRange>("BlobRanges", ["blobRanges"]);
    }
}
