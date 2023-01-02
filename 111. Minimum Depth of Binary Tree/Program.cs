using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111.Minimum_Depth_of_Binary_Tree
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
        public int MinDepth(TreeNode root)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();

            int minDepth = 0;
            if (root == null)
            {
                return minDepth;
            }

            bool useQ1 = true;
            q1.Enqueue(root);
            while (true)
            {
                TreeNode currNode = null;
                minDepth++;
                if (useQ1)
                {
                    while (q1.Count != 0)
                    {
                        currNode = q1.Dequeue();
                        // Console.WriteLine(currNode.val);
                        if (currNode.right == null && currNode.left == null)
                        {
                            return minDepth;
                        }

                        if (currNode.right != null)
                        {
                            q2.Enqueue(currNode.right);
                        }
                        if (currNode.left != null)
                        {
                            q2.Enqueue(currNode.left);
                        }
                    }
                }
                else
                {
                    while (q2.Count != 0)
                    {
                        currNode = q2.Dequeue();
                        // Console.WriteLine(currNode.val);
                        if (currNode.right == null && currNode.left == null)
                        {
                            return minDepth;
                        }

                        if (currNode.right != null)
                        {
                            q1.Enqueue(currNode.right);
                        }
                        if (currNode.left != null)
                        {
                            q1.Enqueue(currNode.left);
                        }
                    }
                }
                useQ1 = !useQ1;
            }

            return minDepth;
        }
    }
}
