// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Specifies whether a script cmdlet is intended to be invoked only through automation or visible to customers. </summary>
    public readonly partial struct ScriptCmdletAudience : IEquatable<ScriptCmdletAudience>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptCmdletAudience"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptCmdletAudience(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutomationValue = "Automation";
        private const string AnyValue = "Any";

        /// <summary> is automation. </summary>
        public static ScriptCmdletAudience Automation { get; } = new ScriptCmdletAudience(AutomationValue);
        /// <summary> is any. </summary>
        public static ScriptCmdletAudience Any { get; } = new ScriptCmdletAudience(AnyValue);
        /// <summary> Determines if two <see cref="ScriptCmdletAudience"/> values are the same. </summary>
        public static bool operator ==(ScriptCmdletAudience left, ScriptCmdletAudience right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptCmdletAudience"/> values are not the same. </summary>
        public static bool operator !=(ScriptCmdletAudience left, ScriptCmdletAudience right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScriptCmdletAudience"/>. </summary>
        public static implicit operator ScriptCmdletAudience(string value) => new ScriptCmdletAudience(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptCmdletAudience other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptCmdletAudience other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
