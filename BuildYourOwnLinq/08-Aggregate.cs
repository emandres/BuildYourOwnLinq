using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class AggregateTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 3)] // 1 + 2 = 3
        [TestCase(3, 6)] // 1 + 2 + 3 = 6
        [TestCase(4, 10)] // ...
        [TestCase(5, 15)]
        [TestCase(6, 21)]
        public void Aggregate_rolls_up_values(int numberOfItems, int expectedSum)
        {
            var items = EnumerableExtensions.Range(1, numberOfItems);
            var sum = items.Aggregate(0, (a, b) => a + b);
            
            Assert.That(sum, Is.EqualTo(expectedSum));
        }
    }
}
