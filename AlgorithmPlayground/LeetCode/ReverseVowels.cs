using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.LeetCode
{
    public class ReverseArrays
    {
        public static string ReverseWords(string s)
        {
            var words = new List<string>();
            var currentWord = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var currentCharacter = s[i].ToString();

                if (string.IsNullOrWhiteSpace(currentCharacter) && !string.IsNullOrWhiteSpace(currentWord))
                {
                    // we have a word
                    words.Add(currentWord);
                    currentWord = string.Empty;
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(currentCharacter))
                {
                    currentWord += currentCharacter;
                    continue;
                }
            }

            if(!string.IsNullOrWhiteSpace(currentWord)) words.Add(currentWord);

            words.Reverse();

            return string.Join(' ', words);
        }

        public static string ReverseVowels(string s)
        {
            var arr = s.ToCharArray();
            var vowelsInString = new List<char>();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    vowelsInString.Add(s[i]);
                }
            }

            var replacements = vowelsInString.Count - 1;

            int j = 0;
            while (replacements >= 0)
            {
                if (vowels.Contains(s[j]))
                {
                    arr[j] = vowelsInString[replacements];
                    replacements--;
                }

                j++;
            }

            return new string(arr);
        }
    }
}
