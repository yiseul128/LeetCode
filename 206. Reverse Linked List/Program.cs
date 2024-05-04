using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206.Reverse_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode prevNode = head;
            ListNode currNode = head.next;
            head.next = null;

            // return IterativeReverseList(currNode, prevNode);
            return RecursiveReverseList(currNode, prevNode);
        }

        public ListNode IterativeReverseList(ListNode currNode, ListNode prevNode)
        {
            while (currNode != null)
            {
                ListNode nextNode = currNode.next;
                currNode.next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }

            return prevNode;
        }

        public ListNode RecursiveReverseList(ListNode currNode, ListNode prevNode)
        {
            if (currNode == null)
            {
                return prevNode;
            }

            ListNode nextNode = currNode.next;
            currNode.next = prevNode;
            prevNode = currNode;
            currNode = nextNode;

            return RecursiveReverseList(currNode, prevNode);
        }
    }
}
