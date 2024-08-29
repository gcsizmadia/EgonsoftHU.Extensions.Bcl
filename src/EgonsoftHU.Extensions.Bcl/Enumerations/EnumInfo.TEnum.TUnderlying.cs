// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using EgonsoftHU.Extensions.Bcl.Constants;
using EgonsoftHU.Extensions.Bcl.Enumerations.Internals;
using EgonsoftHU.Extensions.Bcl.Exceptions;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    internal abstract partial class EnumInfo<TEnum, TUnderlying> : EnumInfo<TEnum>
        where TEnum : struct, Enum
        where TUnderlying : struct, IComparable<TUnderlying>
    {
        private static readonly IEnumValueConverter<TEnum, TUnderlying> converter;

        private static readonly IEnumFlags<TUnderlying> flagCalculator;

        private static readonly Comparer<TUnderlying> comparer;

        private static readonly ReadOnlyCollection<TUnderlying> bits;

        private static readonly TUnderlying maxValue;

#if NETFRAMEWORK || NETSTANDARD2_0
        private static readonly char[] NameSeparators = new[] { Chars.Comma };
#endif

        private static readonly ReadOnlyDictionary<TUnderlying, List<EnumInfo<TEnum, TUnderlying>>> membersByUnderlyingValue;

        private static readonly ReadOnlyDictionary<TUnderlying, EnumInfo<TEnum, TUnderlying>> memberByUnderlyingValue;

        private ReadOnlyCollection<EnumInfo<TEnum, TUnderlying>> flags;

        public static new EnumInfo<TEnum, TUnderlying>? FromName(string name)
        {
            string[] names = GetNames(name);

            if (names.Length == 0)
            {
                return null;
            }

            ValidateNames(name, names);

            TUnderlying[] underlyingValues = GetUnderlyingValuesFromNames(names);

            return CreateInstance(underlyingValues);
        }

        public static EnumInfo<TEnum, TUnderlying>? FromValue(TEnum value)
        {
            return FromUnderlyingValue(converter.ToUnderlyingType(value));
        }

        public static EnumInfo<TEnum, TUnderlying>? FromUnderlyingValue(TUnderlying underlyingValue)
        {
            return
                comparer.Compare(underlyingValue, maxValue) > 0
                    ? null
                    : HasFlagsAttribute
                        ? CreateInstance(flagCalculator.Deconstruct(underlyingValue))
                        : CreateInstance(underlyingValue);
        }

        static EnumInfo()
        {
            converter = EnumValueConverter<TEnum, TUnderlying>.Instance;
            flagCalculator = EnumFlags<TUnderlying>.Instance;
            comparer = Comparer<TUnderlying>.Default;

            DeclaredMembers = InitializeMembers();
            membersByUnderlyingValue = InitializeMembersByUnderlyingValue();
            memberByUnderlyingValue = InitializeMemberByUnderlyingValue();

            Default = InitializeDefault();

            bits = InitializeBits();
            maxValue = InitializeMaxValue();
        }

        private protected EnumInfo(string name, TEnum value)
            : base(name, value)
        {
            UnderlyingValue = converter.ToUnderlyingType(value);
            UInt64Value = converter.ToUInt64(UnderlyingValue);

            flags = Array.Empty<EnumInfo<TEnum, TUnderlying>>().AsReadOnly();
        }

        public static new ReadOnlyCollection<EnumInfo<TEnum, TUnderlying>> DeclaredMembers { get; private set; }

        public static new ReadOnlyCollection<EnumInfo<TEnum, TUnderlying>> DeclaredMembersExcludingSynonyms =>
            memberByUnderlyingValue.Values.ToList().AsReadOnly();

        public static new EnumInfo<TEnum, TUnderlying> Default { get; private set; }

        public TUnderlying UnderlyingValue { get; private set; }

        public bool IsBit { get; private set; }

        public override string ToString()
        {
            return Name.DefaultIfNullOrWhiteSpace($"{UnderlyingValue}");
        }

        private protected override string DebuggerDisplayValue =>
            HasFlagsAttribute && flags.Count > 0
                ? $"{TypeHelper.GetTypeName(EnumType)}.({Name}) = [{UnderlyingValue}]"
                : $"{TypeHelper.GetTypeName(EnumType)}.{Name.DefaultIfNullOrWhiteSpace("__Unnamed__")} = [{UnderlyingValue}]";

        private static string[] GetNames(string name)
        {
            return
#if NET5_0_OR_GREATER
                name.Split(Chars.Comma, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
#else
#if NETFRAMEWORK || NETSTANDARD2_0
                name.Split(NameSeparators, StringSplitOptions.RemoveEmptyEntries)
#else
                name.Split(Chars.Comma, StringSplitOptions.RemoveEmptyEntries)
#endif
                    .Select(value => value.Trim())
                    .Where(value => String.Empty != value)
#endif
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToArray();
        }

        private static void ValidateNames(string name, string[] names)
        {
            string[] invalidNames =
                names
                    .Except(FieldsByEnumMemberName.Keys, StringComparer.OrdinalIgnoreCase)
                    .ToArray();

            if (invalidNames.Length > 0)
            {
                throw ArgumentExceptions.EnumMemberNotFound<TEnum>(name, invalidValues: invalidNames);
            }
        }

        private static TUnderlying[] GetUnderlyingValuesFromNames(string[] names)
        {
            return
                membersByUnderlyingValue
                    .SelectMany(kvp => kvp.Value)
                    .Join(
                        names,
                        member => member.Name,
                        name => name,
                        (member, name) => member.UnderlyingValue,
                        StringComparer.OrdinalIgnoreCase
                    )
                    .SelectMany(flagCalculator.Deconstruct)
                    .Distinct()
                    .ToArray();
        }

        private static EnumInfo<TEnum, TUnderlying> CreateInstance(params TUnderlying[] flags)
        {
            ReadOnlyCollection<EnumInfo<TEnum, TUnderlying>> selectedMembers =
                flags
                    .Where(flag => comparer.Compare(flag, default) != 0)
                    .Select(flag => memberByUnderlyingValue.TryGetValue(flag, out EnumInfo<TEnum, TUnderlying>? member) ? member : null)
                    .OfType<EnumInfo<TEnum, TUnderlying>>()
                    .ToList()
                    .AsReadOnly();

            switch (selectedMembers.Count)
            {
                case 0:
                    return Default;

                case 1:
                    return selectedMembers[0];

                default:
                {
                    if (!HasFlagsAttribute)
                    {
                        throw InvalidOperationExceptions.EnumTypeWithNoFlagsAttribute<TEnum>();
                    }

                    TUnderlying bitwiseOrValue = flagCalculator.Construct(flags);

                    if (memberByUnderlyingValue.TryGetValue(bitwiseOrValue, out EnumInfo<TEnum, TUnderlying>? member))
                    {
                        return member;
                    }

                    string name =
                        String.Join(
                            Strings.CommaSpaceSeparator,
                            selectedMembers.Select(selectedMember => selectedMember.Name)
                        );

                    TEnum value = converter.ToEnumType(bitwiseOrValue);

                    if (Activator.CreateInstance(EnumInfoType, name, value) is not EnumInfo<TEnum, TUnderlying> instance)
                    {
                        throw InvalidOperationExceptions.CreateEnumInfoInstanceFailed(EnumInfoType, value);
                    }

                    instance.flags = selectedMembers;

                    return instance;
                }
            }
        }
    }
}
