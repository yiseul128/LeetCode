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

            ListNode prevOne = head;
            ListNode currOne = head.next;
            ListNode nextOne;
            prevOne.next = null; //handle head

            while (currOne.next != null)
            {
                nextOne = currOne.next;
                currOne.next = prevOne;

                prevOne = currOne;
                currOne = nextOne;
            }

            currOne.next = prevOne; //handle tail

            return currOne;

        }
    }
}
