
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }
        if (m == 0)
        { 
            for (int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
            return;
        }
        for (int i = m + n - 1; i >= 0; i--)
        {
            if (nums1[i] == 0 && nums1[i - 1] == 0)
            {
                nums1[i] = nums2[n - 1];
                n--;
            }
            else if (nums1[i] == 0 && nums1[i - 1] != 0 && nums2[n - 1] < nums1[i - 1])
            {
                nums1[i] = nums1[i-1];
                nums1[i-1] = nums2[n - 1];
                n--;
            }
            else if (nums1[i] == 0 && nums1[i - 1] != 0 && nums2[n - 1] >= nums1[i - 1])
            {
                nums1[i] = nums2[n - 1];
                n--;
            }
            
        }
    }
}