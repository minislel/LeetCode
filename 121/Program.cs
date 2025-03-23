namespace _121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int cheapest = int.MaxValue;
            int max = 0;
            for (int i = 0; i<prices.Length; i++)
            {
                if (prices[i] < cheapest)
                {
                    cheapest = prices[i];
                }
                else if (prices[i] - cheapest > max)
                {
                    max = prices[i] - cheapest;
                }
            }
            return max;
        }
    }
}
