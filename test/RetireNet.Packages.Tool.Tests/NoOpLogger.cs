using System;
using Microsoft.Extensions.Logging;
using RetireNet.Packages.Tool.Services;

namespace DotNetRetire.Tests
{
    public class NoOpLogger : ILogger<FileService>
    {
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {

        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }
    }
}