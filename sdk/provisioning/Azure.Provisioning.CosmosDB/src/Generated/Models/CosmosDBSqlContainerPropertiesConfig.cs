// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The CosmosDBSqlContainerPropertiesConfig.
/// </summary>
public partial class CosmosDBSqlContainerPropertiesConfig : ProvisionableConstruct
{
    /// <summary>
    /// Value of the Cosmos DB resource throughput or autoscaleSettings. Use
    /// the ThroughputSetting resource when retrieving offer details.
    /// </summary>
    public BicepValue<int> Throughput 
    {
        get { Initialize(); return _throughput!; }
        set { Initialize(); _throughput!.Assign(value); }
    }
    private BicepValue<int>? _throughput;

    /// <summary>
    /// Represents maximum throughput, the resource can scale up to.
    /// </summary>
    public BicepValue<int> AutoscaleMaxThroughput 
    {
        get { Initialize(); return _autoscaleMaxThroughput!; }
        set { Initialize(); _autoscaleMaxThroughput!.Assign(value); }
    }
    private BicepValue<int>? _autoscaleMaxThroughput;

    /// <summary>
    /// Creates a new CosmosDBSqlContainerPropertiesConfig.
    /// </summary>
    public CosmosDBSqlContainerPropertiesConfig()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CosmosDBSqlContainerPropertiesConfig.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _throughput = DefineProperty<int>("Throughput", ["throughput"]);
        _autoscaleMaxThroughput = DefineProperty<int>("AutoscaleMaxThroughput", ["autoscaleSettings", "maxThroughput"]);
    }
}
