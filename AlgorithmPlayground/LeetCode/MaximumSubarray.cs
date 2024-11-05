using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.LeetCode
{
    public class MaximumSubarray
    {
        public static int GetMax(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            long current = int.MinValue;
            long max = int.MinValue;

            foreach (var t in nums)
            {
                current = Math.Max(t, current + t);
                max = Math.Max(max, current);
            }

            return (int)max;
        }
    }
}
