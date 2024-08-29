// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.Text;

namespace EgonsoftHU.Extensions.Bcl.Text
{
    /// <summary>
    /// An encoding provider, which supplies UTF-8 encoding without the Unicode byte order mark.
    /// </summary>
    public static class EncodingProvider
    {
        /// <summary>
        /// The UTF-8 encoding without the Unicode byte order mark.
        /// </summary>
        /// <remarks>
        /// <see cref="UTF8Encoding.GetPreamble"/> will return an empty byte array.
        /// </remarks>
        public static Encoding UTF8WithoutBOM { get; } = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
    }
}
