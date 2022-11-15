using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108.Convert_Sorted_Array_to_Binary_Search_Tree
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
        public TreeNode SortedArrayToBST(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int rootIdx = (start + end + 1) / 2;
            TreeNode root = new TreeNode(nums[rootIdx]);

            AppendNode(nums, start, end, rootIdx, root);

            return root;
        }

        public void AppendNode(int[] nums, int start, int end, int prev, TreeNode parent)
        {
            // tilted to left
            if (prev == start)
            {
                return;
            }

            int leftIdx = (start + prev - 1) / 2 + (start + prev - 1) % 2;
            TreeNode left = new TreeNode(nums[leftIdx]);
            parent.left = left;
            AppendNode(nums, start, prev - 1, leftIdx, left);

            if (end != prev)
            {
                int rightIdx = (prev + 1 + end) / 2 + (prev + 1 + end) % 2;
                TreeNode right = new TreeNode(nums[rightIdx]);
                parent.right = right;
                AppendNode(nums, prev + 1, end, rightIdx, right);
            }

        }
    }
}
