// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

using EgonsoftHU.Extensions.Bcl.Constants;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="Type"/> type.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Gets the <see cref="Nullable{T}"/> type based on the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The value type from which a new nullable type should be constructed.</param>
        /// <returns>
        /// A <see cref="Nullable{T}"/> type that is
        /// the specified <paramref name="type"/> itself if it is a <see cref="Nullable{T}"/> type;
        /// a constructed <see cref="Nullable{T}"/> type if <paramref name="type"/> is a value type;
        /// otherwise, <c>null</c>.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="type"/> is <c>null</c>.</exception>
        [return: MaybeNull]
        public static Type AsNullableValueType(this Type type)
        {
            type.ThrowIfNull();

            TypeInfo typeInfo = type.GetTypeInfo();

            if (!typeInfo.IsValueType)
            {
                return null;
            }

            return
                !typeInfo.IsGenericType || GenericTypeDefinitions.Nullable != type.GetGenericTypeDefinition()
                    ? CreateNullableType(type)
                    : type;
        }

        private static Type CreateNullableType(Type type)
        {
            Type constructedType = GenericTypeDefinitions.Nullable.MakeGenericType(type);
            return constructedType;
        }
    }
}
