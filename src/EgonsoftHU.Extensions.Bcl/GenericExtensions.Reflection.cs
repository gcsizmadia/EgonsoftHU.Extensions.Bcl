﻿// Copyright © 2022-2023 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System;

namespace EgonsoftHU.Extensions.Bcl
{
    public partial class GenericExtensions
    {
        /// <summary>
        /// Gets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be get.</param>
        /// <param name="propertyName">The name of the property whose value should be get.</param>
        /// <returns>A property value of the source object if the property exists; otherwise, null.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="propertyName"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// No property is declared in <typeparamref name="TSource"/> type with the specified <paramref name="propertyName"/>.
        /// </exception>
        public static object? GetPropertyValue<TSource>(this TSource? sourceObject, string propertyName)
        {
            propertyName.ThrowIfNullOrWhiteSpace();

            propertyName.ThrowIfPropertyNotFound<TSource>(
                sourceObject.TryGetPropertyInfo(propertyName, out PropertyInfo? propertyInfo)
            );

            return propertyInfo.GetValue(sourceObject);
        }

        /// <summary>
        /// Gets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be get.</param>
        /// <param name="propertyName">The name of the property whose value should be get.</param>
        /// <param name="value">The value of a property of the source object.</param>
        /// <returns>Returns true if the property exists; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="propertyName"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        public static bool TryGetPropertyValue<TSource>(this TSource? sourceObject, string propertyName, out object? value)
        {
            propertyName.ThrowIfNullOrWhiteSpace();

            value =
                sourceObject.TryGetPropertyInfo(propertyName, out PropertyInfo? propertyInfo)
                    ? propertyInfo.GetValue(sourceObject)
                    : null;

            return propertyInfo.IsNotNull();
        }

        /// <summary>
        /// Sets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be set.</param>
        /// <param name="propertyName">The name of the property whose value should be set.</param>
        /// <param name="value">The value to be set as the value of the property of the source object.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="propertyName"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// No property is declared in <typeparamref name="TSource"/> type with the specified <paramref name="propertyName"/>.
        /// </exception>
        public static void SetPropertyValue<TSource>(this TSource? sourceObject, string propertyName, object? value)
        {
            propertyName.ThrowIfNullOrWhiteSpace();

            propertyName.ThrowIfPropertyNotFound<TSource>(
                sourceObject.TryGetPropertyInfo(propertyName, out PropertyInfo? propertyInfo)
            );

            propertyInfo.SetValue(sourceObject, value);
        }

        /// <summary>
        /// Sets the value of an instance property of the source object using reflection.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <param name="sourceObject">The source object whose property value should be set.</param>
        /// <param name="propertyName">The name of the property whose value should be set.</param>
        /// <param name="value">The value to be set as the value of the property of the source object.</param>
        /// <returns>Returns true if the property value has been set; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="propertyName"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters.
        /// </exception>
        public static bool TrySetPropertyValue<TSource>(this TSource? sourceObject, string propertyName, object? value)
            where TSource : class?
        {
            propertyName.ThrowIfNullOrWhiteSpace();

            if (sourceObject.TryGetPropertyInfo(propertyName, out PropertyInfo? propertyInfo))
            {
                propertyInfo.SetValue(sourceObject, value);
                return true;
            }

            return false;
        }

        private static bool TryGetPropertyInfo<TSource>(this TSource _, string propertyName, [NotNullWhen(true)] out PropertyInfo? propertyInfo)
        {
            propertyName.ThrowIfNullOrWhiteSpace();

            Type sourceType = typeof(TSource);

            propertyInfo = sourceType.GetTypeInfo().GetDeclaredProperty(propertyName);

            return propertyInfo.IsNotNull();
        }

        private static void ThrowIfPropertyNotFound<TSource>(this string propertyName, [DoesNotReturnIf(false)] bool propertyFound)
        {
            propertyName.ThrowIfNullOrWhiteSpace();

            if (!propertyFound)
            {
                Type sourceType = typeof(TSource);

                string typeName = sourceType.FullName ?? sourceType.Name;

                var ex = new ArgumentException($"[{propertyName}] property is not declared in [{typeName}] type.", nameof(propertyName));
                ex.Data["TypeName"] = typeName;
                ex.Data["PropertyName"] = propertyName;

                throw ex;
            }
        }
    }
}
