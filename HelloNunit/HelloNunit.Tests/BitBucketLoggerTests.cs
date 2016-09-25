// HelloNunit.HelloNunit.Tests.BitBucketLoggerTests.cs

using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class BitBucketLoggerTests : LoggerBaseTests<BitBucketLogger>
    {
        protected override BitBucketLogger CreateSystemUnderTest()
        {
            return new BitBucketLogger();
        }
    }
}