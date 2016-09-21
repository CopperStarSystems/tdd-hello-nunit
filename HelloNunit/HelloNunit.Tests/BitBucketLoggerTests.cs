// HelloNunit.HelloNunit.Tests.BitBucketLoggerTests.cs

using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class BitBucketLoggerTests
    {
        BitBucketLogger systemUnderTest;

        [Test]
        public void Constructor_Always_Succeeds()
        {
            // Stub test
            Assert.That(systemUnderTest, Is.Not.Null);
        }

        [SetUp]
        public void SetUp()
        {
            systemUnderTest = new BitBucketLogger();
        }
    }
}