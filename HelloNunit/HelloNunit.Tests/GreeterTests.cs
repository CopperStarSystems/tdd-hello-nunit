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
            var logMessage = GenerateLogMessage(userName);
            mockConsoleWriter.Setup(p => p.WriteLine("Hello, {0}", userName));
            mockLogger.Setup(p => p.Log(logMessage));

            systemUnderTest.Greet(userName);
            MockRepositoryVerifyAll();
        }

        [SetUp]
        public void SetUp()
        {
            mockRepository = new MockRepository(MockBehavior.Strict);

            CreateMocks();
            systemUnderTest = CreateSystemUnderTest();
        }

        static string GenerateLogMessage(string userName)
        {
            return $"Greeted {userName}";
        }

        Mock<T> CreateMock<T>() where T : class
        {
            return mockRepository.Create<T>();
        }

        void CreateMocks()
        {
            mockConsoleWriter = CreateMock<IConsoleWriter>();
            mockLogger = CreateMock<ILogger>();
        }

        Greeter CreateSystemUnderTest()
        {
            return new Greeter(mockConsoleWriter.Object, mockLogger.Object);
        }

        void MockRepositoryVerifyAll()
        {
            mockRepository.VerifyAll();
        }
    }
}