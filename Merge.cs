public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
                for(int i = n -1; i >= 0; i--) {
            nums1[m + i] = nums2[i];
        }
        Array.Sort(nums1);
    }
}