public class Program
{
    public static void Main()
    {
        var nums1 = new int[] { 4,5,6,0,0,0};
        var nums2 = new int[] { 1,2,3};
        var solution = new Solution();
        solution.Merge(nums1, 3, nums2, 3);
        foreach (var num in nums1)
        {
            Console.WriteLine(num);
        }
    } 
}
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int A = m - 1;
        int B = n - 1;
        int C = m+n-1;
        while (A>=0 && B>=0)
        {
            if (nums1[A] > nums2[B])
            {
                nums1[C] = nums1[A];
                A--;
            }
            else
            {
                nums1[C] = nums2[B];
                B--;
            }
            C--;
        }
        while (B>=0)
        {
            nums1[C] = nums2[B];
            B--;
            C--;
        }
    }
}