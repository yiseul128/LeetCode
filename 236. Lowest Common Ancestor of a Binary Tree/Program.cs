using System;
using System.Collections.Generic;

namespace _236._Lowest_Common_Ancestor_of_a_Binary_Tree
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
        public TreeNode(int x) { val = x; }
    }
 
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> stackP = new Stack<TreeNode>();
            RecurSearch(root, p, stackP);

            Stack<TreeNode> stackQ = new Stack<TreeNode>();
            RecurSearch(root, q, stackQ);

            Stack<TreeNode> fromRootToP = new Stack<TreeNode>();
            Stack<TreeNode> fromRootToQ = new Stack<TreeNode>();
            while (stackP.Count > 0 || stackQ.Count > 0)
            {
                if (stackP.Count > 0)
                {
                    fromRootToP.Push(stackP.Pop());
                }

                if (stackQ.Count > 0)
                {
                    fromRootToQ.Push(stackQ.Pop());
                }
            }

            TreeNode answer = null;
            while (fromRootToP.Count > 0 && fromRootToQ.Count > 0)
            {
                TreeNode ancestorP = fromRootToP.Pop();
                TreeNode ancestorQ = fromRootToQ.Pop();
                if (ancestorP.val == ancestorQ.val)
                {
                    answer = ancestorQ;
                }
                else
                {
                    break;
                }
            }

            return answer;
        }

        public bool RecurSearch(TreeNode currNode, TreeNode target, Stack<TreeNode> stack)
        {
            stack.Push(currNode);

            if (currNode.val == target.val)
            {
                return true;
            }

            if (currNode.left != null)
            {
                if (RecurSearch(currNode.left, target, stack))
                {
                    return true;
                }
            }
            if (currNode.right != null)
            {
                if (RecurSearch(currNode.right, target, stack))
                {
                    return true;
                }
            }

            stack.Pop();

            return false;
        }

        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    Stack<TreeNode> pathToQ = new Stack<TreeNode>();
        //    Stack<TreeNode> pathToP = new Stack<TreeNode>();

        //    FindPathToNode(root, p, pathToP);
        //    FindPathToNode(root, q, pathToQ);

        //    TreeNode ancestor = root;
        //    while (pathToP.Count != 0 && pathToQ.Count != 0)
        //    {
        //        TreeNode poppedP = pathToP.Pop();
        //        TreeNode poppedQ = pathToQ.Pop();
        //        //Console.WriteLine("P: " + poppedP.val + ", Q: " + poppedQ.val);
        //        if (poppedP.val != poppedQ.val)
        //        {
        //            break;
        //        }
        //        ancestor = poppedP;
        //    }

        //    return ancestor;
        //}

        //private bool FindPathToNode(TreeNode current, TreeNode target, Stack<TreeNode> path)
        //{
        //    // leaf
        //    if (current == null)
        //    {
        //        return false;
        //    }

        //    // found target
        //    if (current.val == target.val)
        //    {
        //        path.Push(current);
        //        return true;
        //    }

        //    // adding path
        //    if (FindPathToNode(current.left, target, path) || FindPathToNode(current.right, target, path))
        //    {
        //        path.Push(current);
        //        return true;
        //    }

        //    return false;
        //}
    }
}