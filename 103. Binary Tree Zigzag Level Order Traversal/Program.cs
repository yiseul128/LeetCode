using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103.Binary_Tree_Zigzag_Level_Order_Traversal
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
        public Dictionary<int, List<int>> levels = new Dictionary<int, List<int>>();

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> answer = new List<IList<int>>();

            // build levels dictionary
            Traverse(root, 0);

            // create answer list
            for (int i = 0; i < levels.Count; i++)
            {
                // even
                if (i % 2 == 0)
                {
                    answer.Add(levels[i]);
                }
                // odd => reverse
                else
                {
                    levels[i].Reverse();
                    answer.Add(levels[i]);
                }
            }

            return answer;
        }

        public void Traverse(TreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (!levels.ContainsKey(level))
            {
                levels.Add(level, new List<int>());
            }
            levels[level].Add(node.val);

            if (node.left != null)
            {
                Traverse(node.left, level + 1);
            }
            if (node.right != null)
            {
                Traverse(node.right, level + 1);
            }
        }
    }
}
