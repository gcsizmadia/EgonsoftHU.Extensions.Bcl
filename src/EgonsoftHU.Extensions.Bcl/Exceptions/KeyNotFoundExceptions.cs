// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.Collections.Generic;

namespace EgonsoftHU.Extensions.Bcl.Exceptions
{
    internal static class KeyNotFoundExceptions
    {
        internal static KeyNotFoundException KeyNotFound<TKey>(TKey key)
            where TKey : notnull
        {
            var ex = new KeyNotFoundException();

            ex.Data[DataKeys.Key] = key;
            ex.Data[DataKeys.KeyType] = TypeHelper.GetTypeName<TKey>();

            return ex;
        }
    }
}
