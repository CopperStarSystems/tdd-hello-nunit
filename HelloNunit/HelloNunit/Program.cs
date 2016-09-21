// HelloNunit.HelloNunit.Program.cs

using HelloNunit.FrameworkWrappers;

namespace HelloNunit
{
    public class Program
    {
        static IGreeter greeter;

        public static void Main(string[] args)
        {
            // Normally this dependency would be fulfilled by the IoC
            // container.
            IConsoleWriter consoleWriter = new ConsoleWriter();

            // Greeter is our composition root, usually we would
            // resolve from an IoC container here instead of directly
            // instantiating.
            greeter = new Greeter(consoleWriter);
        }
    }
}