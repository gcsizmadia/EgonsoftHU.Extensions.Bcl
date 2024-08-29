// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains utility methods for <see cref="Type"/> type.
    /// </summary>
    public static class TypeHelper
    {
        /// <summary>
        /// Gets the full name of the <see cref="Type"/>, if available; otherwise, the name of the <see cref="Type"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> the name of which to get.</typeparam>
        /// <returns>The full name of the <see cref="Type"/>, if available; otherwise, the name of the <see cref="Type"/>.</returns>
        public static string GetTypeName<T>()
        {
            return GetTypeName(typeof(T));
        }

        /// <summary>
        /// Gets the full name of the <see cref="Type"/>, if available; otherwise, the name of the <see cref="Type"/>.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> the name of which to get.</param>
        /// <returns>The full name of the <see cref="Type"/>, if available; otherwise, the name of the <see cref="Type"/>.</returns>
        public static string GetTypeName(Type type)
        {
            type.ThrowIfNull();

            return type.FullName ?? type.Name;
        }
    }
}
