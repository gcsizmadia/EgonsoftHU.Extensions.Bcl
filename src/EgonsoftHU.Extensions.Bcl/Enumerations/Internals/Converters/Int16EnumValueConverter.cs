// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class Int16EnumValueConverter<TEnum> : EnumValueConverter<TEnum, short>
        where TEnum : struct, Enum
    {
        public override short ToUnderlyingType(object value)
        {
            return (short)value;
        }

        public override ulong ToUInt64(short underlyingValue)
        {
            return (ulong)underlyingValue;
        }

        public override TEnum ToEnumType(short underlyingValue)
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), underlyingValue);
        }
    }
}
