using System;
using System.Collections.Generic;

namespace _236._Lowest_Common_Ancestor_of_a_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /* Definition for a binary tree node. */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
 
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> pathToQ = new Stack<TreeNode>();
            Stack<TreeNode> pathToP = new Stack<TreeNode>();

            FindPathToNode(root, p, pathToP);
            FindPathToNode(root, q, pathToQ);

            TreeNode ancestor = root;
            while (pathToP.Count != 0 && pathToQ.Count != 0)
            {
                TreeNode poppedP = pathToP.Pop();
                TreeNode poppedQ = pathToQ.Pop();
                //Console.WriteLine("P: " + poppedP.val + ", Q: " + poppedQ.val);
                if (poppedP.val != poppedQ.val)
                {
                    break;
                }
                ancestor = poppedP;
            }

            return ancestor;
        }

        private bool FindPathToNode(TreeNode current, TreeNode target, Stack<TreeNode> path)
        {
            // leaf
            if (current == null)
            {
                return false;
            }

            // found target
            if (current.val == target.val)
            {
                path.Push(current);
                return true;
            }

            // adding path
            if (FindPathToNode(current.left, target, path) || FindPathToNode(current.right, target, path))
            {
                path.Push(current);
                return true;
            }

            return false;
        }
    }
}