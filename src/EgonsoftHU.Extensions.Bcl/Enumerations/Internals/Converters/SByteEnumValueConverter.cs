// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class SByteEnumValueConverter<TEnum> : EnumValueConverter<TEnum, sbyte>
        where TEnum : struct, Enum
    {
        public override sbyte ToUnderlyingType(object value)
        {
            return (sbyte)value;
        }

        public override ulong ToUInt64(sbyte underlyingValue)
        {
            return (ulong)underlyingValue;
        }

        public override TEnum ToEnumType(sbyte underlyingValue)
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), underlyingValue);
        }
    }
}
