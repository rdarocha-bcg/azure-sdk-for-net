// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MaterializationStoreType. </summary>
    public readonly partial struct MaterializationStoreType : IEquatable<MaterializationStoreType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MaterializationStoreType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MaterializationStoreType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string OnlineValue = "Online";
        private const string OfflineValue = "Offline";
        private const string OnlineAndOfflineValue = "OnlineAndOffline";

        /// <summary> None. </summary>
        public static MaterializationStoreType None { get; } = new MaterializationStoreType(NoneValue);
        /// <summary> Online. </summary>
        public static MaterializationStoreType Online { get; } = new MaterializationStoreType(OnlineValue);
        /// <summary> Offline. </summary>
        public static MaterializationStoreType Offline { get; } = new MaterializationStoreType(OfflineValue);
        /// <summary> OnlineAndOffline. </summary>
        public static MaterializationStoreType OnlineAndOffline { get; } = new MaterializationStoreType(OnlineAndOfflineValue);
        /// <summary> Determines if two <see cref="MaterializationStoreType"/> values are the same. </summary>
        public static bool operator ==(MaterializationStoreType left, MaterializationStoreType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MaterializationStoreType"/> values are not the same. </summary>
        public static bool operator !=(MaterializationStoreType left, MaterializationStoreType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MaterializationStoreType"/>. </summary>
        public static implicit operator MaterializationStoreType(string value) => new MaterializationStoreType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MaterializationStoreType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MaterializationStoreType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
