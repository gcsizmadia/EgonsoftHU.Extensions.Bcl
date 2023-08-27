﻿// Copyright © 2022-2023 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Diagnostics.CodeAnalysis;

namespace EgonsoftHU.Extensions.Bcl
{
#if NET5_0_OR_GREATER
    /// <summary>
    /// This class contains extension methods that are available for .NET numeric types:
    /// <see cref="SByte"/>,
    /// <see cref="Int16"/>,
    /// <see cref="Int32"/>,
    /// <see cref="Int64"/>,
    /// <see cref="Byte"/>,
    /// <see cref="UInt16"/>,
    /// <see cref="UInt32"/>,
    /// <see cref="UInt64"/>,
    /// <see cref="Half"/>,
    /// <see cref="Single"/>,
    /// <see cref="Double"/>,
    /// <see cref="Decimal"/>
    /// </summary>
#else
    /// <summary>
    /// This class contains extension methods that are available for .NET numeric types:
    /// <see cref="SByte"/>,
    /// <see cref="Int16"/>,
    /// <see cref="Int32"/>,
    /// <see cref="Int64"/>,
    /// <see cref="Byte"/>,
    /// <see cref="UInt16"/>,
    /// <see cref="UInt32"/>,
    /// <see cref="UInt64"/>,
    /// <see cref="Single"/>,
    /// <see cref="Double"/>,
    /// <see cref="Decimal"/>
    /// </summary>
#endif
    [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
    public static class NumberExtensions
    {
        #region IsZero

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this sbyte value)
        {
            return value == 0;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this short value)
        {
            return value == 0;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this int value)
        {
            return value == 0;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this long value)
        {
            return value == 0L;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this byte value)
        {
            return value == 0;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this ushort value)
        {
            return value == 0U;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this uint value)
        {
            return value == 0U;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        public static bool IsZero(this ulong value)
        {
            return value == 0UL;
        }

#if NET5_0_OR_GREATER
        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        /// <remarks>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</remarks>
        public static bool IsZero(this Half value)
        {
            return value == (Half)0f;
        }
#endif

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        /// <remarks>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</remarks>
        public static bool IsZero(this float value)
        {
            return value == 0f;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        /// <remarks>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</remarks>
        public static bool IsZero(this double value)
        {
            return value == 0d;
        }

        /// <summary>Determines if a value is zero.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero; otherwise, <see langword="false" />.</returns>
        /// <remarks>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</remarks>
        public static bool IsZero(this decimal value)
        {
            return value == Decimal.Zero;
        }

        #endregion

        #region IsNegative

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(SByte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this sbyte value)
        {
            return value < 0;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Int16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this short value)
        {
            return value < 0;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Int32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this int value)
        {
            return value < 0;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Int64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this long value)
        {
            return value < 0L;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Byte)" /> will return <see langword="true" />.</para>
        /// </remarks>
#if NET6_0_OR_GREATER
        [SuppressMessage("Style", "IDE0060:Remove unused parameter")]
#endif
        public static bool IsNegative(this byte value)
        {
            return false;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(UInt16)" /> will return <see langword="true" />.</para>
        /// </remarks>
#if NET6_0_OR_GREATER
        [SuppressMessage("Style", "IDE0060:Remove unused parameter")]
#endif
        public static bool IsNegative(this ushort value)
        {
            return false;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(UInt32)" /> will return <see langword="true" />.</para>
        /// </remarks>
#if NET6_0_OR_GREATER
        [SuppressMessage("Style", "IDE0060:Remove unused parameter")]
#endif
        public static bool IsNegative(this uint value)
        {
            return false;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(UInt64)" /> will return <see langword="true" />.</para>
        /// </remarks>
#if NET6_0_OR_GREATER
        [SuppressMessage("Style", "IDE0060:Remove unused parameter")]
#endif
        public static bool IsNegative(this ulong value)
        {
            return false;
        }

#if NET5_0_OR_GREATER
        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Half)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this Half value)
        {
            return Half.IsNegative(value);
        }
#endif

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Single)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this float value)
        {
#if NETCOREAPP || NETSTANDARD2_1_OR_GREATER
            return BitConverter.SingleToInt32Bits(value) < 0;
#else
            return BitConverter.DoubleToInt64Bits(value) < 0;
#endif
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Double)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegative(this double value)
        {
            return BitConverter.DoubleToInt64Bits(value) < 0L;
        }

        /// <summary>Determines if a value represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents negative zero or a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is also considered negative.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Decimal)" /> will return <see langword="true" />.</para>
        /// <para>Please note:<br/>C# compiler does not treat <c>-0m</c> as negative zero, although it does get both the sign and the scale correctly for <c>-0.0m</c>.</para>
        /// </remarks>
        public static bool IsNegative(this decimal value)
        {
            const int FlagsIndex = 3;

            int[] bits = Decimal.GetBits(value);
            int flags = bits[FlagsIndex];

            return flags < 0;
        }

        #endregion

        #region IsNegativeOrZero

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(SByte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this sbyte value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Int16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this short value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Int32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this int value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Int64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this long value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Byte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this byte value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(UInt16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this ushort value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(UInt32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this uint value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(UInt64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this ulong value)
        {
            return value.IsZero() || value.IsNegative();
        }

#if NET5_0_OR_GREATER
        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Half)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this Half value)
        {
            return value.IsZero() || value.IsNegative();
        }
#endif

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Single)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this float value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Double)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this double value)
        {
            return value.IsZero() || value.IsNegative();
        }

        /// <summary>Determines if a value is zero or represents a negative real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> is zero or represents a negative real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsPositive(Decimal)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsNegativeOrZero(this decimal value)
        {
            return value.IsZero() || value.IsNegative();
        }

        #endregion

        #region IsPositive

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(SByte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this sbyte value)
        {
            return value >= 0;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Int16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this short value)
        {
            return value >= 0;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Int32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this int value)
        {
            return value >= 0;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Int64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this long value)
        {
            return value >= 0L;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Byte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this byte value)
        {
            return true;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(UInt16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this ushort value)
        {
            return true;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(UInt32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this uint value)
        {
            return true;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(UInt64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this ulong value)
        {
            return true;
        }

#if NET5_0_OR_GREATER
        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Half)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this Half value)
        {
            return BitConverter.HalfToInt16Bits(value) >= 0;
        }
#endif

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Single)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this float value)
        {
#if NETCOREAPP || NETSTANDARD2_1_OR_GREATER
            return BitConverter.SingleToInt32Bits(value) >= 0;
#else
            return BitConverter.DoubleToInt64Bits(value) >= 0L;
#endif
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Double)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositive(this double value)
        {
            return BitConverter.DoubleToInt64Bits(value) >= 0L;
        }

        /// <summary>Determines if a value represents (positive) zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents (positive) zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>If this type has signed zero, then <c>-0</c> is not considered positive, but <c>+0</c> is.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Decimal)" /> will return <see langword="true" />.</para>
        /// <para>Please note:<br/>C# compiler does not treat <c>-0m</c> as negative zero, although it does get both the sign and the scale correctly for <c>-0.0m</c>.</para>
        /// </remarks>
        public static bool IsPositive(this decimal value)
        {
            const int FlagsIndex = 3;

            int[] bits = Decimal.GetBits(value);
            int flags = bits[FlagsIndex];

            return flags >= 0;
        }

        #endregion

        #region IsPositiveOrZero

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(SByte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this sbyte value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Int16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this short value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Int32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this int value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Int64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this long value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Byte)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this byte value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(UInt16)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this ushort value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(UInt32)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this uint value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(UInt64)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this ulong value)
        {
            return value.IsZero() || value.IsPositive();
        }

#if NET5_0_OR_GREATER
        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Half)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this Half value)
        {
            return value.IsZero() || value.IsPositive();
        }
#endif
        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Single)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this float value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Double)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this double value)
        {
            return value.IsZero() || value.IsPositive();
        }

        /// <summary>Determines if a value represents zero or a positive real number.</summary>
        /// <param name="value">The value to be checked.</param>
        /// <returns><see langword="true" /> if <paramref name="value" /> represents zero or a positive real number; otherwise, <see langword="false" />.</returns>
        /// <remarks>
        /// <para>This function treats both positive and negative zero as zero and so will return <see langword="true" /> for <c>+0.0</c> and <c>-0.0</c>.</para>
        /// <para>This function returning <see langword="false" /> does not imply that <see cref="IsNegative(Decimal)" /> will return <see langword="true" />.</para>
        /// </remarks>
        public static bool IsPositiveOrZero(this decimal value)
        {
            return value.IsZero() || value.IsPositive();
        }

        #endregion
    }
}
