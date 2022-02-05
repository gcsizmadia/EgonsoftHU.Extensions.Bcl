// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains generic extension methods that are available for any type.
    /// </summary>
    public static class GenericExtensions
    {
        private static readonly Dictionary<Type, bool> isValueTypeCacheByType = new Dictionary<Type, bool>();

        /// <summary>
        /// Determines whether a specified <paramref name="value"/> is the default value of its <see cref="Type"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns true for value types if default(<typeparamref name="T"/>) equals to <paramref name="value"/>; true for reference types if <paramref name="value"/> is null; otherwise, false.</returns>
        public static bool IsDefaultValue<T>(this T value)
        {
            Type type = typeof(T);

            if (!isValueTypeCacheByType.TryGetValue(type, out bool isValueType))
            {
                isValueType = type.GetTypeInfo().IsValueType;
                isValueTypeCacheByType[type] = isValueType;
            }

            var defaultValue = default(T);

            return isValueType ? defaultValue.Equals(value) : value is null;
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
        public static bool IsIn<T>(this T value, IEqualityComparer<T> equalityComparer, params T[] acceptedValues) =>
            equalityComparer is null
                ? acceptedValues.Contains(value)
                : acceptedValues.Contains(value, equalityComparer);

        /// <summary>
        /// Determines whether a specified collection contains the current value by using the default equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="acceptedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="acceptedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection contains an element that has the specified value; otherwise, false.</returns>
        public static bool IsIn<T>(this T value, params T[] acceptedValues) =>
            value.IsIn(equalityComparer: null, acceptedValues);

        /// <summary>
        /// Determines whether a specified collection does not contain the current value by using a specified <see cref="IEqualityComparer{T}"/>.
        /// If no equality comparer is specified then the default equality comparer will be used.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="deniedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="deniedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection does not contain an element that has the specified value; otherwise, false.</returns>
        public static bool IsNotIn<T>(this T value, params T[] deniedValues) =>
            !value.IsIn(deniedValues);

        /// <summary>
        /// Determines whether a specified collection does not contain the current value by using the default equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of both the current value and the elements in <paramref name="deniedValues"/>.</typeparam>
        /// <param name="value">The value to locate in the collection.</param>
        /// <param name="equalityComparer">An equality comparer to compare values.</param>
        /// <param name="deniedValues">A collection in which to locate a value.</param>
        /// <returns>Returns true if the specified collection does not contain an element that has the specified value; otherwise, false.</returns>
        public static bool IsNotIn<T>(this T value, IEqualityComparer<T> equalityComparer, params T[] deniedValues) =>
            !value.IsIn(equalityComparer, deniedValues);

        /// <summary>
        /// Returns a value as a sequence that contains only that value.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">A value to be returned as <see cref="IEnumerable{T}"/>.</param>
        /// <returns>Returns a sequence that contains only specified value.</returns>
        public static IEnumerable<T> AsEnumerable<T>(this T value)
        {
            yield return value;
        }

        /// <summary>
        /// Sets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be set.</param>
        /// <param name="propertyName">The name of the property whose value should be set.</param>
        /// <param name="value">The value to be set as the value of the property of the source object.</param>
        /// <exception cref="ArgumentNullException">Thrown when this extension method is called on an object that is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the type of the source object does not declare a public property with the specified name.</exception>
        public static void SetPropertyValue<TSource>(this TSource sourceObject, string propertyName, object value)
            where TSource : class
        {
            if (TryGetPropertyInfo(sourceObject, propertyName, shouldThrowException: true, out PropertyInfo propertyInfo))
            {
                propertyInfo.SetValue(sourceObject, value);
            }
        }

        /// <summary>
        /// Sets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be set.</param>
        /// <param name="propertyName">The name of the property whose value should be set.</param>
        /// <param name="value">The value to be set as the value of the property of the source object.</param>
        /// <returns>Returns true if the property value has been set; otherwise, false.</returns>
        public static bool TrySetPropertyValue<TSource>(this TSource sourceObject, string propertyName, object value)
            where TSource : class
        {
            if (TryGetPropertyInfo(sourceObject, propertyName, shouldThrowException: false, out PropertyInfo propertyInfo))
            {
                propertyInfo.SetValue(sourceObject, value);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be get.</param>
        /// <param name="propertyName">The name of the property whose value should be get.</param>
        /// <returns>A property value of the source object if the property exists; otherwise, null.</returns>
        public static object GetPropertyValue<TSource>(this TSource sourceObject, string propertyName)
            where TSource : class
        {
            return
                TryGetPropertyInfo(sourceObject, propertyName, shouldThrowException: true, out PropertyInfo propertyInfo)
                    ? propertyInfo.GetValue(sourceObject)
                    : null;
        }

        /// <summary>
        /// Gets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be get.</param>
        /// <param name="propertyName">The name of the property whose value should be get.</param>
        /// <param name="value">The value of a property of the source object.</param>
        /// <returns>Returns true if the property exists; otherwise, false.</returns>
        public static bool TryGetPropertyValue<TSource>(this TSource sourceObject, string propertyName, out object value)
            where TSource : class
        {
            if (TryGetPropertyInfo(sourceObject, propertyName, shouldThrowException: false, out PropertyInfo propertyInfo))
            {
                value = propertyInfo.GetValue(sourceObject);
                return true;
            }

            value = null;
            return false;
        }

        /// <summary>
        /// Gets a value using a specified value selector that gets the source object as input parameter.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <typeparam name="TResult">The type of the value that is returned by the value selector.</typeparam>
        /// <param name="sourceObject">The source object that can be used by a value selector.</param>
        /// <param name="valueSelector">A value selector that gets the source object as input parameter and returns a value.</param>
        /// <returns>Returns a value returned by the specified value selector.</returns>
        /// <exception cref="ArgumentNullException">Thrown when this extension method is called on an object that is null or the value selector is null.</exception>
        public static TResult GetValue<TSource, TResult>(this TSource sourceObject, Func<TSource, TResult> valueSelector)
            where TSource : class
        {
            sourceObject.ThrowIfNull(nameof(sourceObject));
            valueSelector.ThrowIfNull(nameof(valueSelector));

            return valueSelector.Invoke(sourceObject);
        }

        /// <summary>
        /// Gets a value using a specified value selector or a specified default value. The value selector gets the source object as input parameter.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <typeparam name="TResult">The type of the value that is returned by the value selector.</typeparam>
        /// <param name="sourceObject">The source object that can be used by a value selector.</param>
        /// <param name="valueSelector">A value selector that gets the source object as input parameter and returns a value.</param>
        /// <param name="defaultValue">The value to be returned if the source object is null or the value returned by the value selector is the default value of the return type.</param>
        /// <returns>Returns a value returned by the specified value selector if source object is not null and the returned value is not the default value of the return type; otherwise, the specified default value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the value selector is null.</exception>
        public static TResult GetValueOrDefault<TSource, TResult>(this TSource sourceObject, Func<TSource, TResult> valueSelector, TResult defaultValue)
            where TSource : class
        {
            if (sourceObject is null)
            {
                return defaultValue;
            }

            valueSelector.ThrowIfNull(nameof(valueSelector));

            TResult value = valueSelector.Invoke(sourceObject);

            return value.IsDefaultValue() ? defaultValue : value;
        }

        /// <summary>
        /// Gets a string value using a specified value selector or null. The value selector gets the source object as input parameter.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object that can be used by a value selector.</param>
        /// <param name="valueSelector">A value selector that gets the source object as input parameter and returns a value.</param>
        /// <returns>Returns a string value returned by the specified value selector if source object is not null and the returned value is not null; otherwise, null.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the value selector is null.</exception>
        public static string GetStringValueOrNull<TSource>(this TSource sourceObject, Func<TSource, string> valueSelector)
            where TSource : class
        {
            return sourceObject.GetValueOrDefault(valueSelector, null);
        }

        /// <summary>
        /// Gets a string value using a specified value selector or <see cref="String.Empty"/>. The value selector gets the source object as input parameter.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object that can be used by a value selector.</param>
        /// <param name="valueSelector">A value selector that gets the source object as input parameter and returns a value.</param>
        /// <returns>Returns a string value returned by the specified value selector if source object is not null and the returned value is not null; otherwise, <see cref="String.Empty"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the value selector is null.</exception>
        public static string GetStringValueOrEmptyString<TSource>(this TSource sourceObject, Func<TSource, string> valueSelector)
            where TSource : class
        {
            return sourceObject.GetValueOrDefault(valueSelector, String.Empty);
        }

        private static bool TryGetPropertyInfo<TSource>(TSource sourceObject, string propertyName, bool shouldThrowException, out PropertyInfo propertyInfo)
            where TSource : class
        {
            propertyInfo = null;

            if (sourceObject is null)
            {
                if (shouldThrowException)
                {
                    throw new ArgumentNullException(nameof(sourceObject));
                }

                return false;
            }

            propertyInfo = sourceObject.GetType().GetTypeInfo().GetDeclaredProperty(propertyName);

            if (propertyInfo is null)
            {
                if (shouldThrowException)
                {
                    throw new InvalidOperationException($"No public property is declared in [{typeof(TSource).FullName}] with the following name: [{propertyName}]");
                }

                return false;
            }

            return true;
        }
    }
}
