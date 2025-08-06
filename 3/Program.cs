namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("abcabcbb");
            Console.WriteLine(result);
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var chars = new List<char>();
            int maxLength = 0;  
            int L = 0, R = 0;
            while (R < s.Length)
            {
                if (!chars.Contains(s[R]))
                {   
                    if (R - L + 1 > maxLength)
                    {
                        maxLength = R - L + 1;
                    }
                    chars.Add(s[R]);
                    R++;
                }
                else
                {
                    while (L < R && chars.Contains(s[R]))
                    {
                        chars.Remove(s[L]);
                        L++;
                    }
                }
            }
            return maxLength;
        }
    }
}
