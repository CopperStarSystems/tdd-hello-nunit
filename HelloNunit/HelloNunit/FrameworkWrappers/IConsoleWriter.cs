// HelloNunit.HelloNunit.IConsoleWriter.cs

namespace HelloNunit.FrameworkWrappers
{
    public interface IConsoleWriter
    {
        void WriteLine(string message, params object[] args);
    }
}