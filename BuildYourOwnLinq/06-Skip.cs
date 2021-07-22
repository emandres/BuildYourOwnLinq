using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class SkipTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(123)]
        [TestCase(9999, 0)]
        public void Skip_remove_the_expected_number_of_items(int skip, int? expectedLength = null)
        {
            var items = EnumerableExtensions.Range(0, 1000);
            
            Assert.That(items.Skip(skip).Count(), Is.EqualTo(expectedLength ?? 1000 - skip));
        }
        
        [Test]
        public void Skip_returns_the_items_in_the_same_order()
        {
            var items = EnumerableExtensions.Range(0, 1000);
            var remaining = items.Skip(100);

            var i = 100;
            foreach (var item in remaining)
            {
                Assert.That(item, Is.EqualTo(i++));
            }
        }
        
    }
}
