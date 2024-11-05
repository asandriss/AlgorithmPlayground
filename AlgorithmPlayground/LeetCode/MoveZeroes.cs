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
            Queue<int> zeroes = new Queue<int>();

            for (int i = 0; i < nums.Length;)
            {
                if (nums[i] == 0)
                {
                    zeroes.Enqueue(i);
                    i++;
                    continue;
                }

                if (nums[i] != 0 && zeroes.TryPeek(out int zeroIndex))
                {
                    zeroIndex = zeroes.Dequeue();
                    nums[zeroIndex] = nums[i];
                    nums[i] = 0;
                    continue;
                }

                i++;
            }
        }
    }
}
