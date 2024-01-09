// 938. Range Sum of BST

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null) return 0;

        int res = 0;
        if (IsInRange(root.val, low, high))
            res += root.val;

        res += RangeSumBST(root.left, low, high);
        res += RangeSumBST(root.right, low, high);

        return res;
    }

    private bool IsInRange(int val, int low, int high) {
        return val >= low && val <= high;
    }
}