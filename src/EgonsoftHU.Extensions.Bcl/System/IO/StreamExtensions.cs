// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System.IO;

namespace EgonsoftHU.Extensions.Bcl
{
    /// <summary>
    /// This class contains extension methods that are available for <see cref="Stream"/> type.
    /// </summary>
    public static class StreamExtensions
    {
        private static byte[] Empty { get; } = new byte[0];

        /// <summary>
        /// Converts a stream to byte array using <see cref="MemoryStream"/>.
        /// </summary>
        /// <param name="stream">The stream to convert.</param>
        /// <returns>a byte array that contains the content of the stream.</returns>
        public static byte[] ToByteArray(this Stream stream)
        {
            if (stream is null)
            {
                return Empty;
            }

            byte[] result = Empty;

            using (var resultStream = new MemoryStream())
            {
                ResetStreamPosition(stream);

                stream.CopyTo(resultStream);
                result = resultStream.ToArray();

                ResetStreamPosition(stream);
            }

            return result;
        }

        private static void ResetStreamPosition(Stream stream)
        {
            if (stream.CanSeek)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }
        }
    }
}
