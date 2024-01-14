// 88. Merge Sorted Array

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int j = 0;
        while(n > 0){
            nums1[m] = nums2[j];
            m++;
            j++;
            n--;
        }
        Array.Sort(nums1);
    }
}