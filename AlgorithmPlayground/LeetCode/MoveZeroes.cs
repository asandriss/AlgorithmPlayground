using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.LeetCode
{
    public class MoveZeroes
    {
        public static void MoveZeroesToTheEnd(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    // we are at zero, need to swap
                    //  find the first not-zero index
                    var candidate = i + 1;
                    while (candidate < nums.Length)
                    {
                        if (nums[candidate] != 0)
                        {
                            //var tmp = nums[i];
                            nums[i] = nums[candidate];
                            nums[candidate] = 0;
                            break;      // found a swap, we can exit the inner loop
                        }

                        candidate++;
                    }
                }
            }
        }
    }
}
