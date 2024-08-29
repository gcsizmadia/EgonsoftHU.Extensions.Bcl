// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

#if !NET7_0_OR_GREATER
/*
The MIT License (MIT)

Copyright (c) .NET Foundation and Contributors

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies the syntax used in a string.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    [ExcludeFromCodeCoverage]
    public sealed class StringSyntaxAttribute : Attribute
    {
        /// <summary>
        /// The syntax identifier for strings containing composite formats for string formatting.
        /// </summary>
        public const string CompositeFormat = "CompositeFormat";

        /// <summary>
        /// The syntax identifier for strings containing date format specifiers.
        /// </summary>
        public const string DateOnlyFormat = "DateOnlyFormat";

        /// <summary>
        /// The syntax identifier for strings containing date and time format specifiers.
        /// </summary>
        public const string DateTimeFormat = "DateTimeFormat";

        /// <summary>
        /// The syntax identifier for strings containing <see cref="Enum"/> format specifiers.
        /// </summary>
        public const string EnumFormat = "EnumFormat";

        /// <summary>
        /// The syntax identifier for strings containing <see cref="Guid"/> format specifiers.
        /// </summary>
        public const string GuidFormat = "GuidFormat";

        /// <summary>
        /// The syntax identifier for strings containing JavaScript Object Notation (JSON).
        /// </summary>
        public const string Json = "Json";

        /// <summary>
        /// The syntax identifier for strings containing numeric format specifiers.
        /// </summary>
        public const string NumericFormat = "NumericFormat";

        /// <summary>
        /// The syntax identifier for strings containing regular expressions.
        /// </summary>
        public const string Regex = "Regex";

        /// <summary>
        /// The syntax identifier for strings containing time format specifiers.
        /// </summary>
        public const string TimeOnlyFormat = "TimeOnlyFormat";

        /// <summary>
        /// The syntax identifier for strings containing <see cref="TimeSpan"/> format specifiers.
        /// </summary>
        public const string TimeSpanFormat = "TimeSpanFormat";

        /// <summary>
        /// The syntax identifier for strings containing URIs.
        /// </summary>
        public const string Uri = "Uri";

        /// <summary>
        /// The syntax identifier for strings containing XML.
        /// </summary>
        public const string Xml = "Xml";

        /// <summary>
        /// Initializes the <see cref="StringSyntaxAttribute"/> with the identifier of the syntax used.
        /// </summary>
        /// <param name="syntax">The syntax identifier.</param>
        public StringSyntaxAttribute(string syntax)
        {
            Syntax = syntax;
            Arguments = Array.Empty<object>();
        }

        /// <summary>
        /// Initializes the <see cref="StringSyntaxAttribute"/> with the identifier of the syntax used.
        /// </summary>
        /// <param name="syntax">The syntax identifier.</param>
        /// <param name="arguments">Optional arguments associated with the specific syntax employed.</param>
        public StringSyntaxAttribute(string syntax, params object?[] arguments)
        {
            Syntax = syntax;
            Arguments = arguments;
        }

        /// <summary>
        /// Gets the identifier of the syntax used.
        /// </summary>
        public string Syntax { get; }

        /// <summary>
        /// Gets the optional arguments associated with the specific syntax employed.
        /// </summary>
        public object?[] Arguments { get; }
    }
}
#endif
