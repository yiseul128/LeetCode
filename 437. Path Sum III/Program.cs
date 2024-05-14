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
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0;
            }

            Dictionary<long, int> sums = new Dictionary<long, int>();
            sums.Add(0, 1);

            return RecurPathSum(root, targetSum, 0, sums);
        }

        public int RecurPathSum(TreeNode currNode, int targetSum, long currSum, Dictionary<long, int> sums)
        {
            int count = 0;

            currSum += currNode.val;

            // check matching target
            long prefix = currSum - targetSum;
            if (sums.ContainsKey(prefix))
            {
                count += sums[prefix];
            }

            // add currSum as prefix
            if (!sums.ContainsKey(currSum))
            {
                sums.Add(currSum, 1);
            }
            else
            {
                sums[currSum]++;
            }

            if (currNode.left != null)
            {
                count += RecurPathSum(currNode.left, targetSum, currSum, sums);
            }

            if (currNode.right != null)
            {
                count += RecurPathSum(currNode.right, targetSum, currSum, sums);
            }

            sums[currSum]--;

            // Console.WriteLine(currNode.val+", "+count);

            return count;
        }
    }
}
