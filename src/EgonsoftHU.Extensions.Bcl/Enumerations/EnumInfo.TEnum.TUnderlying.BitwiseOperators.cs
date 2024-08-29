// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.Linq;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    internal partial class EnumInfo<TEnum, TUnderlying>
    {
        public static EnumInfo<TEnum, TUnderlying> operator ~(EnumInfo<TEnum, TUnderlying> value)
        {
            TUnderlying[] currentBits = flagCalculator.Deconstruct(value.UnderlyingValue);
            TUnderlying[] resultBits = bits.Except(currentBits).ToArray();

            return CreateInstance(resultBits);
        }

        public static EnumInfo<TEnum, TUnderlying> operator |(EnumInfo<TEnum, TUnderlying> left, EnumInfo<TEnum, TUnderlying> right)
        {
            TUnderlying bitwiseOrValue = flagCalculator.Construct(left.UnderlyingValue, right.UnderlyingValue);
            TUnderlying[] resultBits = flagCalculator.Deconstruct(bitwiseOrValue);

            return CreateInstance(resultBits);
        }

        public static EnumInfo<TEnum, TUnderlying> operator &(EnumInfo<TEnum, TUnderlying> left, EnumInfo<TEnum, TUnderlying> right)
        {
            TUnderlying[] leftBits = flagCalculator.Deconstruct(left.UnderlyingValue);
            TUnderlying[] rightBits = flagCalculator.Deconstruct(right.UnderlyingValue);

            TUnderlying[] resultBits = leftBits.Intersect(rightBits).ToArray();

            return CreateInstance(resultBits);
        }

        public static EnumInfo<TEnum, TUnderlying> operator ^(EnumInfo<TEnum, TUnderlying> left, EnumInfo<TEnum, TUnderlying> right)
        {
            TUnderlying[] leftBits = flagCalculator.Deconstruct(left.UnderlyingValue);
            TUnderlying[] rightBits = flagCalculator.Deconstruct(right.UnderlyingValue);

            TUnderlying[] union = leftBits.Union(rightBits).ToArray();
            TUnderlying[] intersect = leftBits.Intersect(rightBits).ToArray();

            TUnderlying[] resultBits = union.Except(intersect).ToArray();

            return CreateInstance(resultBits);
        }
    }
}
