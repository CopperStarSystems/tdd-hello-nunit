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

        [TestCase("World")]
        [TestCase("Name")]
        public void Greet_Always_PerformsExpectedWork(string userName)
        {
            mockConsoleWriter.Setup(p => p.WriteLine("Hello, {0}", userName));
            systemUnderTest.Greet(userName);
            mockConsoleWriter.VerifyAll();
        }

        [SetUp]
        public void SetUp()
        {
            mockConsoleWriter = new Mock<IConsoleWriter>(MockBehavior.Strict);
            systemUnderTest = new Greeter(mockConsoleWriter.Object);
        }
    }
}