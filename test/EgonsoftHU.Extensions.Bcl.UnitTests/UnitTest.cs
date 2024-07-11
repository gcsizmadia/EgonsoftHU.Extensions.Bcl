// Copyright © 2022-2024 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using Serilog;

using Xunit;
using Xunit.Abstractions;

namespace EgonsoftHU.Extensions.Bcl.UnitTests
{
    public abstract class UnitTest<T> : IClassFixture<LoggingFixture<T>>
    {
        protected UnitTest(ITestOutputHelper output, LoggingFixture<T> fixture)
        {
            fixture.InitializeLogger(output);
            Logger = fixture.Logger;
        }

        protected ILogger Logger { get; }
    }
}
