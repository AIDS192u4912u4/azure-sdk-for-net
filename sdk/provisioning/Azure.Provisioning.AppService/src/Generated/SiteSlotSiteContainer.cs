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
/// SiteSlotSiteContainer.
/// </summary>
public partial class SiteSlotSiteContainer : Resource
{
    /// <summary>
    /// Site Container Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Auth Type.
    /// </summary>
    public BicepValue<SiteContainerAuthType> AuthType { get => _authType; set => _authType.Assign(value); }
    private readonly BicepValue<SiteContainerAuthType> _authType;

    /// <summary>
    /// List of environment variables.
    /// </summary>
    public BicepList<WebAppEnvironmentVariable> EnvironmentVariables { get => _environmentVariables; set => _environmentVariables.Assign(value); }
    private readonly BicepList<WebAppEnvironmentVariable> _environmentVariables;

    /// <summary>
    /// Image Name.
    /// </summary>
    public BicepValue<string> Image { get => _image; set => _image.Assign(value); }
    private readonly BicepValue<string> _image;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if the container is the main site
    /// container; &lt;code&gt;false&lt;/code&gt; otherwise.
    /// </summary>
    public BicepValue<bool> IsMain { get => _isMain; set => _isMain.Assign(value); }
    private readonly BicepValue<bool> _isMain;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Password Secret.
    /// </summary>
    public BicepValue<string> PasswordSecret { get => _passwordSecret; set => _passwordSecret.Assign(value); }
    private readonly BicepValue<string> _passwordSecret;

    /// <summary>
    /// StartUp Command.
    /// </summary>
    public BicepValue<string> StartUpCommand { get => _startUpCommand; set => _startUpCommand.Assign(value); }
    private readonly BicepValue<string> _startUpCommand;

    /// <summary>
    /// Target Port.
    /// </summary>
    public BicepValue<string> TargetPort { get => _targetPort; set => _targetPort.Assign(value); }
    private readonly BicepValue<string> _targetPort;

    /// <summary>
    /// UserManagedIdentity ClientId.
    /// </summary>
    public BicepValue<string> UserManagedIdentityClientId { get => _userManagedIdentityClientId; set => _userManagedIdentityClientId.Assign(value); }
    private readonly BicepValue<string> _userManagedIdentityClientId;

    /// <summary>
    /// User Name.
    /// </summary>
    public BicepValue<string> UserName { get => _userName; set => _userName.Assign(value); }
    private readonly BicepValue<string> _userName;

    /// <summary>
    /// List of volume mounts.
    /// </summary>
    public BicepList<SiteContainerVolumeMount> VolumeMounts { get => _volumeMounts; set => _volumeMounts.Assign(value); }
    private readonly BicepList<SiteContainerVolumeMount> _volumeMounts;

    /// <summary>
    /// Created Time.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Last Modified Time.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedOn { get => _lastModifiedOn; }
    private readonly BicepValue<DateTimeOffset> _lastModifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WebSiteSlot.
    /// </summary>
    public WebSiteSlot? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSiteSlot> _parent;

    /// <summary>
    /// Creates a new SiteSlotSiteContainer.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotSiteContainer.</param>
    /// <param name="resourceVersion">Version of the SiteSlotSiteContainer.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SiteSlotSiteContainer(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/slots/sitecontainers", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _authType = BicepValue<SiteContainerAuthType>.DefineProperty(this, "AuthType", ["properties", "authType"]);
        _environmentVariables = BicepList<WebAppEnvironmentVariable>.DefineProperty(this, "EnvironmentVariables", ["properties", "environmentVariables"]);
        _image = BicepValue<string>.DefineProperty(this, "Image", ["properties", "image"]);
        _isMain = BicepValue<bool>.DefineProperty(this, "IsMain", ["properties", "isMain"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _passwordSecret = BicepValue<string>.DefineProperty(this, "PasswordSecret", ["properties", "passwordSecret"]);
        _startUpCommand = BicepValue<string>.DefineProperty(this, "StartUpCommand", ["properties", "startUpCommand"]);
        _targetPort = BicepValue<string>.DefineProperty(this, "TargetPort", ["properties", "targetPort"]);
        _userManagedIdentityClientId = BicepValue<string>.DefineProperty(this, "UserManagedIdentityClientId", ["properties", "userManagedIdentityClientId"]);
        _userName = BicepValue<string>.DefineProperty(this, "UserName", ["properties", "userName"]);
        _volumeMounts = BicepList<SiteContainerVolumeMount>.DefineProperty(this, "VolumeMounts", ["properties", "volumeMounts"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _lastModifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedOn", ["properties", "lastModifiedTime"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSiteSlot>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SiteSlotSiteContainer.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotSiteContainer.</param>
    /// <param name="resourceVersion">Version of the SiteSlotSiteContainer.</param>
    /// <returns>The existing SiteSlotSiteContainer resource.</returns>
    public static SiteSlotSiteContainer FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
