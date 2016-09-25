// HelloNunit.HelloNunit.Program.cs

using System;
using System.Collections.Generic;
using Castle.Windsor;
using HelloNunit.Bootstrap;

namespace HelloNunit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = ExtractName(args);
            var container = BootstrapContainer();

            var greeter = CreateCompositionRoot(container);
            GreetUser(greeter, name);
            WaitForKeyPress();
        }

        static IWindsorContainer BootstrapContainer()
        {
            return Bootstrapper.Bootstrap();
        }

        static IGreeter CreateCompositionRoot(IWindsorContainer container)
        {
            var greeter = container.Resolve<IGreeter>();
            return greeter;
        }

        static string ExtractName(IReadOnlyList<string> args)
        {
            if (args.Count > 1)
                return args[1];
            return "World";
        }

        static void GreetUser(IGreeter greeter, string name)
        {
            greeter.Greet(name);
        }

        static void WaitForKeyPress()
        {
            Console.ReadKey();
        }
    }
}