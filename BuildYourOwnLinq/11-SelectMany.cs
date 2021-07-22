using NUnit.Framework;

namespace BuildYourOwnLinq
{
    public class SelectManyTests
    {
        [Test]
        public void SelectMany_select_and_flattens()
        {
            var arrayOfArrays = new[]
            {
                new[] {1, 2, 3, 4, 5},
                new[] {6, 7, 8},
                new[] {9, 10}
            };
            
            Assert.That(arrayOfArrays.SelectMany(x => x), Is.EqualTo(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}));
        }

        [Test]
        public void Another_SelectMany_example()
        {
            var words = new[] {"four", "score", "and", "seven", "years", "ago"};

            var expected = "fourscoreandsevenyearsago".ToCharArray();
            
            Assert.That(words.SelectMany(x => x.ToCharArray()), Is.EqualTo(expected));
        }
    }
}
