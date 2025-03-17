namespace _27
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            int countOfVal = 0;
            int L = 0;
            int R = nums.Length - 1;
            foreach (var n in nums)
            {
                if (n != val)
                {
                    count++;
                }
                else
                {
                    countOfVal++;
                }
            }

            while (countOfVal > 0)
            {
                if (count == 0)
                { 
                    return 0;
                }
                if (nums[R] == val)
                {
                    R--;
                    countOfVal--;
                }
                else if (nums[L] == val)
                {
                    var temp = nums[R];
                    nums[R] = nums[L];
                    nums[L] = temp;
                    R--;
                    countOfVal--;
                    L++;
                }
                else
                {
                    L++;
                }
            }
            return count;
        }
    }
}
