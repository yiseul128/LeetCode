/* Definition for a binary tree node. */
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
    public int LongestZigZag(TreeNode root)
    {
        int leftMax = 0, rightMax = 0;
        if (root.left != null)
        {
            leftMax = RecurLongestZigZag(root.left, false, 1);
        }
        if (root.right != null)
        {
            rightMax = RecurLongestZigZag(root.right, true, 1);
        }

        return leftMax > rightMax ? leftMax : rightMax;
    }

    public int RecurLongestZigZag(TreeNode currNode, bool isPrevRight, int path)
    {
        int max = path;

        if (currNode.left != null)
        {
            int leftMax;
            if (isPrevRight)
            {
                leftMax = RecurLongestZigZag(currNode.left, false, path + 1);
            }
            else
            {
                leftMax = RecurLongestZigZag(currNode.left, false, 1);
            }
            max = max > leftMax ? max : leftMax;
        }

        if (currNode.right != null)
        {
            int rightMax;
            if (isPrevRight)
            {
                rightMax = RecurLongestZigZag(currNode.right, true, 1);
            }
            else
            {
                rightMax = RecurLongestZigZag(currNode.right, true, path + 1);
            }
            max = max > rightMax ? max : rightMax;
        }

        return max;
    }
}