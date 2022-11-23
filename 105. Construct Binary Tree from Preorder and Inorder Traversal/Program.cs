using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105.Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
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
        private Dictionary<int, int> inorderMap = new Dictionary<int, int>(); //val, idx
        private int count = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {

            for (int i = 0; i < inorder.Length; i++)
            {
                inorderMap.Add(inorder[i], i);
            }

            return AddNode(preorder, 0, inorder.Length - 1);
        }

        public TreeNode AddNode(int[] preorder, int startI, int endI)
        {
            if (startI > endI)
            {
                return null;
            }

            int newVal = preorder[count++];
            TreeNode newNode = new TreeNode(newVal);

            newNode.left = AddNode(preorder, startI, inorderMap[newVal] - 1);
            newNode.right = AddNode(preorder, inorderMap[newVal] + 1, endI);

            return newNode;
        }
    }
}
