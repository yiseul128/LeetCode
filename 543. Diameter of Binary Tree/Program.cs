using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _543.Diameter_of_Binary_Tree
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
        int diameter = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            FindDiameter(root, 0);
            return diameter;
        }

        public int FindDiameter(TreeNode currNode, int currDepth)
        {
            if (currNode.left == null && currNode.right == null)
            {
                return currDepth;
            }

            // left
            int leftDepth = 0;
            if (currNode.left != null)
            {
                leftDepth = FindDiameter(currNode.left, currDepth + 1);
            }

            // right
            int rightDepth = 0;
            if (currNode.right != null)
            {
                rightDepth = FindDiameter(currNode.right, currDepth + 1);
            }

            // check
            int newDiameter = leftDepth + rightDepth - currDepth * 2;
            diameter = diameter > newDiameter ? diameter : newDiameter;

            return leftDepth > rightDepth ? leftDepth : rightDepth;
        }
    }
}
