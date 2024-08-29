// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Exceptions
{
    internal static class NotSupportedExceptions
    {
        internal static class MessageTemplates
        {
            internal const string NotSupportedEnumTypeCode = "Not supported enumeration type code.";

            internal const string NotSupportedEnumUnderlyingType = "Not supported enumeration underlying type.";

            internal const string SeekNotSupported = "The specified stream does not support seeking.";
        }

        internal static NotSupportedException NotSupportedEnumTypeCode<TEnum>(TypeCode typeCode)
            where TEnum : struct, Enum
        {
            var ex = new NotSupportedException(MessageTemplates.NotSupportedEnumTypeCode);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName<TEnum>();
            ex.Data[DataKeys.TypeCode] = typeCode;

            return ex;
        }

        internal static NotSupportedException NotSupportedEnumUnderlyingType<TUnderlying>()
            where TUnderlying : struct
        {
            var ex = new NotSupportedException(MessageTemplates.NotSupportedEnumUnderlyingType);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName<TUnderlying>();

            return ex;
        }

        internal static NotSupportedException SeekNotSupported(Type streamType)
        {
            var ex = new NotSupportedException(MessageTemplates.SeekNotSupported);

            ex.Data[DataKeys.Type] = TypeHelper.GetTypeName(streamType);

            return ex;
        }
    }
}
