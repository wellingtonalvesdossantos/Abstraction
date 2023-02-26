using Abstraction.Core.Models;
using Abstraction.Core.Repository;

namespace Abstraction.Test.Repository
{
    public class FileRepositoryUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count()
        {
            //Arrange
            IRepository<State> repository = new StateFileRepository();
            long actual, expected = 3;

            //Act
            actual = repository.Count();

            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}