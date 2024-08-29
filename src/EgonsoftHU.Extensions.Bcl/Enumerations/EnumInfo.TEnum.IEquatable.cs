﻿// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Diagnostics.CodeAnalysis;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    public partial class EnumInfo<TEnum> : IEquatable<EnumInfo<TEnum>>
    {
        /// <summary>
        /// Indicates whether the <paramref name="left"/> parameter is equal to the <paramref name="right"/> parameter.
        /// </summary>
        /// <param name="left">A value to compare with the <paramref name="right"/> parameter.</param>
        /// <param name="right">A value to compare with the <paramref name="left"/> parameter.</param>
        /// <returns>
        /// <see langword="true"/> if the <paramref name="left"/> parameter is equal to the <paramref name="right"/> parameter;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator ==(EnumInfo<TEnum>? left, EnumInfo<TEnum>? right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Indicates whether the <paramref name="left"/> parameter is not equal to the <paramref name="right"/> parameter.
        /// </summary>
        /// <param name="left">A value to compare with the <paramref name="right"/> parameter.</param>
        /// <param name="right">A value to compare with the <paramref name="left"/> parameter.</param>
        /// <returns>
        /// <see langword="true"/> if the <paramref name="left"/> parameter is not equal to the <paramref name="right"/> parameter;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator !=(EnumInfo<TEnum>? left, EnumInfo<TEnum>? right)
        {
            return !Equals(left, right);
        }

        public static bool Equals(EnumInfo<TEnum>? left, EnumInfo<TEnum>? right)
        {
            return left is null ? right is null : ReferenceEquals(left, right) || left.Equals(right);
        }

        /// <inheritdoc/>
        public bool Equals([NotNullWhen(true)] EnumInfo<TEnum>? other)
        {
            return Equals((object?)other);
        }

        public abstract override bool Equals([NotNullWhen(true)] object? obj);

        public abstract override int GetHashCode();
    }
}
