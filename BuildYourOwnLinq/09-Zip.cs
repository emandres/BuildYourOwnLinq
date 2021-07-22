using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class ZipTests
    {
        [Test]
        public void Zip_combines_items_in_two_enumerables_into_tuples()
        {
            var items1 = EnumerableExtensions.Range(1, 10);
            var items2 = EnumerableExtensions.Range(10, 10);
            var zipped = items1.Zip(items2).ToList();
            
            Assert.That(zipped[0], Is.EqualTo((1, 10)));
            Assert.That(zipped[1], Is.EqualTo((2, 11)));
            Assert.That(zipped[2], Is.EqualTo((3, 12)));
            Assert.That(zipped[3], Is.EqualTo((4, 13)));
        }

        [Test]
        public void Zip_ends_when_either_enumerable_ends()
        {
            var items1 = new[] {1};
            var items2 = EnumerableExtensions.InfiniteConstant(2);
            var zipped = items1.Zip(items2).ToList();
            
            Assert.That(zipped.Count(), Is.EqualTo(1));
            Assert.That(zipped[0], Is.EqualTo((1,2)));
        }

        [Test]
        public void Zip_can_take_a_function_to_map_the_results()
        {
            var items1 = EnumerableExtensions.Range(1, 10);
            var items2 = EnumerableExtensions.Range(10, 10);
            var zipped = items1.Zip(items2, (x, y) => x * y).ToList();
            
            Assert.That(zipped[0], Is.EqualTo(10));
            Assert.That(zipped[1], Is.EqualTo(22));
            Assert.That(zipped[2], Is.EqualTo(36));
            Assert.That(zipped[3], Is.EqualTo(52));
        }
    }
}
