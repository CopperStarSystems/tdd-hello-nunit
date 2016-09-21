// HelloNunit.HelloNunit.Tests.BitBucketLoggerTests.cs

using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class BitBucketLoggerTests : TestBase<BitBucketLogger>
    {
        [Test]
        public void Constructor_Always_Succeeds()
        {
            // Stub test
            Assert.That(SystemUnderTest, Is.Not.Null);
        }

        protected override BitBucketLogger CreateSystemUnderTest()
        {
            return new BitBucketLogger();
        }
    }
}