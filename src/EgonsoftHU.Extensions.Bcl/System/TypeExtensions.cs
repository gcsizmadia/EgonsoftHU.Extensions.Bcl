// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Reflection;

using static EgonsoftHU.Extensions.Bcl.Constants;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="Type"/> type.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Gets a constructed <see cref="Nullable{T}"/> type where T is a specified value type.
        /// </summary>
        /// <param name="type">The value type from which a new nullable type should be constructed.</param>
        /// <returns>
        /// Returns itself if <paramref name="type"/> is already a <see cref="Nullable{T}"/> type; 
        /// a constructed <see cref="Nullable{T}"/> type if <paramref name="type"/> is a value type; 
        /// otherwise, <c>null</c>.
        /// </returns>
        public static Type AsNullableValueType(this Type type)
        {
            if (type is null)
            {
                return null;
            }

            TypeInfo typeInfo = type.GetTypeInfo();

            if (!typeInfo.IsValueType)
            {
                return null;
            }

            if (typeInfo.IsGenericType)
            {
                Type genericTypeDefinition = type.GetGenericTypeDefinition();

                if (GenericTypeDefinitions.Nullable == genericTypeDefinition)
                {
                    return type;
                }
                else
                {
                    return CreateNullableType(type);
                }
            }
            else
            {
                return CreateNullableType(type);
            }
        }

        private static Type CreateNullableType(Type type)
        {
            Type constructedType = GenericTypeDefinitions.Nullable.MakeGenericType(type);
            return constructedType;
        }
    }
}
