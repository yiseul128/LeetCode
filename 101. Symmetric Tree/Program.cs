using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101.Symmetric_Tree
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
        public bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }

            if (root.left == null || root.right == null)
            {
                return false;
            }

            TreeNode l = root.left;
            TreeNode r = root.right;
            if (l.val != r.val)
            {
                return false;
            }

            //recur
            return IsNodeSymmetric(l, r);
        }

        public bool IsNodeSymmetric(TreeNode l, TreeNode r)
        {
            bool symmetric = true;

            //l.right, r.left
            if (l.right != null && r.left != null)
            {
                //both with val
                if (l.right.val != r.left.val)
                {
                    symmetric = false;
                }
                else
                {
                    //recur 
                    if (!IsNodeSymmetric(l.right, r.left))
                    {
                        symmetric = false;
                    }
                }
            }
            else if (l.right != null || r.left != null)
            {
                //one with val, one without val
                symmetric = false;
            }

            //l.left, r.right
            if (l.left != null && r.right != null)
            {
                //both with val
                if (l.left.val != r.right.val)
                {
                    symmetric = false;
                }
                else
                {
                    //recur 
                    if (!IsNodeSymmetric(l.left, r.right))
                    {
                        symmetric = false;
                    }
                }
            }
            else if (l.left != null || r.right != null)
            {
                //one with val, one without val
                symmetric = false;
            }

            return symmetric;
        }




    }
}
