// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// OperationalInsightsWorkspace.
/// </summary>
public partial class OperationalInsightsWorkspace : ProvisionableResource
{
    /// <summary>
    /// The name of the workspace.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// The resource ID of the default Data Collection Rule to use for this
    /// workspace. Expected format is -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> DefaultDataCollectionRuleResourceId 
    {
        get { Initialize(); return _defaultDataCollectionRuleResourceId!; }
        set { Initialize(); _defaultDataCollectionRuleResourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _defaultDataCollectionRuleResourceId;

    /// <summary>
    /// The etag of the workspace.
    /// </summary>
    public BicepValue<ETag> ETag 
    {
        get { Initialize(); return _eTag!; }
        set { Initialize(); _eTag!.Assign(value); }
    }
    private BicepValue<ETag>? _eTag;

    /// <summary>
    /// Workspace features.
    /// </summary>
    public OperationalInsightsWorkspaceFeatures Features 
    {
        get { Initialize(); return _features!; }
        set { Initialize(); AssignOrReplace(ref _features, value); }
    }
    private OperationalInsightsWorkspaceFeatures? _features;

    /// <summary>
    /// Indicates whether customer managed storage is mandatory for query
    /// management.
    /// </summary>
    public BicepValue<bool> ForceCmkForQuery 
    {
        get { Initialize(); return _forceCmkForQuery!; }
        set { Initialize(); _forceCmkForQuery!.Assign(value); }
    }
    private BicepValue<bool>? _forceCmkForQuery;

    /// <summary>
    /// The identity of the resource. Current supported identity types: None,
    /// SystemAssigned, UserAssigned.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// The network access type for accessing Log Analytics ingestion.
    /// </summary>
    public BicepValue<OperationalInsightsPublicNetworkAccessType> PublicNetworkAccessForIngestion 
    {
        get { Initialize(); return _publicNetworkAccessForIngestion!; }
        set { Initialize(); _publicNetworkAccessForIngestion!.Assign(value); }
    }
    private BicepValue<OperationalInsightsPublicNetworkAccessType>? _publicNetworkAccessForIngestion;

    /// <summary>
    /// The network access type for accessing Log Analytics query.
    /// </summary>
    public BicepValue<OperationalInsightsPublicNetworkAccessType> PublicNetworkAccessForQuery 
    {
        get { Initialize(); return _publicNetworkAccessForQuery!; }
        set { Initialize(); _publicNetworkAccessForQuery!.Assign(value); }
    }
    private BicepValue<OperationalInsightsPublicNetworkAccessType>? _publicNetworkAccessForQuery;

    /// <summary>
    /// The workspace data retention in days. Allowed values are per pricing
    /// plan. See pricing tiers documentation for details.
    /// </summary>
    public BicepValue<int> RetentionInDays 
    {
        get { Initialize(); return _retentionInDays!; }
        set { Initialize(); _retentionInDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionInDays;

    /// <summary>
    /// The SKU of the workspace.
    /// </summary>
    public OperationalInsightsWorkspaceSku Sku 
    {
        get { Initialize(); return _sku!; }
        set { Initialize(); AssignOrReplace(ref _sku, value); }
    }
    private OperationalInsightsWorkspaceSku? _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// The daily volume cap for ingestion.
    /// </summary>
    public OperationalInsightsWorkspaceCapping WorkspaceCapping 
    {
        get { Initialize(); return _workspaceCapping!; }
        set { Initialize(); AssignOrReplace(ref _workspaceCapping, value); }
    }
    private OperationalInsightsWorkspaceCapping? _workspaceCapping;

    /// <summary>
    /// Workspace creation date.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// This is a read-only property. Represents the ID associated with the
    /// workspace.
    /// </summary>
    public BicepValue<Guid> CustomerId 
    {
        get { Initialize(); return _customerId!; }
    }
    private BicepValue<Guid>? _customerId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Workspace modification date.
    /// </summary>
    public BicepValue<DateTimeOffset> ModifiedOn 
    {
        get { Initialize(); return _modifiedOn!; }
    }
    private BicepValue<DateTimeOffset>? _modifiedOn;

    /// <summary>
    /// List of linked private link scope resources.
    /// </summary>
    public BicepList<OperationalInsightsPrivateLinkScopedResourceInfo> PrivateLinkScopedResources 
    {
        get { Initialize(); return _privateLinkScopedResources!; }
    }
    private BicepList<OperationalInsightsPrivateLinkScopedResourceInfo>? _privateLinkScopedResources;

    /// <summary>
    /// The provisioning state of the workspace.
    /// </summary>
    public BicepValue<OperationalInsightsWorkspaceEntityStatus> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<OperationalInsightsWorkspaceEntityStatus>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new OperationalInsightsWorkspace.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the OperationalInsightsWorkspace
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the OperationalInsightsWorkspace.</param>
    public OperationalInsightsWorkspace(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.OperationalInsights/workspaces", resourceVersion ?? "2023-09-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of OperationalInsightsWorkspace.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _defaultDataCollectionRuleResourceId = DefineProperty<ResourceIdentifier>("DefaultDataCollectionRuleResourceId", ["properties", "defaultDataCollectionRuleResourceId"]);
        _eTag = DefineProperty<ETag>("ETag", ["etag"]);
        _features = DefineModelProperty<OperationalInsightsWorkspaceFeatures>("Features", ["properties", "features"]);
        _forceCmkForQuery = DefineProperty<bool>("ForceCmkForQuery", ["properties", "forceCmkForQuery"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _publicNetworkAccessForIngestion = DefineProperty<OperationalInsightsPublicNetworkAccessType>("PublicNetworkAccessForIngestion", ["properties", "publicNetworkAccessForIngestion"]);
        _publicNetworkAccessForQuery = DefineProperty<OperationalInsightsPublicNetworkAccessType>("PublicNetworkAccessForQuery", ["properties", "publicNetworkAccessForQuery"]);
        _retentionInDays = DefineProperty<int>("RetentionInDays", ["properties", "retentionInDays"]);
        _sku = DefineModelProperty<OperationalInsightsWorkspaceSku>("Sku", ["properties", "sku"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _workspaceCapping = DefineModelProperty<OperationalInsightsWorkspaceCapping>("WorkspaceCapping", ["properties", "workspaceCapping"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createdDate"], isOutput: true);
        _customerId = DefineProperty<Guid>("CustomerId", ["properties", "customerId"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _modifiedOn = DefineProperty<DateTimeOffset>("ModifiedOn", ["properties", "modifiedDate"], isOutput: true);
        _privateLinkScopedResources = DefineListProperty<OperationalInsightsPrivateLinkScopedResourceInfo>("PrivateLinkScopedResources", ["properties", "privateLinkScopedResources"], isOutput: true);
        _provisioningState = DefineProperty<OperationalInsightsWorkspaceEntityStatus>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported OperationalInsightsWorkspace resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";

        /// <summary>
        /// 2015-03-20.
        /// </summary>
        public static readonly string V2015_03_20 = "2015-03-20";
    }

    /// <summary>
    /// Creates a reference to an existing OperationalInsightsWorkspace.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the OperationalInsightsWorkspace
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the OperationalInsightsWorkspace.</param>
    /// <returns>The existing OperationalInsightsWorkspace resource.</returns>
    public static OperationalInsightsWorkspace FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this OperationalInsightsWorkspace
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 4, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this OperationalInsightsWorkspace resource.
    /// </summary>
    /// <returns>The keys for this OperationalInsightsWorkspace resource.</returns>
    public OperationalInsightsWorkspaceSharedKeys GetKeys()
    {
        OperationalInsightsWorkspaceSharedKeys key = new();
        ((IBicepValue)key).Expression = new FunctionCallExpression(new MemberExpression(new IdentifierExpression(BicepIdentifier), "listKeys"));
        return key;
    }
}
