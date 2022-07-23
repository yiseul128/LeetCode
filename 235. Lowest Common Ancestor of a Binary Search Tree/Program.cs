using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _235.Lowest_Common_Ancestor_of_a_Binary_Search_Tree
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
        public TreeNode(int x) { val = x; }
    }
 

    public class Solution
    {

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p == root || q == root)
            {
                return root;
            }

            string routeP = FindAncestor(root, p, "");
            string routeQ = FindAncestor(root, q, "");

            int len = routeP.Length < routeQ.Length ? routeP.Length : routeQ.Length;
            int count = 0;

            while (count < len)
            {
                if (routeP[count] != routeQ[count])
                {
                    break;
                }
                count++;
            }

            TreeNode ancestor = root;
            for (int i = 0; i < count; i++)
            {
                if (routeP[i] == 'l')
                {
                    ancestor = ancestor.left;
                }
                else
                {
                    ancestor = ancestor.right;
                }
            }


            return ancestor;
        }

        public string FindAncestor(TreeNode current, TreeNode target, string route)
        {
            if (current.left == null && current.right == null)
            {
                return "";
            }

            if (current.left != null)
            {
                if (current.left == target)
                {
                    return route + "l";
                }
                string left = FindAncestor(current.left, target, route + "l");
                if (left != "")
                {
                    return left;
                }
            }
            if (current.right != null)
            {
                if (current.right == target)
                {
                    return route + "r";
                }
                string right = FindAncestor(current.right, target, route + "r");
                if (right != "")
                {
                    return right;
                }
            }

            return "";
        }
    }
}
