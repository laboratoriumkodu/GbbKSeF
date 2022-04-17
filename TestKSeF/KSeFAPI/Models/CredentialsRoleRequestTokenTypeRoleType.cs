// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace KSeFAPI.Models
{
    /// <summary> The CredentialsRoleRequestTokenTypeRoleType. </summary>
    public readonly partial struct CredentialsRoleRequestTokenTypeRoleType : IEquatable<CredentialsRoleRequestTokenTypeRoleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CredentialsRoleRequestTokenTypeRoleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CredentialsRoleRequestTokenTypeRoleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntrospectionValue = "introspection";
        private const string InvoiceReadValue = "invoice_read";
        private const string InvoiceWriteValue = "invoice_write";
        private const string PaymentConfirmationWriteValue = "payment_confirmation_write";
        private const string CredentialsReadValue = "credentials_read";
        private const string CredentialsManageValue = "credentials_manage";
        private const string EnforcementOperationsValue = "enforcement_operations";

        /// <summary> introspection. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType Introspection { get; } = new CredentialsRoleRequestTokenTypeRoleType(IntrospectionValue);
        /// <summary> invoice_read. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType InvoiceRead { get; } = new CredentialsRoleRequestTokenTypeRoleType(InvoiceReadValue);
        /// <summary> invoice_write. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType InvoiceWrite { get; } = new CredentialsRoleRequestTokenTypeRoleType(InvoiceWriteValue);
        /// <summary> payment_confirmation_write. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType PaymentConfirmationWrite { get; } = new CredentialsRoleRequestTokenTypeRoleType(PaymentConfirmationWriteValue);
        /// <summary> credentials_read. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType CredentialsRead { get; } = new CredentialsRoleRequestTokenTypeRoleType(CredentialsReadValue);
        /// <summary> credentials_manage. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType CredentialsManage { get; } = new CredentialsRoleRequestTokenTypeRoleType(CredentialsManageValue);
        /// <summary> enforcement_operations. </summary>
        public static CredentialsRoleRequestTokenTypeRoleType EnforcementOperations { get; } = new CredentialsRoleRequestTokenTypeRoleType(EnforcementOperationsValue);
        /// <summary> Determines if two <see cref="CredentialsRoleRequestTokenTypeRoleType"/> values are the same. </summary>
        public static bool operator ==(CredentialsRoleRequestTokenTypeRoleType left, CredentialsRoleRequestTokenTypeRoleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CredentialsRoleRequestTokenTypeRoleType"/> values are not the same. </summary>
        public static bool operator !=(CredentialsRoleRequestTokenTypeRoleType left, CredentialsRoleRequestTokenTypeRoleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CredentialsRoleRequestTokenTypeRoleType"/>. </summary>
        public static implicit operator CredentialsRoleRequestTokenTypeRoleType(string value) => new CredentialsRoleRequestTokenTypeRoleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CredentialsRoleRequestTokenTypeRoleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CredentialsRoleRequestTokenTypeRoleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
