// Copyright © 2022-2023 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.Collections.Generic;
using System.Linq;

namespace EgonsoftHU.Extensions.Bcl
{
    partial class GenericExtensions
    {
        /// <summary>
        /// Returns a value as a sequence that contains only that value.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">A value to be returned as <see cref="IEnumerable{T}"/>.</param>
        /// <returns>Returns a sequence that contains only the specified <paramref name="value"/>.</returns>
        public static IEnumerable<T?> AsEnumerable<T>(this T? value)
        {
            yield return value;
        }

        /// <summary>
        /// Determines whether a specified collection contains the current value by using a specified <see cref="IEqualityComparer{T}"/>.
        /// If no equality comparer is specified then the default equality comparer will be used.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="acceptedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="equalityComparer">An equality comparer to compare values.</param>
        /// <param name="acceptedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection contains an element that has the specified value; otherwise, false.</returns>
        public static bool IsIn<T>(this T? value, IEqualityComparer<T?>? equalityComparer, params T?[] acceptedValues)
        {
            return
                equalityComparer is null
                    ? acceptedValues.Contains(value)
                    : acceptedValues.Contains(value, equalityComparer);
        }

        /// <summary>
        /// Determines whether a specified collection contains the current value by using the default equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="acceptedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="acceptedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection contains an element that has the specified value; otherwise, false.</returns>
        public static bool IsIn<T>(this T? value, params T?[] acceptedValues)
        {
            return value.IsIn(equalityComparer: null, acceptedValues);
        }

        /// <summary>
        /// Determines whether a specified collection does not contain the current value by using a specified <see cref="IEqualityComparer{T}"/>.
        /// If no equality comparer is specified then the default equality comparer will be used.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="deniedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="deniedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection does not contain an element that has the specified value; otherwise, false.</returns>
        public static bool IsNotIn<T>(this T? value, params T?[] deniedValues)
        {
            return !value.IsIn(deniedValues);
        }

        /// <summary>
        /// Determines whether a specified collection does not contain the current value by using the default equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="deniedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="equalityComparer">An equality comparer to compare values.</param>
        /// <param name="deniedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection does not contain an element that has the specified value; otherwise, false.</returns>
        public static bool IsNotIn<T>(this T? value, IEqualityComparer<T?>? equalityComparer, params T?[] deniedValues)
        {
            return !value.IsIn(equalityComparer, deniedValues);
        }
    }
}
