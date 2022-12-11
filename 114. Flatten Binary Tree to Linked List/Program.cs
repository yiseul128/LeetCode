using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114.Flatten_Binary_Tree_to_Linked_List
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
        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Move(root);
        }

        public TreeNode Move(TreeNode n)
        {
            if (n.left == null && n.right == null)
            {
                return n;
            }

            TreeNode leftLast = null;
            TreeNode rightLast = null;
            if (n.left != null)
            {
                // get last node of left
                leftLast = Move(n.left);

                if (n.right == null)
                {
                    // just put left node to right
                    n.right = n.left;
                    n.left = null;
                    return leftLast;
                }
                else
                {
                    // get last node of right
                    rightLast = Move(n.right);
                    TreeNode tmpRight = n.right;
                    // put left node to right
                    n.right = n.left;
                    n.left = null;
                    // connect left last and curr right
                    leftLast.right = tmpRight;
                    return rightLast;
                }
            }
            else
            {
                return Move(n.right);
            }

        }
    }
}
