// HelloNunit.HelloNunit.Greeter.cs

using HelloNunit.FrameworkWrappers;

namespace HelloNunit
{
    public class Greeter : IGreeter
    {
        readonly IConsoleWriter consoleWriter;

        public Greeter(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
        }

        public void Greet(string userName)
        {
            consoleWriter.WriteLine("Hello, {0}", userName);
        }
    }
}