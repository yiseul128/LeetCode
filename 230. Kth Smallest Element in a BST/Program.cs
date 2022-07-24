using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230.Kth_Smallest_Element_in_a_BST
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
        /*
        [45,30,46,10,36,null,49,8,24,34,42,48,null,4,9,14,25,31,35,41,43,47,null,0,6,null,null,11,20,null,28,null,33,null,null,37,null,null,44,null,null,null,1,5,7,null,12,19,21,26,29,32,null,null,38,null,null,null,3,null,null,null,null,null,13,18,null,null,22,null,27,null,null,null,null,null,39,2,null,null,null,15,null,null,23,null,null,null,40,null,null,null,16,null,null,null,null,null,17]
    32
        */

        Queue<TreeNode> sorted = new Queue<TreeNode>();

        public int KthSmallest(TreeNode root, int k)
        {
            Sort(root);

            for (int i = 1; i < k; i++)
            {
                sorted.Dequeue();
            }

            return sorted.Dequeue().val;
        }

        public void Sort(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                sorted.Enqueue(node);
                return;
            }

            if (node.left != null)
            {
                Sort(node.left);
            }

            sorted.Enqueue(node);

            if (node.right != null)
            {
                Sort(node.right);
            }


        }
    }
}
