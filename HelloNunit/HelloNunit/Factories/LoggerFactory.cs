// HelloNunit.HelloNunit.LoggerFactory.cs

using HelloNunit.FrameworkWrappers;

namespace HelloNunit.Factories
{
    public class LoggerFactory : ILoggerFactory
    {
        public T Create<T>() where T : LoggerBase, new()
        {
            return new T();
        }

        public ILogger Create(IConsoleWriter consoleWriter)
        {
            return new ConsoleLogger(consoleWriter);
        }
    }
}