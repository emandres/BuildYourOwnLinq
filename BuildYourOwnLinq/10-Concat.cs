using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class ConcatTests
    {
        [Test]
        public void Concat_creates_an_enumerable_composed_of_one_list_followed_by_another()
        {
            var items1 = new[] {1, 2, 3};
            var items2 = new[] {4, 5, 6};

            Assert.That(items1.Concat(items2), Is.EqualTo(new[] {1, 2, 3, 4, 5, 6}));
        }
    }
}
