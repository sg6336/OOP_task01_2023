using LibraryAnagram;

namespace LibraryAnagramTest
{
    public class Tests
    {
        Anagram objtest = new Anagram();

        [Test]

        //easy tests

        public void IsQuickTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }

        [Test]

        //hard tests

        public void IsMixTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }

        [Test]

        // empty tests

        public void IsNullOrEmptyTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }


    }
}