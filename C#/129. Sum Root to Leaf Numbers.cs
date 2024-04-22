// 129. Sum Root to Leaf Numbers
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
    public int SumNumbers(TreeNode root) {
        var sumLeafs= new List<int>();
        var sum = 0;
        if(root == null) return 0;
        SumLeafs(root, sumLeafs, 0);
        foreach(var leaf in sumLeafs){
            sum += leaf;
        }
        return sum;
    }

    public void SumLeafs(TreeNode root, List<int> sumLeafs, int sum){
        if(root == null) return;
        sum = sum * 10 + root.val;
        if(root.left == null && root.right == null){
            sumLeafs.Add(sum);
            return;
        }
        SumLeafs(root.left, sumLeafs, sum);
        SumLeafs(root.right, sumLeafs, sum);
    }
}