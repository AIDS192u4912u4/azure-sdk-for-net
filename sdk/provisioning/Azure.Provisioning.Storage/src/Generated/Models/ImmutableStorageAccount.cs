// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// This property enables and defines account-level immutability. Enabling the
/// feature auto-enables Blob Versioning.
/// </summary>
public partial class ImmutableStorageAccount : ProvisioningConstruct
{
    /// <summary>
    /// A boolean flag which enables account-level immutability. All the
    /// containers under such an account have object-level immutability
    /// enabled by default.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// Specifies the default account-level immutability policy which is
    /// inherited and applied to objects that do not possess an explicit
    /// immutability policy at the object level. The object-level immutability
    /// policy has higher precedence than the container-level immutability
    /// policy, which has a higher precedence than the account-level
    /// immutability policy.
    /// </summary>
    public BicepValue<AccountImmutabilityPolicy> ImmutabilityPolicy { get => _immutabilityPolicy; set => _immutabilityPolicy.Assign(value); }
    private readonly BicepValue<AccountImmutabilityPolicy> _immutabilityPolicy;

    /// <summary>
    /// Creates a new ImmutableStorageAccount.
    /// </summary>
    public ImmutableStorageAccount()
    {
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _immutabilityPolicy = BicepValue<AccountImmutabilityPolicy>.DefineProperty(this, "ImmutabilityPolicy", ["immutabilityPolicy"]);
    }
}
