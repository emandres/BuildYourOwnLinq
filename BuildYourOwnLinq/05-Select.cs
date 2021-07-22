using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class SelectTests
    {
        [Test]
        public void Select_maps_each_item()
        {
            var items = new [] {1, 2, 3, 4};
            var expected = new[] {1, 4, 9, 16};
            
            Assert.That(items.Select(x => x * x), Is.EqualTo(expected));
        }

        [Test]
        public void Select_is_lazy()
        {
            var result = EnumerableExtensions.InfiniteConstant(1).Select(x => x + 1).Take(3);
            var expected = new[] {2, 2, 2};

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
