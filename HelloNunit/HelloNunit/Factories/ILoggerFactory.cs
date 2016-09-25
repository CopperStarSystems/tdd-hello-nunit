// HelloNunit.HelloNunit.ILoggerFactory.cs

using HelloNunit.FrameworkWrappers;

namespace HelloNunit.Factories
{
    public interface ILoggerFactory
    {
        T Create<T>() where T : LoggerBase, new();

        ILogger Create(IConsoleWriter consoleWriter);
    }
}