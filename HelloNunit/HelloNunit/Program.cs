// HelloNunit.HelloNunit.Program.cs

using HelloNunit.Factories;
using HelloNunit.FrameworkWrappers;

namespace HelloNunit
{
    public class Program
    {
        static IGreeter greeter;

        public static void Main(string[] args)
        {
            // Normally these dependencies would be fulfilled by the IoC
            // container.
            IConsoleWriter consoleWriter = new ConsoleWriter();

            // Switching out for Console logger
            // ILogger logger = new BitBucketLogger();

            // Switching out to use LoggerFactory
            // ILogger logger = new ConsoleLogger(consoleWriter);

            ILoggerFactory loggerFactory = new LoggerFactory();

            // Greeter is our composition root, usually we would
            // resolve from an IoC container here instead of directly
            // instantiating.
            greeter = new Greeter(consoleWriter, loggerFactory);
        }
    }
}