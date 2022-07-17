using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100.Same_Tree
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if ((p == null && q != null) || (p != null && q == null))
            {
                return false;
            }

            return IsSameNode(p, q);
        }

        public bool IsSameNode(TreeNode n1, TreeNode n2)
        {
            if (n1.val == n2.val)
            {
                bool l = false;
                bool r = false;

                //check left
                if (n1.left != null && n2.left != null)
                {
                    l = IsSameNode(n1.left, n2.left);
                }
                else if (n1.left == null && n2.left == null)
                {
                    l = true;
                }
                else
                { //one null, one node
                    return false;
                }

                //check right
                if (n1.right != null && n2.right != null)
                {
                    r = IsSameNode(n1.right, n2.right);
                }
                else if (n1.right == null && n2.right == null)
                {
                    r = true;
                }
                else
                { //one null, one node
                    return false;
                }

                if (l && r)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
