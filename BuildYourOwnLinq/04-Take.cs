using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class TakeTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(123)]
        [TestCase(9999, 1000)]
        public void Take_limits_the_enumerable_to_the_specified_length(int take, int? expectedLength = null)
        {
            var items = EnumerableExtensions.Range(0, 1000);
            
            Assert.That(items.Take(take).Count(), Is.EqualTo(expectedLength ?? take));
        }

        [Test]
        public void Take_returns_the_items_in_the_same_order()
        {
            var items = EnumerableExtensions.Range(0, 1000);
            var taken = items.Take(100);

            var i = 0;
            foreach (var item in taken)
            {
                Assert.That(item, Is.EqualTo(i++));
            }
        }
    }
}
