// HelloNunit.HelloNunit.Tests.ProgramTests.cs

using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        Program systemUnderTest;

        [Test]
        public void Constructor_Always_Succeeds()
        {
            // Initial stub test
            Assert.That(systemUnderTest, Is.Not.Null);
        }

        [SetUp]
        public void SetUp()
        {
            systemUnderTest = new Program();
        }
    }
}