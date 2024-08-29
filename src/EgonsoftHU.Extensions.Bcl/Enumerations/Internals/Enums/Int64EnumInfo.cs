﻿// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations.Internals.Enums
{
    internal sealed class Int64EnumInfo<TEnum> : EnumInfo<TEnum, long>
        where TEnum : struct, Enum
    {
        public Int64EnumInfo(string name, TEnum value)
            : base(name, value)
        {
        }
    }
}
