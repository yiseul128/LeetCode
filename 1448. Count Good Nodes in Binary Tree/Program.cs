/* Definition for a binary tree node.  */
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int GoodNodes(TreeNode root)
    {
        return RecurGoodNodes(root, Int32.MinValue);
    }

    public int RecurGoodNodes(TreeNode currNode, int max)
    {
        int count = 0;
        if (currNode.val >= max)
        {
            count++;
            max = currNode.val;
        }

        if (currNode.left != null)
        {
            count += RecurGoodNodes(currNode.left, max);
        }
        if (currNode.right != null)
        {
            count += RecurGoodNodes(currNode.right, max);
        }

        return count;
    }
}