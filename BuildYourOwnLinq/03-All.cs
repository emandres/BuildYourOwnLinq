using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class AllTests 
    {
        [Test]
        public void All_returns_true_for_empty_enumerables()
        {
            Assert.That(new int[0].All(x => false), Is.True);
        }
        
        [TestCase(true)]
        [TestCase(false, 1)]
        [TestCase(true, 2)]
        [TestCase(false, 1, 2)]
        [TestCase(true, 2, 4)]
        public void All_returns_true_if_all_items_pass_the_predicate(bool expected, params int[] items)
        {
            bool IsEven(int x) => x % 2 == 0;
            
            Assert.That(items.All(IsEven), Is.EqualTo(expected));
        }    
    }
}
