using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102.Binary_Tree_Level_Order_Traversal
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


    //using System.Linq;

    public class Solution
    {
        List<IList<int>> answer = new List<IList<int>>();

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            RecurLevelOrder(root, 1);
            return answer;
        }

        public void RecurLevelOrder(TreeNode node, int i)
        {
            if (node == null)
            {
                return;
            }

            if (answer.Count < i)
            {
                answer.Add(new List<int>());
            }
            answer.ElementAt(i - 1).Add(node.val);

            if (node.left != null)
            {
                RecurLevelOrder(node.left, i + 1);
            }
            if (node.right != null)
            {
                RecurLevelOrder(node.right, i + 1);
            }

        }
    }
}
