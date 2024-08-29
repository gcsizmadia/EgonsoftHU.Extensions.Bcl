// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.Runtime.CompilerServices;

namespace EgonsoftHU.Extensions.Bcl.Exceptions
{
    internal static class ArgumentExceptions
    {
        internal static class MessageTemplates
        {
            internal const string ArgumentMustBeOfType = "Object must be of type: '{0}'";

            internal const string CollectionIsReadOnly = "The collection is read-only.";

            internal const string EnumMemberNotFound = "Enum member not found.";

            internal const string PropertyNotFound = "No property with the specified name is declared in the current type.";
        }

        internal static ArgumentException ArgumentMustBeOfType<TRequired>(
            object? paramValue,
            [CallerArgumentExpression(nameof(paramValue))] string? paramName = null
        )
        {
            return ArgumentMustBeOfType(typeof(TRequired), paramValue, paramName);
        }

        internal static ArgumentException ArgumentMustBeOfType(
            Type requiredType,
            object? paramValue,
            [CallerArgumentExpression(nameof(paramValue))] string? paramName = null
        )
        {
            var ex =
                new ArgumentException(
                    String.Format(
                        MessageTemplates.ArgumentMustBeOfType,
                        TypeHelper.GetTypeName(requiredType)
                    ),
                    paramName
                );

            ex.Data[DataKeys.RequiredType] = TypeHelper.GetTypeName(requiredType);

            ex.Data[DataKeys.ActualType] =
                paramValue is null
                    ? Type.Missing.ToString()
                    : TypeHelper.GetTypeName(paramValue.GetType());

            return ex;
        }

        internal static ArgumentException CollectionIsReadOnly(string paramName)
        {
            var ex = new ArgumentException(MessageTemplates.CollectionIsReadOnly, paramName);

            return ex;
        }

        internal static ArgumentException EnumMemberNotFound<TEnum>(
            object? paramValue,
            [CallerArgumentExpression(nameof(paramValue))] string? paramName = null,
            params object[]? invalidValues
        )
            where TEnum : struct, Enum
        {
            var ex = new ArgumentException(MessageTemplates.EnumMemberNotFound, paramName);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName<TEnum>();
            ex.Data[DataKeys.OriginalValue] = paramValue;
            ex.Data[DataKeys.InvalidValues] = invalidValues;

            return ex;
        }

        internal static ArgumentException PropertyNotFound(Type sourceType, string propertyName)
        {
            var ex = new ArgumentException(MessageTemplates.PropertyNotFound, nameof(propertyName));

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName(sourceType);
            ex.Data[DataKeys.PropertyName] = propertyName;

            return ex;
        }
    }
}
