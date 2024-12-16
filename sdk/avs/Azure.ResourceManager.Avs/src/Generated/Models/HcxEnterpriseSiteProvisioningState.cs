// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> HCX Enterprise Site provisioning state. </summary>
    public readonly partial struct HcxEnterpriseSiteProvisioningState : IEquatable<HcxEnterpriseSiteProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HcxEnterpriseSiteProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HcxEnterpriseSiteProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Resource has been created. </summary>
        public static HcxEnterpriseSiteProvisioningState Succeeded { get; } = new HcxEnterpriseSiteProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static HcxEnterpriseSiteProvisioningState Failed { get; } = new HcxEnterpriseSiteProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static HcxEnterpriseSiteProvisioningState Canceled { get; } = new HcxEnterpriseSiteProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="HcxEnterpriseSiteProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HcxEnterpriseSiteProvisioningState left, HcxEnterpriseSiteProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HcxEnterpriseSiteProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HcxEnterpriseSiteProvisioningState left, HcxEnterpriseSiteProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HcxEnterpriseSiteProvisioningState"/>. </summary>
        public static implicit operator HcxEnterpriseSiteProvisioningState(string value) => new HcxEnterpriseSiteProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HcxEnterpriseSiteProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HcxEnterpriseSiteProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
