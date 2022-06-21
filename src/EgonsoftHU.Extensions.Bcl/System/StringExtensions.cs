// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Diagnostics.CodeAnalysis;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="String"/> type.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the specified string is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is <see langword="null"/> or <see cref="String.Empty"/>; otherwise, <see langword="false"/>.</returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
        {
            return String.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Indicates whether a specified string is <see langword="null"/>, <see cref="String.Empty"/>, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is <see langword="null"/>, <see cref="String.Empty"/>, or if <paramref name="value"/> consists exclusively of white-space characters.</returns>
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Gets the specified default value if the specified string is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <param name="defaultValue">The default value if <paramref name="value"/> is <see langword="null"/> or <see cref="String.Empty"/>.</param>
        /// <returns><paramref name="defaultValue"/> if <paramref name="value"/> is <see langword="null"/> or <see cref="String.Empty"/>; otherwise, <paramref name="value"/> itself.</returns>
        public static string? DefaultIfNullOrEmpty(this string? value, string? defaultValue = null)
        {
            return value.IsNullOrEmpty() ? defaultValue : value;
        }

        /// <summary>
        /// Gets the specified default value if the specified string is <see langword="null"/>, <see cref="String.Empty"/>, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <param name="defaultValue">The default value if <paramref name="value"/> is <see langword="null"/>, <see cref="String.Empty"/>, or consists only of white-space characters.</param>
        /// <returns><paramref name="defaultValue"/> if <paramref name="value"/> is <see langword="null"/>, <see cref="String.Empty"/>, or if <paramref name="value"/> consists exclusively of white-space characters; otherwise, <paramref name="value"/> itself.</returns>
        public static string? DefaultIfNullOrWhiteSpace(this string? value, string? defaultValue = null)
        {
            return value.IsNullOrWhiteSpace() ? defaultValue : value;
        }
    }
}
