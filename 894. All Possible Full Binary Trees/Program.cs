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
    public IList<TreeNode> AllPossibleFBT(int n)
    {
        IList<TreeNode> answer = new List<TreeNode>();

        if (n == 1)
        {
            answer.Add(new TreeNode());
            return answer;
        }

        n -= 1;

        for (int i = 1; i < n; i += 2)
        {
            IList<TreeNode> left = AllPossibleFBT(i);
            IList<TreeNode> right = AllPossibleFBT(n - i);
            foreach (TreeNode leftNode in left)
            {
                foreach (TreeNode rightNode in right)
                {
                    TreeNode currNode = new TreeNode();
                    currNode.left = leftNode;
                    currNode.right = rightNode;
                    answer.Add(currNode);
                }
            }
        }
        return answer;
    }
}