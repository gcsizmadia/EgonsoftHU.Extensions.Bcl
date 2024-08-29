// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Converters
{
    internal sealed class Int32EnumValueConverter<TEnum> : EnumValueConverter<TEnum, int>
        where TEnum : struct, Enum
    {
        public override int ToUnderlyingType(object value)
        {
            return (int)value;
        }

        public override ulong ToUInt64(int underlyingValue)
        {
            return (ulong)underlyingValue;
        }

        public override TEnum ToEnumType(int underlyingValue)
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), underlyingValue);
        }
    }
}
