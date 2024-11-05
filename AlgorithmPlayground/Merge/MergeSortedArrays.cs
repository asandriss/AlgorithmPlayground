using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Merge
{
    public class MergeSortedArrays
    {
        public static int[] Merge(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr1.Length < 1) return arr2;
            if (arr2 == null || arr2.Length < 1) return arr1;

            return Array.Empty<int>();

        }
    }
}
