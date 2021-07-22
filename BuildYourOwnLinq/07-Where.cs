using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class WhereTests
    {
        [Test]
        public void Where_removes_items_from_the_enumerable_that_do_not_pass_the_predicate()
        {
            bool IsEven(int x) => x % 2 == 0;
            
            var items = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var expected = new[] {2, 4, 6, 8, 10};
            
            Assert.That(items.Where(IsEven), Is.EqualTo(expected));
        }
    }
}
