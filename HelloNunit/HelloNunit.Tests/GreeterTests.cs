// HelloNunit.HelloNunit.Tests.GreeterTests.cs

using HelloNunit.Factories;
using HelloNunit.FrameworkWrappers;
using Moq;
using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class GreeterTests : TestBase<Greeter>
    {
        Mock<IConsoleWriter> mockConsoleWriter;
        Mock<ILogger> mockLogger;
        Mock<ILoggerFactory> mockLoggerFactory;

        [TestCase("World")]
        [TestCase("Name")]
        public void Greet_Always_PerformsExpectedWork(string userName)
        {
            SetupMocksForGreetTest(userName);
            SystemUnderTest.Greet(userName);
            MockRepositoryVerifyAll();
        }

        protected override void CreateMocks()
        {
            base.CreateMocks();
            mockConsoleWriter = CreateMock<IConsoleWriter>();
            mockLogger = CreateMock<ILogger>();
            mockLoggerFactory = CreateMock<ILoggerFactory>();
        }

        protected override void SetUpConstructorRequiredMocks()
        {
            base.SetUpConstructorRequiredMocks();
            mockLoggerFactory.Setup(p => p.Create(mockConsoleWriter.Object)).Returns(mockLogger.Object);
        }

        protected override Greeter CreateSystemUnderTest()
        {
            return new Greeter(mockConsoleWriter.Object, mockLoggerFactory.Object);
        }

        static string GenerateLogMessage(string userName)
        {
            return $"Greeted {userName}";
        }

        void SetupMocksForGreetTest(string userName)
        {
            var logMessage = GenerateLogMessage(userName);
            mockConsoleWriter.Setup(p => p.WriteLine("Hello, {0}", userName));
            mockLogger.Setup(p => p.Log(logMessage));
        }
    }
}