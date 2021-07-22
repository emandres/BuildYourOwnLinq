using System.Collections.Generic;
using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class ToListTests
    {
        [Test]
        public void Enumerables_can_be_turned_into_lists()
        {
            var items = EnumerableExtensions.Range(1, 5).ToList();
            
            Assert.That(items.ToList(), Is.InstanceOf<List<int>>());
            Assert.That(items.ToList(), Is.EqualTo(new[] {1, 2, 3, 4, 5}));
        }
    }
}
