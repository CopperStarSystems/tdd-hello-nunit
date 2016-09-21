// HelloNunit.HelloNunit.Tests.TestBase.cs

using Moq;
using NUnit.Framework;

namespace HelloNunit.Tests
{
    [TestFixture]
    public abstract class TestBase<T> where T : class
    {
        MockRepository mockRepository;
        protected T SystemUnderTest { get; private set; }

        protected Mock<T> CreateMock<T>() where T : class
        {
            return mockRepository.Create<T>();
        }

        protected virtual void CreateMocks()
        {
        }

        protected abstract T CreateSystemUnderTest();

        protected void MockRepositoryVerifyAll()
        {
            mockRepository.VerifyAll();
        }

        [SetUp]
        protected virtual void SetUp()
        {
            CreateMockRepository();
            CreateMocks();
            SystemUnderTest = CreateSystemUnderTest();
        }

        void CreateMockRepository()
        {
            mockRepository = new MockRepository(MockBehavior.Strict);
        }
    }
}