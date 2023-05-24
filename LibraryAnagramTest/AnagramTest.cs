using LibraryAnagram;

namespace LibraryAnagramTest
{
    public class Tests
    {
        Anagram objtest = new Anagram();

        [Test]
        [TestCase("Test", "tseT")]
        [TestCase("agog", "goga")]
        [TestCase("a!bcd efg5h", "d!cba hgf5e")]
        [TestCase("kap!! (0)pus", "pak!! (0)sup")]

        public void IsQuickTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("nba", "abn")]
        [TestCase("holo", "oloh")]
        [TestCase("hiphop", "pohpih")]
        [TestCase("n*ba", "a*bn")]
        [TestCase("l*bby", "y*bbl")]
        [TestCase("momm !! y */hug21e", "mmom !! y */egu21h")]
        public void IsMixTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        public void IsNullOrEmptyTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }
    }
}