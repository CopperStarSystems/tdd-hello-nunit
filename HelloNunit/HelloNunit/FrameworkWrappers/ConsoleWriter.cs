// HelloNunit.HelloNunit.ConsoleWriter.cs

using System;

namespace HelloNunit.FrameworkWrappers
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}