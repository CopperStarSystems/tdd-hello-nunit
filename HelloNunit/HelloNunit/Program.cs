// HelloNunit.HelloNunit.Program.cs

namespace HelloNunit
{
    public class Program
    {
        static IGreeter greeter;

        public static void Main(string[] args)
        {
            // Greeter is our composition root, usually we would
            // resolve from an IoC container here instead of directly
            // instantiating.
            greeter = new Greeter();
        }
    }
}