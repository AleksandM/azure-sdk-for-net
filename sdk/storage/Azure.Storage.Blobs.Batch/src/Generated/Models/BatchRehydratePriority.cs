// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Batch.Models
{
    /// <summary> The BatchRehydratePriority. </summary>
    internal readonly partial struct BatchRehydratePriority : IEquatable<BatchRehydratePriority>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchRehydratePriority"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchRehydratePriority(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HighValue = "High";
        private const string StandardValue = "Standard";

        /// <summary> High. </summary>
        public static BatchRehydratePriority High { get; } = new BatchRehydratePriority(HighValue);
        /// <summary> Standard. </summary>
        public static BatchRehydratePriority Standard { get; } = new BatchRehydratePriority(StandardValue);
        /// <summary> Determines if two <see cref="BatchRehydratePriority"/> values are the same. </summary>
        public static bool operator ==(BatchRehydratePriority left, BatchRehydratePriority right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchRehydratePriority"/> values are not the same. </summary>
        public static bool operator !=(BatchRehydratePriority left, BatchRehydratePriority right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchRehydratePriority"/>. </summary>
        public static implicit operator BatchRehydratePriority(string value) => new BatchRehydratePriority(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchRehydratePriority other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchRehydratePriority other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
