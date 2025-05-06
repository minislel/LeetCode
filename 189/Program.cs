namespace _189
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int L = 0;
            int R = nums.Length - 1;
            int[] numsCopy = new int[nums.Length];
            Array.Copy(nums, numsCopy, nums.Length);
            k %= nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[L] = nums[R];
                L++;
            }
        }
    }
}
