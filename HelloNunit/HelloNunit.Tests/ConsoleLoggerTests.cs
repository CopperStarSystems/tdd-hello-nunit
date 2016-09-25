// HelloNunit.HelloNunit.Tests.ConsoleLoggerTests.cs

using HelloNunit.FrameworkWrappers;
using Moq;

namespace HelloNunit.Tests
{
    public class ConsoleLoggerTests : LoggerBaseTests<ConsoleLogger>
    {
        Mock<IConsoleWriter> mockConsoleWriter;

        protected override void CreateMocks()
        {
            base.CreateMocks();
            mockConsoleWriter = CreateMock<IConsoleWriter>();
        }

        protected override ConsoleLogger CreateSystemUnderTest()
        {
            return new ConsoleLogger(mockConsoleWriter.Object);
        }

        protected override void SetUpMocksForLogTest(string message)
        {
            base.SetUpMocksForLogTest(message);
            mockConsoleWriter.Setup(p => p.WriteLine(message));
        }
    }
}