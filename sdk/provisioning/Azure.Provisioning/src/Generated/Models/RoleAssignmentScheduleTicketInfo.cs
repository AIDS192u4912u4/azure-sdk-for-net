// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Authorization;

/// <summary>
/// Ticket Info of the role assignment.
/// </summary>
public partial class RoleAssignmentScheduleTicketInfo : ProvisionableConstruct
{
    /// <summary>
    /// Ticket number for the role assignment.
    /// </summary>
    public BicepValue<string> TicketNumber 
    {
        get { Initialize(); return _ticketNumber!; }
        set { Initialize(); _ticketNumber!.Assign(value); }
    }
    private BicepValue<string>? _ticketNumber;

    /// <summary>
    /// Ticket system name for the role assignment.
    /// </summary>
    public BicepValue<string> TicketSystem 
    {
        get { Initialize(); return _ticketSystem!; }
        set { Initialize(); _ticketSystem!.Assign(value); }
    }
    private BicepValue<string>? _ticketSystem;

    /// <summary>
    /// Creates a new RoleAssignmentScheduleTicketInfo.
    /// </summary>
    public RoleAssignmentScheduleTicketInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// RoleAssignmentScheduleTicketInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _ticketNumber = DefineProperty<string>("TicketNumber", ["ticketNumber"]);
        _ticketSystem = DefineProperty<string>("TicketSystem", ["ticketSystem"]);
    }
}
