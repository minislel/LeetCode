
namespace _26
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int L = 0;
            for (int R = 1; R < nums.Length; R++)
            {
                if (nums[L] != nums[R])
                { 
                    L++;
                    nums[L] = nums[R];
                }
            }
            return L + 1;
        }
    }
}
