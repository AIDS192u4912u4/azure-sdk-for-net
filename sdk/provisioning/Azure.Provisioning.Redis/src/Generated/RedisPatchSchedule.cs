// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// RedisPatchSchedule.
/// </summary>
public partial class RedisPatchSchedule : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// List of patch schedules for a Redis cache.
    /// </summary>
    public BicepList<RedisPatchScheduleSetting> ScheduleEntries { get => _scheduleEntries; set => _scheduleEntries.Assign(value); }
    private readonly BicepList<RedisPatchScheduleSetting> _scheduleEntries;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent RedisResource.
    /// </summary>
    public RedisResource? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<RedisResource> _parent;

    /// <summary>
    /// Creates a new RedisPatchSchedule.
    /// </summary>
    /// <param name="resourceName">Name of the RedisPatchSchedule.</param>
    /// <param name="resourceVersion">Version of the RedisPatchSchedule.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public RedisPatchSchedule(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Cache/redis/patchSchedules", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _scheduleEntries = BicepList<RedisPatchScheduleSetting>.DefineProperty(this, "ScheduleEntries", ["properties", "scheduleEntries"], isRequired: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<RedisResource>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing RedisPatchSchedule.
    /// </summary>
    /// <param name="resourceName">Name of the RedisPatchSchedule.</param>
    /// <param name="resourceVersion">Version of the RedisPatchSchedule.</param>
    /// <returns>The existing RedisPatchSchedule resource.</returns>
    public static RedisPatchSchedule FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
