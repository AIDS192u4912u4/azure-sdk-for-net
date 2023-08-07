// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Weeks of month. </summary>
    public readonly partial struct ScheduledActionWeeksOfMonth : IEquatable<ScheduledActionWeeksOfMonth>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduledActionWeeksOfMonth"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduledActionWeeksOfMonth(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FirstValue = "First";
        private const string SecondValue = "Second";
        private const string ThirdValue = "Third";
        private const string FourthValue = "Fourth";
        private const string LastValue = "Last";

        /// <summary> First. </summary>
        public static ScheduledActionWeeksOfMonth First { get; } = new ScheduledActionWeeksOfMonth(FirstValue);
        /// <summary> Second. </summary>
        public static ScheduledActionWeeksOfMonth Second { get; } = new ScheduledActionWeeksOfMonth(SecondValue);
        /// <summary> Third. </summary>
        public static ScheduledActionWeeksOfMonth Third { get; } = new ScheduledActionWeeksOfMonth(ThirdValue);
        /// <summary> Fourth. </summary>
        public static ScheduledActionWeeksOfMonth Fourth { get; } = new ScheduledActionWeeksOfMonth(FourthValue);
        /// <summary> Last. </summary>
        public static ScheduledActionWeeksOfMonth Last { get; } = new ScheduledActionWeeksOfMonth(LastValue);
        /// <summary> Determines if two <see cref="ScheduledActionWeeksOfMonth"/> values are the same. </summary>
        public static bool operator ==(ScheduledActionWeeksOfMonth left, ScheduledActionWeeksOfMonth right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduledActionWeeksOfMonth"/> values are not the same. </summary>
        public static bool operator !=(ScheduledActionWeeksOfMonth left, ScheduledActionWeeksOfMonth right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScheduledActionWeeksOfMonth"/>. </summary>
        public static implicit operator ScheduledActionWeeksOfMonth(string value) => new ScheduledActionWeeksOfMonth(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduledActionWeeksOfMonth other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduledActionWeeksOfMonth other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
