using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class CountTests
    {
        [TestCase(0)]
        [TestCase(1, 1)]
        [TestCase(2, 1, 2)]
        [TestCase(8, 1, 2, 3, 4, 5, 6, 7, 8)]
        public void Count_returns_the_length_of_the_enumerable(int expectedCount, params int[] items)
        {
            Assert.That(items.Count(), Is.EqualTo(expectedCount));
        }

        [Test]
        public void Count_can_take_a_predicate()
        {
            bool IsEven(int x) => x % 2 == 0;
            
            var items = new[] {1, 2, 3, 4};
            
            Assert.That(items.Count(IsEven), Is.EqualTo(2));
        }
    }
}
