namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var nums1 = new int[] { 2, 2, 4, 4 };
            var nums2 = new int[] { 2,2,2,4,4 };
            var result = solution.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine($"Median: {result}");
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var merged = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, merged, nums1.Length);
            Array.Copy(nums2, 0, merged, nums1.Length, nums2.Length);
            Array.Sort(merged);
            int n = merged.Length;
            if (n % 2 == 0)
            {
                return (merged[(n / 2) - 1] + merged[(n / 2)]) * 0.5;
            }
            return merged[n / 2];
        }
    }
}
