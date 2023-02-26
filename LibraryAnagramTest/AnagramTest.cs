using LibraryAnagram;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Globalization;
using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Constraints;

namespace LibraryAnagramTest
{
    public class Tests
    {
        Anagram objtest = new Anagram();

        [Test]
        [TestCase("abcd", "dcba")]
        [TestCase("qwer1t", "trew1q")]
        [TestCase("a!bcd efg*h", "d!cba hgf*e")]
        [TestCase("tyr rew", "ryt wer")]

        public void IsQuickTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Test", "tseT")]
        [TestCase("Hello!", "olleh!")]
        [TestCase("yes. Yes", "sey. seY")]
        [TestCase("1 + 2 = 3", "1 + 2 = 3")]
        [TestCase(" Anagram6", " marganA6")]

        public void IsMixTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("", "")]
        [TestCase(null, "")]

        public void IsNullOrEmptyTest(string testString, string expectedResult)
        {
            Assert.That(objtest.Reverse(testString), Is.EqualTo(expectedResult));
        }
    }
}