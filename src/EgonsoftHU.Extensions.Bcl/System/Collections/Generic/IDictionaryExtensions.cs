// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="IDictionary{TKey, TValue}"/> type.
    /// </summary>
    public static class IDictionaryExtensions
    {
        /// <summary>
        /// Returns a read-only <see cref="IReadOnlyDictionary{TKey, TValue}"/> wrapper for the current dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary to wrap into a read-only wrapper.</param>
        /// <returns>An object that acts as a read-only wrapper around the current <see cref="IDictionary{TKey, TValue}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dictionary"/> is <see langword="null"/>.</exception>
        public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            where TKey : notnull
        {
            dictionary.ThrowIfNull();

            return dictionary switch
            {
                IReadOnlyDictionary<TKey, TValue> readOnly => readOnly,
                _ => new ReadOnlyDictionary<TKey, TValue>(dictionary)
            };
        }

        /// <summary>
        /// Returns a collection of key/value pairs that are sorted on the key.
        /// </summary>
        /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary the key/value pairs of which are sorted on the key.</param>
        /// <returns>A collection of the original key/value pairs that are sorted on the key.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dictionary"/> is <see langword="null"/>.</exception>
        public static SortedDictionary<TKey, TValue> AsSorted<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            where TKey : notnull
        {
            dictionary.ThrowIfNull();

            return dictionary switch
            {
                SortedDictionary<TKey, TValue> readOnly => readOnly,
                _ => new SortedDictionary<TKey, TValue>(dictionary)
            };
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
        /// <param name="dictionary">The dictionary from which the value for the specified key is retrieved.</param>
        /// <param name="key">The key whose value to get.</param>
        /// <returns>The value associated with the specified key, if the key is found; otherwise, <see cref="ArgumentException"/> is thrown.</returns>
        /// <exception cref="ArgumentNullException">Either <paramref name="dictionary"/> or <paramref name="key"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">The given <paramref name="key"/> was not present in the <paramref name="dictionary"/>.</exception>
        public static TValue GetOrThrow<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            dictionary.ThrowIfNull();
            key.ThrowIfNull();

            if (dictionary.TryGetValue(key, out TValue? value))
            {
                return value;
            }

            var ex = new ArgumentException($"The given key '{key}' was not present in the dictionary.", nameof(key));
            ex.Data["ParamValue"] = key;

            throw ex;
        }
    }
}
