using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83.Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /* Definition for singly-linked list.  */
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
        public ListNode DeleteDuplicates(ListNode head)
        {

            if (head == null)
            {
                return head;
            }

            ListNode answer = head;

            int prev = head.val;
            ListNode prevNode = head;
            head = head.next;
            while (head != null)
            {
                //Console.WriteLine(head.val + ", " + prev);
                if (head.val == prev)
                {
                    head = head.next;
                    prevNode.next = head;
                }
                else
                {
                    prev = head.val;
                    prevNode = head;
                    head = head.next;
                }
            }

            return answer;
        }
    }
}
