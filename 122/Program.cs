namespace _122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int buy = 0;
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (buy == 0 && i < prices.Length -1 && prices[i] < prices[i+1])
                {
                    buy = prices[i];
                }
                else if (buy != 0 && i == prices.Length - 1)
                {
                    max += prices[i] - buy;
                }
                else if (buy != 0 && prices[i] > buy && prices[i] > prices[i+1])
                {
                    max += prices[i] - buy;
                    buy = 0;
                }
            }
            return max;
        }
    }
}
