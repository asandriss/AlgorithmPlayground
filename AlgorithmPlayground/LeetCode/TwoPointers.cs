namespace AlgorithmPlayground.LeetCode
{
    public class TwoPointers
    {
        public static bool IsSubsequence(string sub, string main)
        {
            var subIndex = 0;

            foreach (var charToLookFor in main)
            {
                if (subIndex == sub.Length)
                    break;

                if (sub[subIndex] == charToLookFor)
                {
                    subIndex++;
                }
            }

            return subIndex >= sub.Length;
        }
    }
}
