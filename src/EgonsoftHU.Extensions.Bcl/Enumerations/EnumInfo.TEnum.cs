// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

using EgonsoftHU.Extensions.Bcl.Enumerations.Internals;
using EgonsoftHU.Extensions.Bcl.Exceptions;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    [DebuggerDisplay("{DebuggerDisplayValue}")]
    public abstract partial class EnumInfo<TEnum> : EnumInfo
        where TEnum : struct, Enum
    {
        private protected static readonly Type EnumType;

        private protected static readonly TypeInfo EnumTypeInfo;

        private protected static readonly TypeCode EnumTypeCode;

        private protected static readonly Type EnumUnderlyingType;

        private protected static readonly Type EnumInfoType;

        private protected static readonly bool HasFlagsAttribute;

        private protected static readonly ReadOnlyDictionary<Type, Func<Type, Type>> ConcreteTypeFactoryByUnderlyingType;

        private protected static readonly ReadOnlyDictionary<string, FieldInfo> FieldsByEnumMemberName;

        public static EnumInfo<TEnum>? FromName(string? name)
        {
            return
                name.IsNullOrWhiteSpace()
                    ? null
                    : EnumTypeCode switch
                    {
                        TypeCode.SByte => EnumInfo<TEnum, sbyte>.FromName(name),
                        TypeCode.Int16 => EnumInfo<TEnum, short>.FromName(name),
                        TypeCode.Int32 => EnumInfo<TEnum, int>.FromName(name),
                        TypeCode.Int64 => EnumInfo<TEnum, long>.FromName(name),
                        TypeCode.Byte => EnumInfo<TEnum, byte>.FromName(name),
                        TypeCode.UInt16 => EnumInfo<TEnum, ushort>.FromName(name),
                        TypeCode.UInt32 => EnumInfo<TEnum, uint>.FromName(name),
                        TypeCode.UInt64 => EnumInfo<TEnum, ulong>.FromName(name),
                        _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
                    };
        }

        public static EnumInfo<TEnum>? FromValue(TEnum? value)
        {
            return
                value.HasValue
                    ? EnumTypeCode switch
                    {
                        TypeCode.SByte => EnumInfo<TEnum, sbyte>.FromValue(value.Value),
                        TypeCode.Int16 => EnumInfo<TEnum, short>.FromValue(value.Value),
                        TypeCode.Int32 => EnumInfo<TEnum, int>.FromValue(value.Value),
                        TypeCode.Int64 => EnumInfo<TEnum, long>.FromValue(value.Value),
                        TypeCode.Byte => EnumInfo<TEnum, byte>.FromValue(value.Value),
                        TypeCode.UInt16 => EnumInfo<TEnum, ushort>.FromValue(value.Value),
                        TypeCode.UInt32 => EnumInfo<TEnum, uint>.FromValue(value.Value),
                        TypeCode.UInt64 => EnumInfo<TEnum, ulong>.FromValue(value.Value),
                        _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
                    }
                    : null;
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(sbyte underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => EnumInfo<TEnum, sbyte>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int16 => EnumInfo<TEnum, short>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int32 => EnumInfo<TEnum, int>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => throw ArgumentExceptions.ArgumentMustBeOfType<ushort>(underlyingValue),
                TypeCode.UInt32 => throw ArgumentExceptions.ArgumentMustBeOfType<uint>(underlyingValue),
                TypeCode.UInt64 => throw ArgumentExceptions.ArgumentMustBeOfType<ulong>(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(short underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => EnumInfo<TEnum, short>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int32 => EnumInfo<TEnum, int>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => throw ArgumentExceptions.ArgumentMustBeOfType<ushort>(underlyingValue),
                TypeCode.UInt32 => throw ArgumentExceptions.ArgumentMustBeOfType<uint>(underlyingValue),
                TypeCode.UInt64 => throw ArgumentExceptions.ArgumentMustBeOfType<ulong>(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(int underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => throw ArgumentExceptions.ArgumentMustBeOfType<short>(underlyingValue),
                TypeCode.Int32 => EnumInfo<TEnum, int>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => throw ArgumentExceptions.ArgumentMustBeOfType<ushort>(underlyingValue),
                TypeCode.UInt32 => throw ArgumentExceptions.ArgumentMustBeOfType<uint>(underlyingValue),
                TypeCode.UInt64 => throw ArgumentExceptions.ArgumentMustBeOfType<ulong>(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(long underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => throw ArgumentExceptions.ArgumentMustBeOfType<short>(underlyingValue),
                TypeCode.Int32 => throw ArgumentExceptions.ArgumentMustBeOfType<int>(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => throw ArgumentExceptions.ArgumentMustBeOfType<ushort>(underlyingValue),
                TypeCode.UInt32 => throw ArgumentExceptions.ArgumentMustBeOfType<uint>(underlyingValue),
                TypeCode.UInt64 => throw ArgumentExceptions.ArgumentMustBeOfType<ulong>(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(byte underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => EnumInfo<TEnum, short>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int32 => EnumInfo<TEnum, int>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => EnumInfo<TEnum, byte>.FromUnderlyingValue(underlyingValue),
                TypeCode.UInt16 => EnumInfo<TEnum, ushort>.FromUnderlyingValue(underlyingValue),
                TypeCode.UInt32 => EnumInfo<TEnum, uint>.FromUnderlyingValue(underlyingValue),
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.FromUnderlyingValue(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(ushort underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => throw ArgumentExceptions.ArgumentMustBeOfType<short>(underlyingValue),
                TypeCode.Int32 => EnumInfo<TEnum, int>.FromUnderlyingValue(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => EnumInfo<TEnum, ushort>.FromUnderlyingValue(underlyingValue),
                TypeCode.UInt32 => EnumInfo<TEnum, uint>.FromUnderlyingValue(underlyingValue),
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.FromUnderlyingValue(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(uint underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => throw ArgumentExceptions.ArgumentMustBeOfType<short>(underlyingValue),
                TypeCode.Int32 => throw ArgumentExceptions.ArgumentMustBeOfType<int>(underlyingValue),
                TypeCode.Int64 => EnumInfo<TEnum, long>.FromUnderlyingValue(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => throw ArgumentExceptions.ArgumentMustBeOfType<ushort>(underlyingValue),
                TypeCode.UInt32 => EnumInfo<TEnum, uint>.FromUnderlyingValue(underlyingValue),
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.FromUnderlyingValue(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum>? FromUnderlyingValue(ulong underlyingValue)
        {
            return EnumTypeCode switch
            {
                TypeCode.SByte => throw ArgumentExceptions.ArgumentMustBeOfType<sbyte>(underlyingValue),
                TypeCode.Int16 => throw ArgumentExceptions.ArgumentMustBeOfType<short>(underlyingValue),
                TypeCode.Int32 => throw ArgumentExceptions.ArgumentMustBeOfType<int>(underlyingValue),
                TypeCode.Int64 => throw ArgumentExceptions.ArgumentMustBeOfType<long>(underlyingValue),
                TypeCode.Byte => throw ArgumentExceptions.ArgumentMustBeOfType<byte>(underlyingValue),
                TypeCode.UInt16 => throw ArgumentExceptions.ArgumentMustBeOfType<ushort>(underlyingValue),
                TypeCode.UInt32 => throw ArgumentExceptions.ArgumentMustBeOfType<uint>(underlyingValue),
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.FromUnderlyingValue(underlyingValue),
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        static EnumInfo()
        {
            ConcreteTypeFactoryByUnderlyingType = InitializeConcreteTypeFactoryByUnderlyingType();

            EnumType = typeof(TEnum);
            EnumTypeInfo = EnumType.GetTypeInfo();
            EnumTypeCode = Type.GetTypeCode(EnumType);
            EnumUnderlyingType = Enum.GetUnderlyingType(EnumType);
            EnumInfoType = ConcreteTypeFactoryByUnderlyingType[EnumUnderlyingType].Invoke(EnumType);

            FieldsByEnumMemberName = InitializeFieldsByEnumMemberName();

            HasFlagsAttribute = EnumType.GetCustomAttribute<FlagsAttribute>() is not null;

            DefaultValue = default;
        }

        private protected EnumInfo(string name, TEnum value)
        {
            Name = name;
            Value = value;

            SerializedValue = name;
            Attributes = EnumerationAttributes.Empty;
        }

        public static IReadOnlyCollection<EnumInfo<TEnum>> DeclaredMembers
        {
            get => EnumTypeCode switch
            {
                TypeCode.SByte => EnumInfo<TEnum, sbyte>.DeclaredMembers,
                TypeCode.Int16 => EnumInfo<TEnum, short>.DeclaredMembers,
                TypeCode.Int32 => EnumInfo<TEnum, int>.DeclaredMembers,
                TypeCode.Int64 => EnumInfo<TEnum, long>.DeclaredMembers,
                TypeCode.Byte => EnumInfo<TEnum, byte>.DeclaredMembers,
                TypeCode.UInt16 => EnumInfo<TEnum, ushort>.DeclaredMembers,
                TypeCode.UInt32 => EnumInfo<TEnum, uint>.DeclaredMembers,
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.DeclaredMembers,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static IReadOnlyCollection<EnumInfo<TEnum>> DeclaredMembersExcludingSynonyms
        {
            get => EnumTypeCode switch
            {
                TypeCode.SByte => EnumInfo<TEnum, sbyte>.DeclaredMembersExcludingSynonyms,
                TypeCode.Int16 => EnumInfo<TEnum, short>.DeclaredMembersExcludingSynonyms,
                TypeCode.Int32 => EnumInfo<TEnum, int>.DeclaredMembersExcludingSynonyms,
                TypeCode.Int64 => EnumInfo<TEnum, long>.DeclaredMembersExcludingSynonyms,
                TypeCode.Byte => EnumInfo<TEnum, byte>.DeclaredMembersExcludingSynonyms,
                TypeCode.UInt16 => EnumInfo<TEnum, ushort>.DeclaredMembersExcludingSynonyms,
                TypeCode.UInt32 => EnumInfo<TEnum, uint>.DeclaredMembersExcludingSynonyms,
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.DeclaredMembersExcludingSynonyms,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static EnumInfo<TEnum> Default
        {
            get => EnumTypeCode switch
            {
                TypeCode.SByte => EnumInfo<TEnum, sbyte>.Default,
                TypeCode.Int16 => EnumInfo<TEnum, short>.Default,
                TypeCode.Int32 => EnumInfo<TEnum, int>.Default,
                TypeCode.Int64 => EnumInfo<TEnum, long>.Default,
                TypeCode.Byte => EnumInfo<TEnum, byte>.Default,
                TypeCode.UInt16 => EnumInfo<TEnum, ushort>.Default,
                TypeCode.UInt32 => EnumInfo<TEnum, uint>.Default,
                TypeCode.UInt64 => EnumInfo<TEnum, ulong>.Default,
                _ => throw NotSupportedExceptions.NotSupportedEnumTypeCode<TEnum>(EnumTypeCode)
            };
        }

        public static TEnum DefaultValue { get; private set; }

        public string Name { get; private set; }

        public TEnum Value { get; private set; }

        public ulong UInt64Value { get; protected set; }

        public string SerializedValue { get; protected set; }

        public bool IsDefaultValue { get; protected set; }

        public bool IsDefined { get; protected set; }

        public IEnumerationAttributes Attributes { get; protected set; }

        private protected abstract string DebuggerDisplayValue { get; }

        public bool HasFlag(EnumInfo<TEnum> flag)
        {
            flag.ThrowIfNull();

            return Value.HasFlag(flag.Value);
        }
    }
}
