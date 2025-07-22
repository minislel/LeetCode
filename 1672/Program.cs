namespace _1672
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.MaximumWealth([[1, 5], [7, 3], [3, 5]]));
        }
    }
}
public class Solution {
    public int MaximumWealth(int[][] accounts) {
         int maxWealth = 0;
            foreach (var account in accounts) {
                int currentWealth = 0;
                foreach (var money in account) {
                    currentWealth += money;
                }
                if (currentWealth > maxWealth) {
                    maxWealth = currentWealth;
                }
        }
            return maxWealth;
    }
}