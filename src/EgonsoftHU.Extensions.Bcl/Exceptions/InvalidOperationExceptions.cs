// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Runtime.CompilerServices;

namespace EgonsoftHU.Extensions.Bcl.Exceptions
{
    internal static class InvalidOperationExceptions
    {
        internal static class MessageTemplates
        {
            internal const string CreateEnumFlagsInstanceFailed =
                "Create an instance of a type that implements IEnumFlags<TUnderlying> interface failed.";

            internal const string CreateEnumInfoInstanceFailed =
                "Create an instance of the EnumInfo<TEnum> type failed.";

            internal const string CreateEnumValueConverterFailed =
                "Create an instance of a type that implements IEnumValueConverter<TEnum, TUnderlying> interface failed.";

            internal const string EnumTypeWithNoFlagsAttribute =
                "No System.FlagsAttribute is applied to the current enumeration type.";

            internal const string NoFlagsResolverForType =
                "Could not find an IEnumFlags<TUnderlyingType> implementation for the specified underlying type.";

            internal const string PropertyValueNotSet =
                "The property value is not set.";
        }

        internal static InvalidOperationException CreateEnumFlagsInstanceFailed<TUnderlying>(Type concreteType)
            where TUnderlying : struct
        {
            var ex = new InvalidOperationException(MessageTemplates.CreateEnumFlagsInstanceFailed);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName(concreteType);
            ex.Data[DataKeys.EnumUnderlyingType] = TypeHelper.GetTypeName<TUnderlying>();

            return ex;
        }

        internal static InvalidOperationException CreateEnumInfoInstanceFailed<TEnum>(Type concreteType, TEnum value)
            where TEnum : struct, Enum
        {
            var ex = new InvalidOperationException(MessageTemplates.CreateEnumInfoInstanceFailed);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName(concreteType);
            ex.Data[DataKeys.EnumType] = TypeHelper.GetTypeName<TEnum>();
            ex.Data[DataKeys.OriginalValue] = value;

            return ex;
        }

        internal static InvalidOperationException CreateEnumInfoInstanceFailed<TEnum, TUnderlying>(Type concreteType, TUnderlying value)
            where TEnum : struct, Enum
            where TUnderlying : struct
        {
            var ex = new InvalidOperationException(MessageTemplates.CreateEnumInfoInstanceFailed);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName(concreteType);
            ex.Data[DataKeys.EnumType] = TypeHelper.GetTypeName<TEnum>();
            ex.Data[DataKeys.EnumUnderlyingType] = TypeHelper.GetTypeName<TUnderlying>();
            ex.Data[DataKeys.OriginalValue] = value;

            return ex;
        }

        internal static InvalidOperationException CreateEnumValueConverterInstanceFailed<TEnum, TUnderlying>(Type concreteType)
            where TEnum : struct, Enum
            where TUnderlying : struct
        {
            var ex = new InvalidOperationException(MessageTemplates.CreateEnumFlagsInstanceFailed);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName(concreteType);
            ex.Data[DataKeys.EnumType] = TypeHelper.GetTypeName<TEnum>();
            ex.Data[DataKeys.EnumUnderlyingType] = TypeHelper.GetTypeName<TUnderlying>();

            return ex;
        }

        internal static InvalidOperationException EnumTypeWithNoFlagsAttribute<TEnum>()
            where TEnum : struct, Enum
        {
            var ex = new InvalidOperationException(MessageTemplates.EnumTypeWithNoFlagsAttribute);

            ex.Data[DataKeys.EnumType] = TypeHelper.GetTypeName<TEnum>();

            return ex;
        }

        internal static InvalidOperationException PropertyValueNotSet<TProperty>([CallerMemberName] string? propertyName = null)
        {
            var ex = new InvalidOperationException(MessageTemplates.PropertyValueNotSet);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName<TProperty>();
            ex.Data[DataKeys.PropertyName] = propertyName;

            return ex;
        }
    }
}
