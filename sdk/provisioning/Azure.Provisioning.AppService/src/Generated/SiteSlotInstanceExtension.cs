// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteSlotInstanceExtension.
/// </summary>
public partial class SiteSlotInstanceExtension : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// SQL Connection String.
    /// </summary>
    public BicepValue<string> ConnectionString 
    {
        get { Initialize(); return _connectionString!; }
        set { Initialize(); _connectionString!.Assign(value); }
    }
    private BicepValue<string>? _connectionString;

    /// <summary>
    /// Database Type.
    /// </summary>
    public BicepValue<string> DBType 
    {
        get { Initialize(); return _dBType!; }
        set { Initialize(); _dBType!.Assign(value); }
    }
    private BicepValue<string>? _dBType;

    /// <summary>
    /// Sets the AppOffline rule while the MSDeploy operation executes.
    /// Setting is &lt;code&gt;false&lt;/code&gt; by default.
    /// </summary>
    public BicepValue<bool> IsAppOffline 
    {
        get { Initialize(); return _isAppOffline!; }
        set { Initialize(); _isAppOffline!.Assign(value); }
    }
    private BicepValue<bool>? _isAppOffline;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Package URI.
    /// </summary>
    public BicepValue<Uri> PackageUri 
    {
        get { Initialize(); return _packageUri!; }
        set { Initialize(); _packageUri!.Assign(value); }
    }
    private BicepValue<Uri>? _packageUri;

    /// <summary>
    /// MSDeploy Parameters. Must not be set if SetParametersXmlFileUri is used.
    /// </summary>
    public BicepDictionary<string> SetParameters 
    {
        get { Initialize(); return _setParameters!; }
        set { Initialize(); _setParameters!.Assign(value); }
    }
    private BicepDictionary<string>? _setParameters;

    /// <summary>
    /// URI of MSDeploy Parameters file. Must not be set if SetParameters is
    /// used.
    /// </summary>
    public BicepValue<Uri> SetParametersXmlFileUri 
    {
        get { Initialize(); return _setParametersXmlFileUri!; }
        set { Initialize(); _setParametersXmlFileUri!.Assign(value); }
    }
    private BicepValue<Uri>? _setParametersXmlFileUri;

    /// <summary>
    /// Controls whether the MSDeploy operation skips the App_Data directory.
    /// If set to &lt;code&gt;true&lt;/code&gt;, the existing
    /// App_Data directory on the destination             will not be deleted,
    /// and any App_Data directory in the source will be ignored.
    /// Setting is &lt;code&gt;false&lt;/code&gt; by default.
    /// </summary>
    public BicepValue<bool> SkipAppData 
    {
        get { Initialize(); return _skipAppData!; }
        set { Initialize(); _skipAppData!.Assign(value); }
    }
    private BicepValue<bool>? _skipAppData;

    /// <summary>
    /// Username of deployer.
    /// </summary>
    public BicepValue<string> Deployer 
    {
        get { Initialize(); return _deployer!; }
    }
    private BicepValue<string>? _deployer;

    /// <summary>
    /// End time of deploy operation.
    /// </summary>
    public BicepValue<DateTimeOffset> EndOn 
    {
        get { Initialize(); return _endOn!; }
    }
    private BicepValue<DateTimeOffset>? _endOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Whether the deployment operation has completed.
    /// </summary>
    public BicepValue<bool> IsComplete 
    {
        get { Initialize(); return _isComplete!; }
    }
    private BicepValue<bool>? _isComplete;

    /// <summary>
    /// Provisioning state.
    /// </summary>
    public BicepValue<MSDeployProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<MSDeployProvisioningState>? _provisioningState;

    /// <summary>
    /// Start time of deploy operation.
    /// </summary>
    public BicepValue<DateTimeOffset> StartOn 
    {
        get { Initialize(); return _startOn!; }
    }
    private BicepValue<DateTimeOffset>? _startOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new SiteSlotInstanceExtension.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SiteSlotInstanceExtension
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteSlotInstanceExtension.</param>
    public SiteSlotInstanceExtension(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/sites/slots/instances/extensions", resourceVersion)
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SiteSlotInstanceExtension.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _connectionString = DefineProperty<string>("ConnectionString", ["properties", "connectionString"]);
        _dBType = DefineProperty<string>("DBType", ["properties", "dbType"]);
        _isAppOffline = DefineProperty<bool>("IsAppOffline", ["properties", "appOffline"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _packageUri = DefineProperty<Uri>("PackageUri", ["properties", "packageUri"]);
        _setParameters = DefineDictionaryProperty<string>("SetParameters", ["properties", "setParameters"]);
        _setParametersXmlFileUri = DefineProperty<Uri>("SetParametersXmlFileUri", ["properties", "setParametersXmlFileUri"]);
        _skipAppData = DefineProperty<bool>("SkipAppData", ["properties", "skipAppData"]);
        _deployer = DefineProperty<string>("Deployer", ["properties", "deployer"], isOutput: true);
        _endOn = DefineProperty<DateTimeOffset>("EndOn", ["properties", "endTime"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _isComplete = DefineProperty<bool>("IsComplete", ["properties", "complete"], isOutput: true);
        _provisioningState = DefineProperty<MSDeployProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _startOn = DefineProperty<DateTimeOffset>("StartOn", ["properties", "startTime"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing SiteSlotInstanceExtension.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SiteSlotInstanceExtension
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteSlotInstanceExtension.</param>
    /// <returns>The existing SiteSlotInstanceExtension resource.</returns>
    public static SiteSlotInstanceExtension FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
