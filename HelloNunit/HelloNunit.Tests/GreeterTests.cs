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
        Mock<ILogger> mockLogger;
        MockRepository mockRepository;

        Greeter systemUnderTest;

        [TestCase("World")]
        [TestCase("Name")]
        public void Greet_Always_PerformsExpectedWork(string userName)
        {
            mockConsoleWriter.Setup(p => p.WriteLine("Hello, {0}", userName));
            var logMessage = GenerateLogMessage(userName);
            mockLogger.Setup(p => p.Log(logMessage));
            systemUnderTest.Greet(userName);
            mockConsoleWriter.VerifyAll();
            mockLogger.VerifyAll();
        }

        [SetUp]
        public void SetUp()
        {
            mockConsoleWriter = new Mock<IConsoleWriter>(MockBehavior.Strict);
            mockLogger = new Mock<ILogger>();
            systemUnderTest = new Greeter(mockConsoleWriter.Object, mockLogger.Object);
        }

        static string GenerateLogMessage(string userName)
        {
            return $"Greeted {userName}";
        }
    }
}