namespace _80
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
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
            foreach (var key in dict.Keys)
            {
                if (dict[key] > 2)
                {
                    dict[key] = 2;
                }
            }
            int j = 0;
            for (int i = 0; i < nums.Length;i++)
            {
                try
                {
                    if (dict.ElementAt(j).Value > 1)
                    {
                        nums[i] = dict.ElementAt(j).Key;
                        nums[i + 1] = dict.ElementAt(j).Key;
                        if (i + 1 < nums.Length)
                        {
                            i++;
                        }
                    }
                    else
                    {
                        nums[i] = dict.ElementAt(j).Key;
                    }
                    j++;
                }
                catch
                {
                    break;
                }
            }
            return dict.Sum(x => x.Value);
        }
    }
}
