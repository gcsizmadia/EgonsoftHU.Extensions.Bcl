// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods to throw exceptions.
    /// </summary>
    public static class ThrowExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <c>null</c>.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="param"/></typeparam>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfNull<T>(this T param, string paramName) where T : class
        {
            if (param is null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <c>null</c>.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="param"/></typeparam>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfNull<T>(this T? param, string paramName) where T : struct
        {
            if (param is null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <c>null</c> or <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfNullOrEmpty(this string param, string paramName)
        {
            if (param.IsNullOrEmpty())
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <c>null</c>, <see cref="String.Empty"/> or 
        /// consists only of white-space characters.
        /// </summary>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfNullOrWhiteSpace(this string param, string paramName)
        {
            if (param.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <see cref="Guid.Empty"/>.
        /// </summary>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfEmptyGuid(this Guid param, string paramName)
        {
            if (Guid.Empty == param)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
