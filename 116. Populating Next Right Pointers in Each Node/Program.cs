using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116.Populating_Next_Right_Pointers_in_Each_Node
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            if (root.left != null)
            {
                ConnectRecur(root.left, root, true);
            }
            if (root.right != null)
            {
                ConnectRecur(root.right, root, false);
            }

            return root;
        }

        public void ConnectRecur(Node n, Node p, bool left)
        {
            //n is left node
            if (left)
            {
                n.next = p.right;
            }
            else
            {
                //n is right node
                if (p.next != null)
                {
                    n.next = p.next.left;
                }
            }

            //recur
            if (n.left != null)
            {
                ConnectRecur(n.left, n, true);
            }
            if (n.right != null)
            {
                ConnectRecur(n.right, n, false);
            }

        }
    }
}
