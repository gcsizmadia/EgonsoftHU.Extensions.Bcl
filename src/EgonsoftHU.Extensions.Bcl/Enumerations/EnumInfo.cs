// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    public abstract class EnumInfo
    {
        public static EnumInfo<TEnum>? FromValue<TEnum>(TEnum value)
            where TEnum : struct, Enum
        {
            return EnumInfo<TEnum>.FromValue(value);
        }
    }
}
