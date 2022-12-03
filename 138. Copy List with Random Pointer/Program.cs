using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138.Copy_List_with_Random_Pointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /* Definition for a Node. */
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node newHead = new Node(head.val);
            Dictionary<Node, Node> oldNewNodes = new Dictionary<Node, Node>();

            Node prevNew = newHead;
            Node currOld = head.next;

            oldNewNodes.Add(head, newHead);
            while (currOld != null)
            {
                // create new node
                Node currNew = new Node(currOld.val);
                // build oldNewNodes
                oldNewNodes.Add(currOld, currNew);
                // put next
                prevNew.next = currNew;
                // replace prevNew
                prevNew = currNew;
                // walk currOld
                currOld = currOld.next;
            }

            // connect random pointers
            currOld = head;
            while (currOld != null)
            {
                // Console.WriteLine(currOld == null ? "null":currOld.val);
                if (currOld.random != null)
                {
                    oldNewNodes[currOld].random = oldNewNodes[currOld.random];
                }
                currOld = currOld.next;
            }

            return newHead;
        }
    }
}
