using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Sort
{
    public class MergeSort
    {
        
        public static int[] Sort(int[] input)
        {
            if (input.Length <= 1)
            {
                //base case
                return input;
            }

            var midpoint = input.Length / 2;
            var leftList = Sort(input.Take(midpoint).ToArray());
            var rightList = Sort(input.Skip(midpoint).ToArray());
            
            return Merge(leftList, rightList);
        }

        private static int[] Merge(int[] leftList, int[] rightList)
        {
            var result = new List<int>();

            var leftIndex = 0;
            var rightIndex = 0;

            while (leftIndex < leftList.Length && rightIndex < rightList.Length)
            {
                if(leftList[leftIndex] < rightList[rightIndex])
                {
                    result.Add(leftList[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(rightList[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < leftList.Length)
            {
                result.Add(leftList[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < rightList.Length)
            {
                result.Add(rightList[rightIndex]);
                rightIndex++;
            }

            return result.ToArray();
        }
    }
}
