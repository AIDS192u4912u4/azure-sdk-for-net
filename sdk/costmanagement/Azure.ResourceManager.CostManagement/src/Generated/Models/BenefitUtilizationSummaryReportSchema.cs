// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The CSV file from the reportUrl and secondaryReportUrl blob link will consist of the following columns of benefit utilization data. UtilizedPercentage will be 0 for savings plans reports and non data bricks reservations. Utilization percentages will be 0 for data bricks reservations. </summary>
    public readonly partial struct BenefitUtilizationSummaryReportSchema : IEquatable<BenefitUtilizationSummaryReportSchema>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BenefitUtilizationSummaryReportSchema"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BenefitUtilizationSummaryReportSchema(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KindValue = "Kind";
        private const string AvgUtilizationPercentageValue = "AvgUtilizationPercentage";
        private const string BenefitOrderIdValue = "BenefitOrderId";
        private const string BenefitIdValue = "BenefitId";
        private const string BenefitTypeValue = "BenefitType";
        private const string MaxUtilizationPercentageValue = "MaxUtilizationPercentage";
        private const string MinUtilizationPercentageValue = "MinUtilizationPercentage";
        private const string UsageDateValue = "UsageDate";
        private const string UtilizedPercentageValue = "UtilizedPercentage";

        /// <summary> Kind. </summary>
        public static BenefitUtilizationSummaryReportSchema Kind { get; } = new BenefitUtilizationSummaryReportSchema(KindValue);
        /// <summary> AvgUtilizationPercentage. </summary>
        public static BenefitUtilizationSummaryReportSchema AvgUtilizationPercentage { get; } = new BenefitUtilizationSummaryReportSchema(AvgUtilizationPercentageValue);
        /// <summary> BenefitOrderId. </summary>
        public static BenefitUtilizationSummaryReportSchema BenefitOrderId { get; } = new BenefitUtilizationSummaryReportSchema(BenefitOrderIdValue);
        /// <summary> BenefitId. </summary>
        public static BenefitUtilizationSummaryReportSchema BenefitId { get; } = new BenefitUtilizationSummaryReportSchema(BenefitIdValue);
        /// <summary> BenefitType. </summary>
        public static BenefitUtilizationSummaryReportSchema BenefitType { get; } = new BenefitUtilizationSummaryReportSchema(BenefitTypeValue);
        /// <summary> MaxUtilizationPercentage. </summary>
        public static BenefitUtilizationSummaryReportSchema MaxUtilizationPercentage { get; } = new BenefitUtilizationSummaryReportSchema(MaxUtilizationPercentageValue);
        /// <summary> MinUtilizationPercentage. </summary>
        public static BenefitUtilizationSummaryReportSchema MinUtilizationPercentage { get; } = new BenefitUtilizationSummaryReportSchema(MinUtilizationPercentageValue);
        /// <summary> UsageDate. </summary>
        public static BenefitUtilizationSummaryReportSchema UsageDate { get; } = new BenefitUtilizationSummaryReportSchema(UsageDateValue);
        /// <summary> UtilizedPercentage. </summary>
        public static BenefitUtilizationSummaryReportSchema UtilizedPercentage { get; } = new BenefitUtilizationSummaryReportSchema(UtilizedPercentageValue);
        /// <summary> Determines if two <see cref="BenefitUtilizationSummaryReportSchema"/> values are the same. </summary>
        public static bool operator ==(BenefitUtilizationSummaryReportSchema left, BenefitUtilizationSummaryReportSchema right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BenefitUtilizationSummaryReportSchema"/> values are not the same. </summary>
        public static bool operator !=(BenefitUtilizationSummaryReportSchema left, BenefitUtilizationSummaryReportSchema right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BenefitUtilizationSummaryReportSchema"/>. </summary>
        public static implicit operator BenefitUtilizationSummaryReportSchema(string value) => new BenefitUtilizationSummaryReportSchema(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BenefitUtilizationSummaryReportSchema other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BenefitUtilizationSummaryReportSchema other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
