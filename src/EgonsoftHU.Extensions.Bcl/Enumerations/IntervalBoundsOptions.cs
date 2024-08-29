﻿// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Enumerations
{
    /// <summary>
    /// Provides options how to treat the lower bound and the upper bound in an interval.
    /// <para>
    /// An interval can be:
    /// <list type="bullet">
    /// <item><see cref="Closed"/>: inclusive lower bound and inclusive upper bound</item>
    /// <item><see cref="Open"/>: exclusive lower bound and exclusive upper bound</item>
    /// <item><see cref="LeftOpen"/>: exclusive lower bound and inclusive upper bound</item>
    /// <item><see cref="RightOpen"/>: inclusive lower bound and exclusive upper bound</item>
    /// </list>
    /// </para>
    /// </summary>
    [Flags]
    public enum IntervalBoundsOptions
    {
        /// <summary>
        /// Both the lower bound and the upper bound are included in the interval.
        /// </summary>
        Closed = 0,

        /// <summary>
        /// The lower bound is excluded from the interval, but the upper bound is included in the interval.
        /// </summary>
        LeftOpen = 1,

        /// <summary>
        /// The lower bound is included in the interval, but the upper bound is excluded from the interval.
        /// </summary>
        RightOpen = 2,

        /// <summary>
        /// Neither the lower bound nor the upper bound is included in the interval.
        /// </summary>
        Open = LeftOpen | RightOpen
    }
}
