// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

namespace EgonsoftHU.Extensions.Bcl.Constants
{
    /// <summary>
    /// Contains single format specifiers that indicate how to format the value of a <see cref="Guid"/>.
    /// </summary>
    /// <remarks>
    /// This type is obsolete and will be removed in a future version. The recommended alternative is <see cref="GuidFormats"/>.
    /// </remarks>
    [Obsolete("This type is obsolete and will be removed in a future version. The recommended alternative is EgonsoftHU.Extensions.Bcl.Constants.GuidFormats.")]
    public static class GuidFormat
    {
        /// <summary>
        /// <see cref="Guid" /> in number format, e.g. <c>728022948a434ba9a3603498df3cb0c7</c>
        /// </summary>
        /// <remarks>
        /// This member is obsolete and will be removed in a future version. The recommended alternative is <see cref="GuidFormats.Number"/>.
        /// </remarks>
        [Obsolete("This member is obsolete and will be removed in a future version. The recommended alternative is EgonsoftHU.Extensions.Bcl.Constants.GuidFormats.Number.")]
        public const string Number = "N";

        /// <summary>
        /// <see cref="Guid" /> in digit format, e.g. <c>72802294-8a43-4ba9-a360-3498df3cb0c7</c>
        /// </summary>
        /// <remarks>
        /// This member is obsolete and will be removed in a future version. The recommended alternative is <see cref="GuidFormats.Digit"/>.
        /// </remarks>
        [Obsolete("This member is obsolete and will be removed in a future version. The recommended alternative is EgonsoftHU.Extensions.Bcl.Constants.GuidFormats.Digit.")]
        public const string Digit = "D";

        /// <summary>
        /// <see cref="Guid" /> in brace format, e.g. <c>{72802294-8a43-4ba9-a360-3498df3cb0c7}</c>
        /// </summary>
        /// <remarks>
        /// This member is obsolete and will be removed in a future version. The recommended alternative is <see cref="GuidFormats.Brace"/>.
        /// </remarks>
        [Obsolete("This member is obsolete and will be removed in a future version. The recommended alternative is EgonsoftHU.Extensions.Bcl.Constants.GuidFormats.Brace.")]
        public const string Brace = "B";

        /// <summary>
        /// <see cref="Guid" /> in parenthesis format, e.g. <c>(72802294-8a43-4ba9-a360-3498df3cb0c7)</c>
        /// </summary>
        /// <remarks>
        /// This member is obsolete and will be removed in a future version. The recommended alternative is <see cref="GuidFormats.Parenthesis"/>.
        /// </remarks>
        [Obsolete("This member is obsolete and will be removed in a future version. The recommended alternative is EgonsoftHU.Extensions.Bcl.Constants.GuidFormats.Parenthesis.")]
        public const string Parenthesis = "P";

        /// <summary>
        /// <see cref="Guid" /> in hexadecimal format, e.g. <c>{0x72802294,0x8a43,0x4ba9,{0xa3,0x60,0x34,0x98,0xdf,0x3c,0xb0,0xc7}}</c>
        /// </summary>
        /// <remarks>
        /// This member is obsolete and will be removed in a future version. The recommended alternative is <see cref="GuidFormats.Hex"/>.
        /// </remarks>
        [Obsolete("This member is obsolete and will be removed in a future version. The recommended alternative is EgonsoftHU.Extensions.Bcl.Constants.GuidFormats.Hex.")]
        public const string Hex = "X";
    }
}
