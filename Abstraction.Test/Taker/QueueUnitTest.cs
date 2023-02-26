using Abstraction.Core.Extensions;
using Abstraction.Core.Taker;

namespace Abstraction.Test.Taker
{
    public class QueueUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Take()
        {
            //Arrange
            ITaker<int> taker = new Abstraction.Core.Taker.Queue<int>();
            int actual, expected = 1;

            //Act
            taker.AddRange(1, 2, 3);
            actual = taker.Take();

            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}