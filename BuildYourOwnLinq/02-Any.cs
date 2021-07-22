using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class AnyTests
    {
        [TestCase(false)]
        [TestCase(true, 1)]
        [TestCase(true, 1, 2)]
        public void Any_can_be_called_without_parameters(bool expected, params int[] items)
        {
            Assert.That(items.Any(), Is.EqualTo(expected));
        }

        [TestCase(false)]
        [TestCase(false, 1)]
        [TestCase(true, 1, 2)]
        public void Any_can_be_passed_a_predicate(bool expected, params int[] items)
        {
            bool IsEven(int x) => x % 2 == 0;
            
            Assert.That(items.Any(IsEven), Is.EqualTo(expected));
        }
    }
}
