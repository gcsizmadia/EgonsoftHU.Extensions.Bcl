// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="String"/> type.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the specified string is <c>null</c> or <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns><c>true</c> if <paramref name="value"/> is <c>null</c> or <see cref="String.Empty"/>; otherwise, <c>false</c>.</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return String.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Indicates whether a specified string is <c>null</c>, <see cref="String.Empty"/>, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns><c>true</c> if <paramref name="value"/> is <c>null</c>, <see cref="String.Empty"/>, or if <paramref name="value"/> consists exclusively of white-space characters.</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }
    }
}
