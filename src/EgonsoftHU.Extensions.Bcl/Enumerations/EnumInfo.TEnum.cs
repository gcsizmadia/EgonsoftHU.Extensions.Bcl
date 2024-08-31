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
    /// <summary>
    /// A base class to represent an enumeration value and also to provide access to additional information
    /// about both the current enumeration value and the <typeparamref name="TEnum"/> type itself.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enumeration.</typeparam>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// that have the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of one or more constants in the <typeparamref name="TEnum"/> type.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="name"/> is <see langword="null"/>, <see cref="String.Empty"/> or consists only of white-space characters;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// If no constant found in the <typeparamref name="TEnum"/> type that has a name specified by the <paramref name="name"/> parameter.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="name"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the value of which equals to the specified <paramref name="value"/>.
        /// </summary>
        /// <param name="value">An enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="value"/> is <see langword="null"/> or is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="value"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that
        /// represents one or more constants in the <typeparamref name="TEnum"/> type
        /// the underlying value of which equals to the specified <paramref name="underlyingValue"/>.
        /// </summary>
        /// <param name="underlyingValue">The underlying value of an enumeration value.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><see langword="null"/> if the <paramref name="underlyingValue"/> is greater than the greatest valid value;</item>
        /// <item>Otherwise, an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the constant(s) in the <typeparamref name="TEnum"/> type.</item>
        /// </list>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The underlying type of the <typeparamref name="TEnum"/> type must be one of the following types:
        /// <see cref="SByte"/>, <see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/>,
        /// <see cref="Byte"/>, <see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/>
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// If the <paramref name="underlyingValue"/> represents more than one constants in the <typeparamref name="TEnum"/> and
        /// a <see cref="FlagsAttribute"/> is not applied to that type
        /// </exception>
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

            Attributes = EnumerationAttributes.Empty;
            SerializedValue = name;
        }

        /// <summary>
        /// Gets a collection of the fields defined by the <typeparamref name="TEnum"/> type,
        /// each represented by an instance of the <see cref="EnumInfo{TEnum}"/> type.
        /// </summary>
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

        /// <summary>
        /// Gets a collection of the fields defined by the <typeparamref name="TEnum"/> type,
        /// each represented by an instance of the <see cref="EnumInfo{TEnum}"/> type.
        /// </summary>
        /// <remarks>
        /// If multiple constants of type <typeparamref name="TEnum"/> have the same value,
        /// only one of them (the first in the order of declaration) is included in the collection.
        /// </remarks>
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

        /// <summary>
        /// Gets an instance of the <see cref="EnumInfo{TEnum}"/> type that represents the value of <see cref="DefaultValue"/> property.
        /// </summary>
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

        /// <summary>
        /// Gets the value produced by the expression <c>(TEnum)0</c>, where <typeparamref name="TEnum"/> is the enum identifier.
        /// </summary>
        public static TEnum DefaultValue { get; private set; }

        /// <summary>
        /// Gets the name of the constant in the <typeparamref name="TEnum"/> type for the current enumeration value.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the value of the constant in the <typeparamref name="TEnum"/> type for the current enumeration value.
        /// </summary>
        public TEnum Value { get; private set; }

        /// <summary>
        /// Gets the value of the underlying type constant in the <typeparamref name="TEnum"/> type converted to <see cref="UInt64"/>.
        /// </summary>
        public ulong UInt64Value { get; protected set; }

        /// <summary>
        /// Gets a string representation of the current enumeration value.
        /// </summary>
        public string SerializedValue { get; protected set; }

        /// <summary>
        /// Indicates whether the current enumeration value is the default value of the <typeparamref name="TEnum"/> type.
        /// </summary>
        public bool IsDefaultValue { get; protected set; }

        /// <summary>
        /// Indicates whether the current enumeration value is defined in the <typeparamref name="TEnum"/> type.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if a constant in the <typeparamref name="TEnum"/> type has a value equal to <see cref="Value"/>;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public bool IsDefined { get; protected set; }

        /// <summary>
        /// Gets all custom attributes applied to the current member of the <typeparamref name="TEnum"/> type.
        /// </summary>
        public IEnumerationAttributes Attributes { get; protected set; }

        private protected abstract string DebuggerDisplayValue { get; }

        /// <summary>
        /// Determines whether one or more bit fields are set in the current instance.
        /// </summary>
        /// <param name="flag">An enumeration value represented by an instance of the <see cref="EnumInfo{TEnum}"/> type.</param>
        /// <returns>
        /// <see langword="true"/> if the bit field or bit fields that are set in flag are also set in the current instance;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public bool HasFlag(EnumInfo<TEnum> flag)
        {
            flag.ThrowIfNull();

            return Value.HasFlag(flag.Value);
        }
    }
}
