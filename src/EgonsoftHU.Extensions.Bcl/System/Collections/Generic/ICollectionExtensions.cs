﻿// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Collections.Generic;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="ICollection{T}"/> type.
    /// </summary>
    public static class ICollectionExtensions
    {
        /// <summary>
        /// Adds the elements of the specified collection to the end of the current <paramref name="collection"/>.
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="collection">The current collection to the end of which the elements of the specified collection will be added.</param>
        /// <param name="items">
        /// The collection whose elements should be added to the end of the current <paramref name="collection"/>.
        /// The collection itself cannot be <see langword="null" />,
        /// but it can contain elements that are <see langword="null" />, if type <typeparamref name="T"/> is a nullable reference/value type.
        /// </param>
        /// <exception cref="ArgumentNullException">Either <paramref name="collection"/> or <paramref name="items"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException"><paramref name="collection"/> is read-only.</exception>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            collection.ThrowIfNull();
            items.ThrowIfNull();

            if (collection.IsReadOnly)
            {
                throw new ArgumentException("The collection is read-only.", nameof(collection));
            }

            if (collection is List<T> list)
            {
                list.AddRange(items);
                return;
            }

            foreach (T? item in items)
            {
                collection.Add(item);
            }
        }
    }
}
