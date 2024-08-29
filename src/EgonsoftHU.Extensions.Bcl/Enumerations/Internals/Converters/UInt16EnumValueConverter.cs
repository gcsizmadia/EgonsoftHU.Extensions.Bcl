// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class UInt16EnumValueConverter<TEnum> : EnumValueConverter<TEnum, ushort>
        where TEnum : struct, Enum
    {
        public override ushort ToUnderlyingType(object value)
        {
            return (ushort)value;
        }

        public override ulong ToUInt64(ushort underlyingValue)
        {
            return underlyingValue;
        }

        public override TEnum ToEnumType(ushort underlyingValue)
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), underlyingValue);
        }
    }
}
