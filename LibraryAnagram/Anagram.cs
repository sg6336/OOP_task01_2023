namespace LibraryAnagram
{
    public class Anagram
    {
        public string Reverse(string input)
        { 
            if(input == null)
            { 
                return string.Empty; 
            }
            else if (input == "")
            {
                return string.Empty;
            }

            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseEachWord(words[i]);
            }
            return string.Join(' ', words);
        }

        private string ReverseEachWord(string word)
        {

            char[] chars = word.ToCharArray();
            int left = 0;                              // index for left side
            int right = chars.Length - 1;              // index for right side

            while (left < right)
            {
                if (!char.IsLetter(chars[left]))       // check if char is not alphabet symbol from left side
                {
                    left++;                            // go to next char
                }
                else if (!char.IsLetter(chars[right])) // check if char if non alphabet symbol from right side
                {
                    right--;                           // go to next char
                }
                else                                   // for swaping alphabet symbols
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }
            return new string(chars);
        }
    }
}