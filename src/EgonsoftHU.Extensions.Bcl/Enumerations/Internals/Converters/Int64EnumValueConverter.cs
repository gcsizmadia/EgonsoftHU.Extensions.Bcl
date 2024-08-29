// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class Int64EnumValueConverter<TEnum> : EnumValueConverter<TEnum, long>
        where TEnum : struct, Enum
    {
        public override long ToUnderlyingType(object value)
        {
            return (long)value;
        }

        public override ulong ToUInt64(long underlyingValue)
        {
            return (ulong)underlyingValue;
        }

        public override TEnum ToEnumType(long underlyingValue)
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), underlyingValue);
        }
    }
}
