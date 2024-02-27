// 543. Diameter of Binary Tree
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
    public int DiameterOfBinaryTree(TreeNode root) {
        int[] res = new int[1];
        Helper(root, res);
        return res[0];
    }

    private int Helper(TreeNode root, int[] res)
    {
        if(root == null)
        {
            return 0;
        }
        int left = Helper(root.left, res);
        int right = Helper(root.right, res);
        res[0] = Math.Max(res[0], left + right);
        return Math.Max(left, right) + 1;
    }
}