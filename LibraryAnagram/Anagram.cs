namespace LibraryAnagram
{
    public class Anagram
    {
        static public string Reverse(string word)
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