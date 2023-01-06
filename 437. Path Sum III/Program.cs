using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _437.Path_Sum_III
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
        int answer = 0;
        HashSet<TreeNode> visited = new HashSet<TreeNode>();

        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return answer;
            }

            ExplorePaths(root, Convert.ToInt64(targetSum), 0);
            return answer;
        }

        public void ExplorePaths(TreeNode node, long targetSum, long sum)
        {
            sum += Convert.ToInt64(node.val);

            if (targetSum == sum)
            {
                // Console.WriteLine(node.val);
                answer++;
            }

            if (node.left != null)
            {
                ExplorePaths(node.left, targetSum, sum);
                if (!visited.Contains(node.left))
                {
                    visited.Add(node.left);
                    ExplorePaths(node.left, targetSum, 0);
                }
            }

            if (node.right != null)
            {
                ExplorePaths(node.right, targetSum, sum);
                if (!visited.Contains(node.right))
                {
                    visited.Add(node.right);
                    ExplorePaths(node.right, targetSum, 0);
                }
            }
        }
    }
}
