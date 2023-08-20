// Copyright © 2022-2023 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="IEnumerable{T}"/> type.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Determines whether a sequence is <see langword="null"/> or contains no element.
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="sequence">The sequence to check if it is <see langword="null"/> or contains no element.</param>
        /// <returns><see langword="true"/> if the <paramref name="sequence"/> is <see langword="null"/> or contains no element; otherwise, <see langword="false"/>.</returns>
        public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IEnumerable<T>? sequence)
        {
            return sequence is null || !sequence.Any();
        }
    }
}
