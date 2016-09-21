// HelloNunit.HelloNunit.Program.cs

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
            ILogger logger = new BitBucketLogger();

            // Greeter is our composition root, usually we would
            // resolve from an IoC container here instead of directly
            // instantiating.
            greeter = new Greeter(consoleWriter, logger);
        }
    }
}