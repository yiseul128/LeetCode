using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226.Invert_Binary_Tree
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
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            InvertNode(root);
            return root;
        }

        public void InvertNode(TreeNode node)
        {

            //invert
            TreeNode temp = node.right;
            node.right = node.left;
            node.left = temp;

            //recur
            if (node.left != null)
            {
                InvertNode(node.left);
            }
            if (node.right != null)
            {
                InvertNode(node.right);
            }
        }
    }
}
