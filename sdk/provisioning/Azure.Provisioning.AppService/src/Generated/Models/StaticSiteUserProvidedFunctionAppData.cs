// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// A class representing the StaticSiteUserProvidedFunctionApp data model.
/// Static Site User Provided Function App ARM resource.
/// </summary>
public partial class StaticSiteUserProvidedFunctionAppData : ProvisioningConstruct
{
    /// <summary>
    /// The resource id of the function app registered with the static site.
    /// </summary>
    public BicepValue<ResourceIdentifier> FunctionAppResourceId { get => _functionAppResourceId; set => _functionAppResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _functionAppResourceId;

    /// <summary>
    /// The region of the function app registered with the static site.
    /// </summary>
    public BicepValue<string> FunctionAppRegion { get => _functionAppRegion; set => _functionAppRegion.Assign(value); }
    private readonly BicepValue<string> _functionAppRegion;

    /// <summary>
    /// The date and time on which the function app was registered with the
    /// static site.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new StaticSiteUserProvidedFunctionAppData.
    /// </summary>
    public StaticSiteUserProvidedFunctionAppData()
    {
        _functionAppResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "FunctionAppResourceId", ["properties", "functionAppResourceId"]);
        _functionAppRegion = BicepValue<string>.DefineProperty(this, "FunctionAppRegion", ["properties", "functionAppRegion"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdOn"], isOutput: true);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }
}
