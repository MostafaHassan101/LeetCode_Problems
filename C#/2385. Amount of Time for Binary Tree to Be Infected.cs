// 2385. Amount of Time for Binary Tree to Be Infected
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
    private int result;
    public int AmountOfTime(TreeNode root, int start) {
        DFS(root, start);
        return result;
    }

    private int DFS(TreeNode node, int start){
        if(node == null) return 0;

        int leftDepth = DFS(node.left, start);
        int rightDepth = DFS(node.right, start);

        if(node.val == start){
            result = Math.Max(leftDepth, rightDepth);
            return -1;
        }
        else if(leftDepth >= 0 && rightDepth >= 0)
            return Math.Max(leftDepth, rightDepth)+1;
        
        result = Math.Max(result, Math.Abs(leftDepth - rightDepth));
        return Math.Min(leftDepth, rightDepth) - 1;
    }
}