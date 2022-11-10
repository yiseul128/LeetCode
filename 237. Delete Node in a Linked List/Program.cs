using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _237.Delete_Node_in_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /* Definition for singly-linked list. */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
 
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {

            ListNode nextNode = node.next;
            node.val = nextNode.val;

            // second last
            if (nextNode.next == null)
            {
                node.next = null;
                return;
            }

            // regular
            node.next = nextNode.next;

        }
    }
}
