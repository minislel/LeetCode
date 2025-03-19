namespace _169
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            var max = 0;
            var maxKey = 0;
            foreach (var key in dict.Keys)
            {
                if (dict[key] > max)
                {
                    max = dict[key];
                    maxKey = key;
                }
            }
            return maxKey;
        }
    }
}
