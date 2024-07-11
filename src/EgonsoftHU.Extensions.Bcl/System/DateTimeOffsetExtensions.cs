// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="DateTimeOffset"/> type.
    /// </summary>
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Removes the fractional seconds from the <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="DateTimeOffset"/> value from which to remove the fractional seconds.</param>
        /// <returns>A <see cref="DateTimeOffset"/> value with no fractional seconds.</returns>
        public static DateTimeOffset ToSecondPrecision(this DateTimeOffset value)
        {
            TimeSpan timeOfDay = value.TimeOfDay;

            return value.Subtract(timeOfDay).AddSeconds((int)timeOfDay.TotalSeconds);
        }

        /// <summary>
        /// Removes the seconds from the <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="DateTimeOffset"/> value from which to remove the seconds.</param>
        /// <returns>A <see cref="DateTimeOffset"/> value with zero seconds.</returns>
        public static DateTimeOffset ToMinutePrecision(this DateTimeOffset value)
        {
            TimeSpan timeOfDay = value.TimeOfDay;

            return value.Subtract(timeOfDay).AddMinutes((int)timeOfDay.TotalMinutes);
        }
    }
}
