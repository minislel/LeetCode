public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int L = 0;
        int R = nums.Length - 1;
        var sorted = nums.OrderBy(x => x).ToArray();
        while (true)
        {
            if (sorted[L] + sorted[R] > target)
            {
                R--;
            }
            else if (sorted[L] + sorted[R] < target)
            {
                L++;
            }
            else
            {
                R = Array.LastIndexOf(nums, sorted[R]);
                L = Array.IndexOf(nums, sorted[L]);
                return new int[] { L, R };
            }
        }
    }
}