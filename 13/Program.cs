namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.RomanToInt("III"));
            Console.WriteLine(solution.RomanToInt("IV"));
            Console.WriteLine(solution.RomanToInt("IX"));
            Console.WriteLine(solution.RomanToInt("LVIII"));
            Console.WriteLine(solution.RomanToInt("MCMXCIV"));
        }
    }
    public class Solution
    {
        private Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i >=1 && romanMap[s[i]] > romanMap[s[i-1]])
                {
                    result += romanMap[s[i]] - romanMap[s[i - 1]];
                    i--;
                }
                else
                {
                    result += romanMap[s[i]];
                }
            }
            return result;
        }
    }
}
