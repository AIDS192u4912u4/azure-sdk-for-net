// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// Describes the current state of an existing Azure Private Link service
/// connection to the private endpoint.
/// </summary>
public partial class SearchServicePrivateLinkServiceConnectionState : ProvisionableConstruct
{
    /// <summary>
    /// Status of the the private link service connection. Valid values are
    /// Pending, Approved, Rejected, or Disconnected.
    /// </summary>
    public BicepValue<SearchServicePrivateLinkServiceConnectionStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<SearchServicePrivateLinkServiceConnectionStatus>? _status;

    /// <summary>
    /// The description for the private link service connection state.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// A description of any extra actions that may be required.
    /// </summary>
    public BicepValue<string> ActionsRequired 
    {
        get { Initialize(); return _actionsRequired!; }
        set { Initialize(); _actionsRequired!.Assign(value); }
    }
    private BicepValue<string>? _actionsRequired;

    /// <summary>
    /// Creates a new SearchServicePrivateLinkServiceConnectionState.
    /// </summary>
    public SearchServicePrivateLinkServiceConnectionState()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SearchServicePrivateLinkServiceConnectionState.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _status = DefineProperty<SearchServicePrivateLinkServiceConnectionStatus>("Status", ["status"]);
        _description = DefineProperty<string>("Description", ["description"]);
        _actionsRequired = DefineProperty<string>("ActionsRequired", ["actionsRequired"]);
    }
}
