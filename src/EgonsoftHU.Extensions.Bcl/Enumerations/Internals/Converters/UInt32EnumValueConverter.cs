// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class UInt32EnumValueConverter<TEnum> : EnumValueConverter<TEnum, uint>
        where TEnum : struct, Enum
    {
        public override uint ToUnderlyingType(object value)
        {
            return (uint)value;
        }

        public override ulong ToUInt64(uint underlyingValue)
        {
            return underlyingValue;
        }
    }
}
