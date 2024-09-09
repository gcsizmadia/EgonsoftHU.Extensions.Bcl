// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Linq;

using EgonsoftHU.Extensions.Bcl.Constants;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Serialization
{
    /// <summary>
    /// Provides a base class for serializing an enum value.
    /// </summary>
    public abstract class EnumValueSerializer
    {
#if NETFRAMEWORK || NETSTANDARD2_0
        private static readonly char[] NameSeparators = new[] { Chars.Comma };
#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumValueSerializer"/> type.
        /// </summary>
        protected EnumValueSerializer()
        {
        }

        /// <summary>
        /// Gets the default serializer for enum values.
        /// </summary>
        public static EnumValueSerializer Default { get; } = new DefaultEnumValueSerializer();

        /// <summary>
        /// Gets or sets the current serializer for enum values.
        /// </summary>
        public static EnumValueSerializer Current { get; set; } = Default;

        /// <summary>
        /// Converts the member of an enum type specified by the <typeparamref name="TEnum"/> type parameter into a string.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enumeration.</typeparam>
        /// <param name="enumeration">
        /// An instance of the <see cref="EnumInfo{TEnum}"/> type that represents a member of the <typeparamref name="TEnum"/> type.
        /// </param>
        /// <returns>A string representation of the enum member represented by the <paramref name="enumeration"/> parameter.</returns>
        public abstract string Serialize<TEnum>(EnumInfo<TEnum> enumeration) where TEnum : struct, Enum;

        /// <summary>
        /// Retrieves an <see cref="EnumInfo{TEnum}"/> instance by the specified <paramref name="serializedValue"/>.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enumeration.</typeparam>
        /// <param name="serializedValue">The string representation of an enumeration value.</param>
        /// <returns>
        /// An <see cref="EnumInfo{TEnum}"/> instance if <paramref name="serializedValue"/> is recognized as a valid enumeration value;
        /// otherwise, <see langword="null"/>.
        /// </returns>
        public abstract EnumInfo<TEnum>? Deserialize<TEnum>(string serializedValue) where TEnum : struct, Enum;

        /// <summary>
        /// Splits the value of the specified <paramref name="name"/> parameter by a comma.
        /// </summary>
        /// <param name="name">A string representation of an enumeration value.</param>
        /// <returns>
        /// The result of the string split operation.
        /// </returns>
        protected virtual string[] GetNames(string name)
        {
            return
#if NET5_0_OR_GREATER
                name.Split(Chars.Comma, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
#else
#if NETFRAMEWORK || NETSTANDARD2_0
                name.Split(NameSeparators, StringSplitOptions.RemoveEmptyEntries)
#else
                name.Split(Chars.Comma, StringSplitOptions.RemoveEmptyEntries)
#endif
                    .Select(value => value.Trim())
                    .Where(value => String.Empty != value)
#endif
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToArray();
        }

        private sealed class DefaultEnumValueSerializer : EnumValueSerializer
        {
            public override string Serialize<TEnum>(EnumInfo<TEnum> enumeration)
            {
                return
                    enumeration.Attributes.EnumMember?.Value
                    ??
                    enumeration.Name;
            }

            public override EnumInfo<TEnum>? Deserialize<TEnum>(string serializedValue)
            {
                return
                    EnumInfo<TEnum>.HasFlagsAttribute
                        ? DeserializeFlags<TEnum>(GetNames(serializedValue))
                        : DeserializeSingle<TEnum>(serializedValue);
            }

            private static EnumInfo<TEnum>? DeserializeSingle<TEnum>(string name)
                where TEnum : struct, Enum
            {
                return
                    EnumInfo<TEnum>
                        .DeclaredMembers
                        .SingleOrDefault(
                            member =>
                                String.Equals(name, member.Name, StringComparison.OrdinalIgnoreCase)
                                ||
                                String.Equals(name, member.Attributes.EnumMember?.Value, StringComparison.OrdinalIgnoreCase)
                        );
            }

            private static EnumInfo<TEnum>? DeserializeFlags<TEnum>(string[] names)
                where TEnum : struct, Enum
            {
                return
                    names
                        .Select(DeserializeSingle<TEnum>)
                        .OfType<EnumInfo<TEnum>>()
                        .Aggregate((first, second) => first | second);
            }
        }
    }
}
