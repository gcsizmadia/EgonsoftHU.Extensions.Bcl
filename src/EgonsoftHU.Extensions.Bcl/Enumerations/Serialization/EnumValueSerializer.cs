// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Serialization
{
    /// <summary>
    /// Provides a base class for serializing an enum value.
    /// </summary>
    public abstract class EnumValueSerializer
    {
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

        private sealed class DefaultEnumValueSerializer : EnumValueSerializer
        {
            public override string Serialize<TEnum>(EnumInfo<TEnum> enumeration)
            {
                return
                    enumeration.Attributes.EnumMember?.Value
                    ??
                    enumeration.Name;
            }
        }
    }
}
