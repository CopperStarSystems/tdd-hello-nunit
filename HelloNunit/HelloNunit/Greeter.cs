// HelloNunit.HelloNunit.Greeter.cs

using HelloNunit.FrameworkWrappers;

namespace HelloNunit
{
    public class Greeter : IGreeter
    {
        readonly IConsoleWriter consoleWriter;
        readonly ILogger logger;

        public Greeter(IConsoleWriter consoleWriter, ILogger logger)
        {
            this.consoleWriter = consoleWriter;
            this.logger = logger;
        }

        public void Greet(string userName)
        {
            consoleWriter.WriteLine("Hello, {0}", userName);
            logger.Log($"Greeted {userName}");
        }
    }
}