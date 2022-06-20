// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using System;

using FluentAssertions;

using Xunit;
using Xunit.Abstractions;

namespace EgonsoftHU.Extensions.Bcl.UnitTests
{
    public class ThrowExtensionsTests : UnitTest<ThrowExtensionsTests>
    {
        public ThrowExtensionsTests(ITestOutputHelper output, LoggingFixture<ThrowExtensionsTests> fixture)
            : base(output, fixture)
        {
        }

        [Fact]
        public void ThrowIfNull_NonNullableValueType_NonNullValue()
        {
            // Arrange
            int value = 42;

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().NotThrow<ArgumentNullException>();
        }

        [Fact]
        public void ThrowIfNull_NullableValueType_NullValue()
        {
            // Arrange
            int? value = null;

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(value));
        }

        [Fact]
        public void ThrowIfNull_NullableValueType_NonNullValue()
        {
            // Arrange
            int? value = 42;

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().NotThrow<ArgumentNullException>();
        }

        [Fact]
        public void ThrowIfNull_NullableReferenceType_NullValue()
        {
            // Arrange
            object? value = null;

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(value));
        }

        [Fact]
        public void ThrowIfNull_NullableReferenceType_NonNullValue()
        {
            // Arrange
            object? value = new();

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().NotThrow<ArgumentNullException>();
        }

        [Fact]
        public void ThrowIfNull_NonNullableReferenceType_NullValue()
        {
            // Arrange
            object value = null!;

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(value));
        }

        [Fact]
        public void ThrowIfNull_NonNullableReferenceType_NonNullValue()
        {
            // Arrange
            object value = new();

            // Act
            Action sut = () => value.ThrowIfNull();

            // Assert
            sut.Should().NotThrow<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ThrowIfNullOrEmpty_StringNullEmpty(string? value)
        {
            // Arrange

            // Act
            Action sut = () => value.ThrowIfNullOrEmpty();

            // Assert
            sut.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(value));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\t")]
        public void ThrowIfNullOrEmpty_StringNullEmptyWhiteSpace(string? value)
        {
            // Arrange

            // Act
            Action sut = () => value.ThrowIfNullOrWhiteSpace();

            // Assert
            sut.Should().ThrowExactly<ArgumentNullException>().WithParameterName(nameof(value));
        }

        [Theory]
        [InlineData("\t")]
        [InlineData(" ")]
        [InlineData("A")]
        [InlineData("1")]
        public void ThrowIfNullOrEmpty_StringNonNullNonEmpty(string? value)
        {
            // Arrange

            // Act
            Action sut = () => value.ThrowIfNullOrEmpty();

            // Assert
            sut.Should().NotThrow<ArgumentNullException>();
        }

        [Theory]
        [InlineData("A")]
        [InlineData("1")]
        public void ThrowIfNullOrEmpty_StringNonNullNonEmptyNonWhiteSpace(string? value)
        {
            // Arrange

            // Act
            Action sut = () => value.ThrowIfNullOrWhiteSpace();

            // Assert
            sut.Should().NotThrow<ArgumentNullException>();
        }
    }
}
