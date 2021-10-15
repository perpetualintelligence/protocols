﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    /// <summary>
    /// Represents a protected string or a protected key. A secret is equatable over its <see cref="Type"/> and
    /// <see cref="Value"/>. It is a security concern to have multiple secrets with same identifying credentials.
    /// </summary>
    /// <remarks>
    /// Secrets are subject to timing attack, please use <see cref="SecretComparer"/> to compare the secrets explicitly.
    /// </remarks>
    /// <seealso cref="ExtractedSecret"/>
    /// <seealso cref="SecretTypes"/>
    /// <seealso cref="SecretComparer"/>
    [ToUnitTest]
    [Concept("Secrets Manager")]
    public sealed class Secret : IEquatable<Secret?>
    {
        /// <summary>
        /// The secret description.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The secret expiration date and time expressed in coordinated universal time (UTC).
        /// </summary>
        [JsonPropertyName("expiration")]
        public DateTimeOffset? Expiration { get; set; }

        /// <summary>
        /// The secret name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The secret type. Defaults to <see cref="SecretTypes.Sha"/>.
        /// </summary>
        /// <seealso cref="SecretTypes"/>
        [JsonPropertyName("type")]
        public string Type { get; set; } = SecretTypes.Sha;

        /// <summary>
        /// The secret value.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <inheritdoc/>
        public static bool operator !=(Secret? left, Secret? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public static bool operator ==(Secret? left, Secret? right)
        {
            return EqualityComparer<Secret?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as Secret);
        }

        /// <inheritdoc/>
        public bool Equals(Secret? other)
        {
            return other != null &&
                   Type == other.Type &&
                   ValueEquals(other.Value);
        }

        /// <inheritdoc/>
        [Todo("Hashcode for .NET2 why can't we use ^")]
        public override int GetHashCode()
        {
#if NETSTANDARD2_1_OR_GREATER
            return HashCode.Combine(Type, Value);
#else
            int hashCode = 1265339359;
            hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(Value);
            return hashCode;
#endif
        }

        private bool ValueEquals(string? value)
        {
            return SecretComparer.IsEqual(Value, value);
        }
    }
}
