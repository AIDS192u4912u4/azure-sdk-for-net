// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB SQL userDefinedFunction resource object.
/// </summary>
public partial class CosmosDBSqlUserDefinedFunctionResourceInfo : ProvisioningConstruct
{
    /// <summary>
    /// Name of the Cosmos DB SQL userDefinedFunction.
    /// </summary>
    public BicepValue<string> FunctionName { get => _functionName; set => _functionName.Assign(value); }
    private readonly BicepValue<string> _functionName;

    /// <summary>
    /// Body of the User Defined Function.
    /// </summary>
    public BicepValue<string> Body { get => _body; set => _body.Assign(value); }
    private readonly BicepValue<string> _body;

    /// <summary>
    /// Creates a new CosmosDBSqlUserDefinedFunctionResourceInfo.
    /// </summary>
    public CosmosDBSqlUserDefinedFunctionResourceInfo()
    {
        _functionName = BicepValue<string>.DefineProperty(this, "FunctionName", ["id"]);
        _body = BicepValue<string>.DefineProperty(this, "Body", ["body"]);
    }
}
