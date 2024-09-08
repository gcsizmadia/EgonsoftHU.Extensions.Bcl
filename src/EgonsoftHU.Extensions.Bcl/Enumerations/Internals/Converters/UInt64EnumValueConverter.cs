// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class UInt64EnumValueConverter<TEnum> : EnumValueConverter<TEnum, ulong>
        where TEnum : struct, Enum
    {
        public override ulong ToUnderlyingType(object value)
        {
            return (ulong)value;
        }

        public override ulong ToUInt64(ulong underlyingValue)
        {
            return underlyingValue;
        }
    }
}
