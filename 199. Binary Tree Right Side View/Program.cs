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
            IList<int> answer = new List<int>();

            // n of nodes = 0
            if (root == null)
            {
                return answer;
            }
            // n of nodes = 1
            if (root.left == null && root.right == null)
            {
                answer.Add(root.val);
                return answer;
            }

            // regular
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            Queue<int> depths = new Queue<int>();

            nodes.Enqueue(root);
            depths.Enqueue(0);
            TreeNode currNode = null;
            TreeNode prevNode = root;
            int currDepth = -1;
            int currLevel = 0;
            while (nodes.Count != 0)
            {
                currNode = nodes.Dequeue();
                currDepth = depths.Dequeue();

                if (currNode.left != null)
                {
                    nodes.Enqueue(currNode.left);
                    depths.Enqueue(currDepth + 1);
                }
                if (currNode.right != null)
                {
                    nodes.Enqueue(currNode.right);
                    depths.Enqueue(currDepth + 1);
                }

                if (currLevel != currDepth)
                {
                    answer.Add(prevNode.val);
                }
                currLevel = currDepth;
                prevNode = currNode;
                // Console.WriteLine(currNode.val);
            }
            answer.Add(currNode.val);

            return answer;
        }
    }
}
