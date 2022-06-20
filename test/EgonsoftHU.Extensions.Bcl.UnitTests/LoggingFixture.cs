// Copyright © 2022 Gabor Csizmadia
// This code is licensed under MIT license (see LICENSE for details)

using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

using Xunit.Abstractions;

namespace EgonsoftHU.Extensions.Bcl.UnitTests
{
    public class LoggingFixture<T> : IDisposable
    {
        private const string OutputTemplate =
            "{Timestamp:yyyy-MM-dd HH:mm:ss.fffffff zzz} [{Level:u3}] {Message:lj} ==> {Properties}{NewLine}{Exception}";

        private static readonly CompactJsonFormatter formatter = new CompactJsonFormatter();

        public ILogger? Logger { get; private set; }

        [MemberNotNull(nameof(Logger))]
        public void InitializeLogger(ITestOutputHelper output)
        {
            Logger = CreateLogger(output);
        }

        [MemberNotNull(nameof(Logger))]
        public void InitializeLogger(IMessageSink output)
        {
            Logger = CreateLogger(output);
        }

        private static ILogger CreateLogger(object output)
        {
            var loggerConfiguration = new LoggerConfiguration();

            loggerConfiguration
                .MinimumLevel.Verbose()
                .WriteTo.File(
                    formatter: formatter,
                    path: Path.Combine(AppContext.BaseDirectory, "xunit-output.log"),
                    restrictedToMinimumLevel: LogEventLevel.Verbose,
                    shared: true,
                    encoding: Encoding.UTF8
                );

            switch (output)
            {
                case ITestOutputHelper testOutputHelper:
                    loggerConfiguration.WriteTo.TestOutput(testOutputHelper, LogEventLevel.Verbose, OutputTemplate);
                    break;

                case IMessageSink messageSink:
                    loggerConfiguration.WriteTo.TestOutput(messageSink, LogEventLevel.Verbose, OutputTemplate);
                    break;

                default:
                    break;
            }

            return loggerConfiguration.CreateLogger().ForContext<T>();
        }

        #region Dispose pattern implementation

        private bool isDisposed;

        protected virtual void Dispose(bool isDisposing)
        {
            if (!isDisposed)
            {
                if (isDisposing)
                {
                    if (Logger is IDisposable disposableLogger)
                    {
                        disposableLogger.Dispose();
                    }

                    Logger = null;
                }

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
