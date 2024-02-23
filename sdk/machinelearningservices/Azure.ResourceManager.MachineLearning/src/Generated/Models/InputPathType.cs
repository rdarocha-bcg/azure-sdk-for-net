// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Input path type for package inputs. </summary>
    internal readonly partial struct InputPathType : IEquatable<InputPathType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InputPathType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InputPathType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlValue = "Url";
        private const string PathIdValue = "PathId";
        private const string PathVersionValue = "PathVersion";

        /// <summary> Url. </summary>
        public static InputPathType Url { get; } = new InputPathType(UrlValue);
        /// <summary> PathId. </summary>
        public static InputPathType PathId { get; } = new InputPathType(PathIdValue);
        /// <summary> PathVersion. </summary>
        public static InputPathType PathVersion { get; } = new InputPathType(PathVersionValue);
        /// <summary> Determines if two <see cref="InputPathType"/> values are the same. </summary>
        public static bool operator ==(InputPathType left, InputPathType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InputPathType"/> values are not the same. </summary>
        public static bool operator !=(InputPathType left, InputPathType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InputPathType"/>. </summary>
        public static implicit operator InputPathType(string value) => new InputPathType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InputPathType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InputPathType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
