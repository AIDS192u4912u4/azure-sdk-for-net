// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Deployment on error behavior.
/// </summary>
public partial class ErrorDeployment : ProvisionableConstruct
{
    /// <summary>
    /// The deployment on error behavior type. Possible values are
    /// LastSuccessful and SpecificDeployment.
    /// </summary>
    public BicepValue<ErrorDeploymentType> DeploymentType 
    {
        get { Initialize(); return _deploymentType!; }
        set { Initialize(); _deploymentType!.Assign(value); }
    }
    private BicepValue<ErrorDeploymentType>? _deploymentType;

    /// <summary>
    /// The deployment to be used on error case.
    /// </summary>
    public BicepValue<string> DeploymentName 
    {
        get { Initialize(); return _deploymentName!; }
        set { Initialize(); _deploymentName!.Assign(value); }
    }
    private BicepValue<string>? _deploymentName;

    /// <summary>
    /// Creates a new ErrorDeployment.
    /// </summary>
    public ErrorDeployment()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ErrorDeployment.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _deploymentType = DefineProperty<ErrorDeploymentType>("DeploymentType", ["type"]);
        _deploymentName = DefineProperty<string>("DeploymentName", ["deploymentName"]);
    }
}
