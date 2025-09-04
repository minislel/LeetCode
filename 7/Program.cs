namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.Reverse(int.MaxValue));
        }
    }
    public class Solution
    {
        public int Reverse(int x)
        {
            string s = x.ToString();
            bool isNegative = s[0] == '-';

            var reversed = new string(s.Reverse().ToArray());
            for (int i = 0; i < reversed.Length; i++)
            {
                reversed = reversed.Replace("-", "");
            }
            string resultStr = isNegative ? "-" + reversed : reversed;
            try
            {
                return int.Parse(resultStr);
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
