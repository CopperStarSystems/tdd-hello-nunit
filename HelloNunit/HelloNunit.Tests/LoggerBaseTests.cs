// HelloNunit.HelloNunit.Tests.LoggerBaseTests.cs

using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public abstract class LoggerBaseTests<T> : TestBase<T> where T : class, ILogger
    {
        [TestCase("message 1")]
        [TestCase("message 2")]
        public void Log_Always_PerformsExpectedWork(string message)
        {
            SetUpMocksForLogTest(message);
            SystemUnderTest.Log(message);
            MockRepositoryVerifyAll();
        }

        protected virtual void SetUpMocksForLogTest(string message)
        {
            // No default implementation
        }
    }
}