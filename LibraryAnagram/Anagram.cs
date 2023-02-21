using System.Globalization;
using System.Text;
using System.Xml.Linq;


namespace LibraryAnagram
{
    public class Anagram
    {
        public string Reverse(string str)
        {
            if (str == "")
            {
                return string.Empty;
            }
            if (str == null)
            {
                return string.Empty;
            }
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseEachWord(words[i]);
            }
            return string.Join(' ', words);
        }

        private string ReverseEachWord(string word)
        {
            string result = "";
            int length = word.Length;
            int j = word.Length - 1;
            for (int i = 0; i < length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if (char.IsLetter(word[j]))
                    {
                        result += word[j];
                        j--;
                    }
                    else
                    {
                        i--;
                        j--;
                    }
                }
                else
                    result += word[i];
            }

            return result;
        }
    }
}
