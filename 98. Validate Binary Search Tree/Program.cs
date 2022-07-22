using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98.Validate_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /* [5,1,8,null,null,6,9]
            TreeNode n1 = new TreeNode(5);
            TreeNode n2 = new TreeNode(1);
            TreeNode n3 = new TreeNode(8);
            TreeNode n4 = new TreeNode(6);
            TreeNode n5 = new TreeNode(9);

            n1.left = n2;
            n1.right = n3;
            n3.left = n4;
            n3.right = n5; 

            */

            /*[34,-6,null,-21]
            TreeNode n1 = new TreeNode(34);
            TreeNode n2 = new TreeNode(-6);
            TreeNode n3 = new TreeNode(-21);

            n1.left = n2;
            n2.left = n3;
            */

            // [-59,null,49,null,78]

            TreeNode n1 = new TreeNode(-59);
            TreeNode n2 = new TreeNode(49);
            TreeNode n3 = new TreeNode(78);

            n1.right = n2;
            n2.right = n3;

            Solution s = new Solution();
            s.IsValidBST(n1);
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
        bool valid = true;

        public bool IsValidBST(TreeNode root)
        {

            int[] minmax = { root.val, root.val };
            IsValidNode(root, minmax);

            return valid;
        }

        public int[] IsValidNode(TreeNode node, int[] mm)
        {
            if (!valid)
            {
                return mm;
            }

            //both null (leaf)
            if (node.right == null && node.left == null)
            {
                mm[0] = node.val;
                mm[1] = node.val;
                return mm;
            }

            int[] right = { mm[0], mm[1] };
            if (node.right != null)
            {
                if (node.val < node.right.val)
                {
                    IsValidNode(node.right, right);

                    if (right[0] <= node.val)
                    {
                        valid = false;
                        return mm;
                    }

                    mm[1] = right[1]; //max

                    if (node.left == null)
                    {
                        mm[0] = right[0];
                    }
                }
                else
                {
                    valid = false;
                    return mm;
                }
            }

            int[] left = { mm[0], mm[1] };
            if (node.left != null)
            {
                if (node.val > node.left.val)
                {
                    IsValidNode(node.left, left);

                    if (left[1] >= node.val)
                    {
                        valid = false;
                        return mm;
                    }

                    mm[0] = left[0]; //min

                    if (node.right == null)
                    {
                        mm[1] = left[1];
                    }
                }
                else
                {
                    valid = false;
                    return mm;
                }
            }

            return mm;

        }
    }
}
