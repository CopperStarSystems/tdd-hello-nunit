// HelloNunit.HelloNunit.Tests.GreeterTests.cs

using HelloNunit.FrameworkWrappers;
using Moq;
using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class GreeterTests
    {
        Mock<IConsoleWriter> mockConsoleWriter;
        Greeter systemUnderTest;

        [Test]
        public void Greet_Always_PerformsExpectedWork()
        {
            mockConsoleWriter.Setup(p => p.WriteLine("Hello World"));
            systemUnderTest.Greet("World");
            mockConsoleWriter.VerifyAll();
        }

        [SetUp]
        public void SetUp()
        {
            mockConsoleWriter = new Mock<IConsoleWriter>();
            systemUnderTest = new Greeter(mockConsoleWriter.Object);
        }
    }
}