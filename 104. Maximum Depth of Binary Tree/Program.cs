using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104.Maximum_Depth_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
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
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return RecurMaxDepth(root, 1);
        }

        public int RecurMaxDepth(TreeNode currNode, int depth)
        {
            int max = depth;
            if (currNode.left != null)
            {
                int leftDepth = RecurMaxDepth(currNode.left, depth + 1);
                max = max > leftDepth ? max : leftDepth;
            }
            if (currNode.right != null)
            {
                int rightDepth = RecurMaxDepth(currNode.right, depth + 1);
                max = max > rightDepth ? max : rightDepth;
            }

            return max;
        }

        //public int MaxDepth(TreeNode root)
        //{
        //    if (root == null)
        //    {
        //        return 0;
        //    }

        //    return RecurMaxDepth(root);

        //}

        //public int RecurMaxDepth(TreeNode node)
        //{
        //    if (node.left == null && node.right == null)
        //    {
        //        return 1;
        //    }

        //    int right = 0;
        //    int left = 0;
        //    if (node.left != null)
        //    {
        //        left += RecurMaxDepth(node.left);
        //    }
        //    if (node.right != null)
        //    {
        //        right += RecurMaxDepth(node.right);
        //    }

        //    int depth = left > right ? left : right;
        //    depth++;
        //    return depth;
        //}
    }
}
