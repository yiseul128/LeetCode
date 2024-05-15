using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _199.Binary_Tree_Right_Side_View
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
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> rightSide = new List<int>();
            if (root == null)
            {
                return rightSide;
            }

            Queue<TreeNode> q1 = new Queue<TreeNode>();
            q1.Enqueue(root);
            Queue<TreeNode> q2 = new Queue<TreeNode>();

            RecurRightSideView(q1, q2, rightSide, true);

            return rightSide;
        }

        public void RecurRightSideView(Queue<TreeNode> q1, Queue<TreeNode> q2, IList<int> rightSide, bool isQ1Turn)
        {
            if (q1.Count == 0 && q2.Count == 0)
            {
                return;
            }

            TreeNode currNode = null;
            if (isQ1Turn)
            {
                currNode = q1.Dequeue();

                if (currNode.left != null)
                {
                    q2.Enqueue(currNode.left);
                }
                if (currNode.right != null)
                {
                    q2.Enqueue(currNode.right);
                }

                if (q1.Count == 0)
                {
                    isQ1Turn = !isQ1Turn;
                    rightSide.Add(currNode.val);
                }
            }
            else
            {
                currNode = q2.Dequeue();

                if (currNode.left != null)
                {
                    q1.Enqueue(currNode.left);
                }
                if (currNode.right != null)
                {
                    q1.Enqueue(currNode.right);
                }

                if (q2.Count == 0)
                {
                    isQ1Turn = !isQ1Turn;
                    rightSide.Add(currNode.val);
                }
            }

            RecurRightSideView(q1, q2, rightSide, isQ1Turn);
        }
    }
}
