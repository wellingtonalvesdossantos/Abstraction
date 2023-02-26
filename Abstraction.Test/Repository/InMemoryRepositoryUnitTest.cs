using Abstraction.Core.Models;
using Abstraction.Core.Repository;

namespace Abstraction.Test.Repository
{
    public class InMemoryRepositoryUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count()
        {
            //Arrange
            IRepository<State> repository = new InMemoryRepository<State>();
            long actual, expected = 0;

            //Act
            actual = repository.Count();

            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}