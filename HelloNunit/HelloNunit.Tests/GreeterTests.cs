// HelloNunit.HelloNunit.Tests.GreeterTests.cs

using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class GreeterTests
    {
        Greeter systemUnderTest;

        [Test]
        public void Constructor_Always_Succeeds()
        {
            Assert.That(systemUnderTest, Is.Not.Null);
        }

        [SetUp]
        public void SetUp()
        {
            systemUnderTest = new Greeter();
        }
    }
}