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
            var arr1 = word1.ToCharArray();
            var arr2 = word2.ToCharArray();
            var commonLength = Math.Min(arr1.Length, arr2.Length);
            
            var result = string.Empty;

            for (int i = 0; i < commonLength; i++)
            {
                result += arr1[i].ToString() + arr2[i].ToString();
            }

            if (arr1.Length > commonLength)
                result += word1.Substring(commonLength);

            if (arr2.Length > commonLength)
                result += word2.Substring(commonLength);
            
            return result;
        }
    }
}
