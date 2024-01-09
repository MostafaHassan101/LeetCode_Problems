// 872. Leaf-Similar Trees
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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var list1 = new List<int>();
        var list2 = new List<int>();
        GetLeaf(root1, list1);
        GetLeaf(root2, list2);
        if (list1.Count != list2.Count) return false;
        for (int i = 0; i < list1.Count; i++) {
            if (list1[i] != list2[i]) return false;
        }
        return true;
    }

    private void GetLeaf(TreeNode root, List<int> list) {
        if (root == null) return;
        if (root.left == null && root.right == null) {
            list.Add(root.val);
            return;
        }
        GetLeaf(root.left, list);
        GetLeaf(root.right, list);
    }
}