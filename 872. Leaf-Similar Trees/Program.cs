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
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        Queue<int> leaves1 = new Queue<int>();
        FindLeaves(root1, leaves1);

        Queue<int> leaves2 = new Queue<int>();
        FindLeaves(root2, leaves2);

        if (leaves1.Count != leaves2.Count)
        {
            return false;
        }

        while (leaves1.Count > 0)
        {
            if (leaves1.Dequeue() != leaves2.Dequeue())
            {
                return false;
            }
        }

        return true;
    }

    public void FindLeaves(TreeNode currNode, Queue<int> leaves)
    {
        // leaf => add to queue
        if (currNode.left == null && currNode.right == null)
        {
            leaves.Enqueue(currNode.val);
            return;
        }

        // recur
        if (currNode.left != null)
        {
            FindLeaves(currNode.left, leaves);
        }
        if (currNode.right != null)
        {
            FindLeaves(currNode.right, leaves);
        }
    }
}