// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class ByteEnumValueConverter<TEnum> : EnumValueConverter<TEnum, byte>
        where TEnum : struct, Enum
    {
        public override byte ToUnderlyingType(object value)
        {
            return (byte)value;
        }

        public override ulong ToUInt64(byte underlyingValue)
        {
            return underlyingValue;
        }
    }
}
