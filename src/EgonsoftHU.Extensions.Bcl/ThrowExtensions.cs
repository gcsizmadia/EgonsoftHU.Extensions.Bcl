// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods to throw exceptions.
    /// </summary>
    public static partial class ThrowExtensions
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <see langword="null"/>.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="param"/></typeparam>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="param"/> is <see langword="null"/>.</exception>
        public static void ThrowIfNull<T>([NotNull] this T? param, [CallerArgumentExpression("param")] string? paramName = null)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(param, paramName);
#else
            paramName.ThrowIf(param is null);
#endif
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <see langword="null"/> or <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="param"/> is <see langword="null"/> or <see cref="String.Empty"/>.</exception>
        public static void ThrowIfNullOrEmpty([NotNull] this string? param, [CallerArgumentExpression("param")] string? paramName = null)
        {
            paramName.ThrowIf(param.IsNullOrEmpty());
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <see langword="null"/>, <see cref="String.Empty"/> or 
        /// consists only of white-space characters.
        /// </summary>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="param"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        public static void ThrowIfNullOrWhiteSpace([NotNull] this string? param, [CallerArgumentExpression("param")] string? paramName = null)
        {
            paramName.ThrowIf(param.IsNullOrWhiteSpace());
        }

        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if <paramref name="param"/> is <see cref="Guid.Empty"/>.
        /// </summary>
        /// <param name="param">The parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="param"/> is <see cref="Guid.Empty"/>.</exception>
        public static void ThrowIfEmptyGuid(this Guid param, [CallerArgumentExpression("param")] string? paramName = null)
        {
            paramName.ThrowIf(Guid.Empty == param);
        }

        private static void ThrowIf(this string? paramName, [DoesNotReturnIf(true)] bool condition)
        {
            if (condition)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
