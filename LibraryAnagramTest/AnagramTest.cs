using LibraryAnagram;

namespace LibraryAnagramTest
{
    public class Tests
    {
        [Test]
        public void Reverse_AlphabetOnly()
        {
            string result = Anagram.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void Reverse_NonAlphabetOnly()
        {
            string result = Anagram.Reverse("1234");
            Assert.AreEqual("1234", result);
        }

        [Test]
        public void Reverse_AlphabetAndNonAlphabet()
        {
            string result = Anagram.Reverse("hello, world!");
            Assert.AreEqual("dlrow, olleh!", result);
        }

        [Test]
        public void Reverse_EmptyString()
        {
            string result = Anagram.Reverse("");
            Assert.AreEqual("", result);
        }
    }
}