using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94.Binary_Tree_Inorder_Traversal
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
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> nodes = new List<int>();

            Tranverse(root, nodes);

            return nodes;
        }

        public void Tranverse(TreeNode n, List<int> nodes)
        {
            if (n == null)
            {
                return;
            }

            Tranverse(n.left, nodes);
            nodes.Add(n.val);
            Tranverse(n.right, nodes);
        }
    }
}
