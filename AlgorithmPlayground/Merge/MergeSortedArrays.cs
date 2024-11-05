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

            List<int> retVal = new();
            
            var i = 0;
            var j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    retVal.Add(arr1[i]);
                    i++;
                }
                else
                {
                    retVal.Add(arr2[j]);
                    j++;
                }
            }

            if (i < arr1.Length)
            {
                retVal.AddRange(arr1.Skip(i));
            }

            if (j < arr2.Length)
            {
                retVal.AddRange(arr2.Skip(j));
            }

            return retVal.ToArray();
        }
    }
}
