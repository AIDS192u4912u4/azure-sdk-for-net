// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// The ManagedInstancePrivateLinkServiceConnectionStateProperty.
/// </summary>
public partial class ManagedInstancePrivateLinkServiceConnectionStateProperty : ProvisionableConstruct
{
    /// <summary>
    /// The private link service connection status.
    /// </summary>
    public BicepValue<string> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<string>? _status;

    /// <summary>
    /// The private link service connection description.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The private link service connection description.
    /// </summary>
    public BicepValue<string> ActionsRequired 
    {
        get { Initialize(); return _actionsRequired!; }
    }
    private BicepValue<string>? _actionsRequired;

    /// <summary>
    /// Creates a new ManagedInstancePrivateLinkServiceConnectionStateProperty.
    /// </summary>
    public ManagedInstancePrivateLinkServiceConnectionStateProperty()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedInstancePrivateLinkServiceConnectionStateProperty.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _status = DefineProperty<string>("Status", ["status"]);
        _description = DefineProperty<string>("Description", ["description"]);
        _actionsRequired = DefineProperty<string>("ActionsRequired", ["actionsRequired"], isOutput: true);
    }
}
