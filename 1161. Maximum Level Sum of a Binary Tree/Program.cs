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
    public int MaxLevelSum(TreeNode root)
    {
        Queue<TreeNode> q1 = new Queue<TreeNode>();
        q1.Enqueue(root);
        Queue<TreeNode> q2 = new Queue<TreeNode>();
        return RecurMaxLevelSum(q1, q2, 0, root.val, 1, 1, true);
    }

    public int RecurMaxLevelSum(Queue<TreeNode> q1, Queue<TreeNode> q2, int currSum, int max, int currLevel, int maxLevel, bool isQ1Turn)
    {
        if (q1.Count == 0 && q2.Count == 0)
        {
            return maxLevel;
        }

        TreeNode currNode = null;
        if (isQ1Turn)
        {
            currNode = q1.Dequeue();
            currSum += currNode.val;

            if (currNode.left != null)
            {
                q2.Enqueue(currNode.left);
            }
            if (currNode.right != null)
            {
                q2.Enqueue(currNode.right);
            }

            if (q1.Count == 0)
            {
                isQ1Turn = !isQ1Turn;

                if (max < currSum)
                {
                    maxLevel = currLevel;
                    max = currSum;
                }

                currSum = 0;
                currLevel++;
            }
        }
        else
        {
            currNode = q2.Dequeue();
            currSum += currNode.val;

            if (currNode.left != null)
            {
                q1.Enqueue(currNode.left);
            }
            if (currNode.right != null)
            {
                q1.Enqueue(currNode.right);
            }

            if (q2.Count == 0)
            {
                isQ1Turn = !isQ1Turn;

                if (max < currSum)
                {
                    maxLevel = currLevel;
                    max = currSum;
                }

                currSum = 0;
                currLevel++;
            }
        }

        return RecurMaxLevelSum(q1, q2, currSum, max, currLevel, maxLevel, isQ1Turn);
    }
}