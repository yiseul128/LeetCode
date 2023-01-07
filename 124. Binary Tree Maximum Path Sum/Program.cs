using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124.Binary_Tree_Maximum_Path_Sum
{
    internal class Program
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
        int max;
        Dictionary<TreeNode, int> maxPerNode;

        public int MaxPathSum(TreeNode root)
        {
            maxPerNode = new Dictionary<TreeNode, int>();
            max = root.val;

            FindMax(root, 0, 0);

            return max;
        }

        public int FindMax(TreeNode node, int sum, int currMax)
        {
            sum += node.val;

            int rightMax = 0;
            int leftMax = 0;
            if (node.left != null)
            {
                leftMax = FindMax(node.left, 0, 0);
            }
            if (node.right != null)
            {
                rightMax = FindMax(node.right, 0, 0);
            }

            if (leftMax < 0)
            {
                leftMax = 0;
            }
            if (rightMax < 0)
            {
                rightMax = 0;
            }

            int thisMax = leftMax + rightMax + node.val;
            max = max > thisMax ? max : thisMax;
            // Console.WriteLine(leftMax+", " +rightMax+", "+node.val);

            if (rightMax > leftMax)
            {
                return sum + rightMax;
            }
            else
            {
                return sum + leftMax;
            }

            return sum;
        }
    }
}
