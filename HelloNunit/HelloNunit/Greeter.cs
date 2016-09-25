// HelloNunit.HelloNunit.Greeter.cs

using HelloNunit.Factories;
using HelloNunit.FrameworkWrappers;

namespace HelloNunit
{
    public class Greeter : IGreeter
    {
        readonly IConsoleWriter consoleWriter;
        readonly ILogger logger;

        public Greeter(IConsoleWriter consoleWriter, ILoggerFactory loggerFactory)
        {
            this.consoleWriter = consoleWriter;
            this.logger = loggerFactory.Create(consoleWriter);
        }

        public void Greet(string userName)
        {
            consoleWriter.WriteLine("Hello, {0}", userName);
            logger.Log($"Greeted {userName}");
        }
    }
}