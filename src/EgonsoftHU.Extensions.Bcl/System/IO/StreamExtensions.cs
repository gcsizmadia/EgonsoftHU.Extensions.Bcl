// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;
using System.IO;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="Stream"/> type.
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// Converts a stream to byte array using <see cref="MemoryStream"/>.
        /// </summary>
        /// <param name="stream">The stream to convert.</param>
        /// <returns>A byte array that contains the content of the <paramref name="stream"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="stream"/> is <see langword="null"/>.</exception>
        /// <exception cref="NotSupportedException"><paramref name="stream"/> does not support seeking.</exception>
        public static byte[] ToByteArray(this Stream stream)
        {
            stream.ThrowIfNull();
            
            if (!stream.TryResetStreamPosition())
            {
                throw new NotSupportedException("The specified stream does not support seeking.");
            }

            using (var resultStream = new MemoryStream())
            {
                stream.CopyTo(resultStream);
                stream.TryResetStreamPosition();

                return resultStream.ToArray();
            }
        }

        /// <summary>
        /// Sets the position to the beginning within the current stream.
        /// A return value indicates whether seeking succeeded.
        /// </summary>
        /// <param name="stream">A stream the position of which should be reset.</param>
        /// <returns><see langword="true"/> if seeking was successful; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="stream"/> is <see langword="null"/>.</exception>
        public static bool TryResetStreamPosition(this Stream stream)
        {
            stream.ThrowIfNull();

            return
                stream.CanSeek
                &&
                stream.Seek(0, SeekOrigin.Begin) == 0;
        }
    }
}
