using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Search
{
    public class CompareTwoArrays
    {
        // Given 2 arrays, create a function that lets the user now whether they contain any common items
        //
        // For example
        //  [a, b, c, x] & [z, y, x] 
        //  would return true, as X is shared

        public static bool CompareTwoArraysFun(int[] a, int[] b)
        {
            // O(n) solution - will run through both arrays once.
            var originalSet = new HashSet<int>(a);

            foreach (var item in b)
            {
                if (originalSet.Contains(item))
                    return true;
            }

            return false;
        }
    }
}
