using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.LeetCode
{
    public class MergeStringsAlternately
    {
        public static string Merge(string word1, string word2)
        {
            var max = Math.Max(word1.Length, word2.Length);
            
            var result = string.Empty;

            for (int i = 0; i < max; i++)
            {
                if(i < word1.Length)
                    result += word1[i];

                if(i < word2.Length)
                    result += word2[i];
            }

            return result;
        }
    }
}
