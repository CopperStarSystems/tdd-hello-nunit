// HelloNunit.HelloNunit.ConsoleLogger.cs

using HelloNunit.FrameworkWrappers;

namespace HelloNunit
{
    public class ConsoleLogger : LoggerBase
    {
        readonly IConsoleWriter consoleWriter;

        public ConsoleLogger(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
        }

        protected override void LogInternal(string message)
        {
            consoleWriter.WriteLine(message);
        }
    }
}