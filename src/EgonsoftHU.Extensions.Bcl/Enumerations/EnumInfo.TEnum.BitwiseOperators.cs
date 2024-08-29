// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using EgonsoftHU.Extensions.Bcl.Exceptions;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    public partial class EnumInfo<TEnum>
    {
        public static EnumInfo<TEnum> operator ~(EnumInfo<TEnum> value)
        {
            return EnumTypeCode switch
            {
                System.TypeCode.SByte => ~(EnumInfo<TEnum, sbyte>)value,
                System.TypeCode.Int16 => ~(EnumInfo<TEnum, short>)value,
                System.TypeCode.Int32 => ~(EnumInfo<TEnum, int>)value,
                System.TypeCode.Int64 => ~(EnumInfo<TEnum, long>)value,
                System.TypeCode.Byte => ~(EnumInfo<TEnum, byte>)value,
                System.TypeCode.UInt16 => ~(EnumInfo<TEnum, ushort>)value,
                System.TypeCode.UInt32 => ~(EnumInfo<TEnum, uint>)value,
                System.TypeCode.UInt64 => ~(EnumInfo<TEnum, ulong>)value,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum> operator |(EnumInfo<TEnum> left, EnumInfo<TEnum> right)
        {
            return EnumTypeCode switch
            {
                System.TypeCode.SByte => (EnumInfo<TEnum, sbyte>)left | (EnumInfo<TEnum, sbyte>)right,
                System.TypeCode.Int16 => (EnumInfo<TEnum, short>)left | (EnumInfo<TEnum, short>)right,
                System.TypeCode.Int32 => (EnumInfo<TEnum, int>)left | (EnumInfo<TEnum, int>)right,
                System.TypeCode.Int64 => (EnumInfo<TEnum, long>)left | (EnumInfo<TEnum, long>)right,
                System.TypeCode.Byte => (EnumInfo<TEnum, byte>)left | (EnumInfo<TEnum, byte>)right,
                System.TypeCode.UInt16 => (EnumInfo<TEnum, ushort>)left | (EnumInfo<TEnum, ushort>)right,
                System.TypeCode.UInt32 => (EnumInfo<TEnum, uint>)left | (EnumInfo<TEnum, uint>)right,
                System.TypeCode.UInt64 => (EnumInfo<TEnum, ulong>)left | (EnumInfo<TEnum, ulong>)right,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum> operator &(EnumInfo<TEnum> left, EnumInfo<TEnum> right)
        {
            return EnumTypeCode switch
            {
                System.TypeCode.SByte => (EnumInfo<TEnum, sbyte>)left & (EnumInfo<TEnum, sbyte>)right,
                System.TypeCode.Int16 => (EnumInfo<TEnum, short>)left & (EnumInfo<TEnum, short>)right,
                System.TypeCode.Int32 => (EnumInfo<TEnum, int>)left & (EnumInfo<TEnum, int>)right,
                System.TypeCode.Int64 => (EnumInfo<TEnum, long>)left & (EnumInfo<TEnum, long>)right,
                System.TypeCode.Byte => (EnumInfo<TEnum, byte>)left & (EnumInfo<TEnum, byte>)right,
                System.TypeCode.UInt16 => (EnumInfo<TEnum, ushort>)left & (EnumInfo<TEnum, ushort>)right,
                System.TypeCode.UInt32 => (EnumInfo<TEnum, uint>)left & (EnumInfo<TEnum, uint>)right,
                System.TypeCode.UInt64 => (EnumInfo<TEnum, ulong>)left & (EnumInfo<TEnum, ulong>)right,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum> operator ^(EnumInfo<TEnum> left, EnumInfo<TEnum> right)
        {
            return EnumTypeCode switch
            {
                System.TypeCode.SByte => (EnumInfo<TEnum, sbyte>)left ^ (EnumInfo<TEnum, sbyte>)right,
                System.TypeCode.Int16 => (EnumInfo<TEnum, short>)left ^ (EnumInfo<TEnum, short>)right,
                System.TypeCode.Int32 => (EnumInfo<TEnum, int>)left ^ (EnumInfo<TEnum, int>)right,
                System.TypeCode.Int64 => (EnumInfo<TEnum, long>)left ^ (EnumInfo<TEnum, long>)right,
                System.TypeCode.Byte => (EnumInfo<TEnum, byte>)left ^ (EnumInfo<TEnum, byte>)right,
                System.TypeCode.UInt16 => (EnumInfo<TEnum, ushort>)left ^ (EnumInfo<TEnum, ushort>)right,
                System.TypeCode.UInt32 => (EnumInfo<TEnum, uint>)left ^ (EnumInfo<TEnum, uint>)right,
                System.TypeCode.UInt64 => (EnumInfo<TEnum, ulong>)left ^ (EnumInfo<TEnum, ulong>)right,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }
    }
}
