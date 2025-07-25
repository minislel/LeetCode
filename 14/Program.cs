using System.Text;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var strs = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(sol.LongestCommonPrefix(strs));
        }
    }
    public class Solution
    {
        
        public string LongestCommonPrefix(string[] strs)
        {
            var prefixes = new List<string>();
            if (strs == null || strs.Length == 0)
            {
                return string.Empty;
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            for (int i = 0; i < strs.Length; i++) 
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == j) continue; 
                    var minLength =  Math.Min(strs[i].Length, strs[j].Length);
                    var prefixsb = new StringBuilder();
                    for (int k = 0; k < minLength; k++)
                    {
                        if (strs[i][k] == strs[j][k])
                        {
                            prefixsb.Append(strs[i][k]);
                        }
                        else
                        {  
                            break;
                        }
                    }
                    prefixes.Add(prefixsb.ToString());
                }
            }
            for (int i = 0; i < prefixes.Count; i++) 
            {
                for(int j = 0; j<strs.Length; j++)
                {
                    if (prefixes[i].Length > strs[j].Length || !strs[j].StartsWith(prefixes[i]))
                    {
                        prefixes.RemoveAt(i);
                        i--; // Adjust index after removal
                        break; // Exit inner loop to recheck the current prefix
                    }
                }
            }

            return prefixes.Count > 0 ? prefixes.Max() : string.Empty;
        }
    }
}
