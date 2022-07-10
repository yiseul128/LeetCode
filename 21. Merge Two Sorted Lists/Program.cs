using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Merge_Two_Sorted_Lists
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
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            //handle head
            ListNode head;
            if (list1.val < list2.val)
            {
                head = list1;
                list1 = list1.next;
            }
            else
            {
                head = list2;
                list2 = list2.next;
            }

            ListNode curNode = head;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    curNode.next = list1;
                    list1 = list1.next;

                }
                else
                {
                    curNode.next = list2;
                    list2 = list2.next;
                }
                curNode = curNode.next;
            }

            if (list1 != null)
            {
                curNode.next = list1;
            }
            if (list2 != null)
            {
                curNode.next = list2;
            }

            return head;

        }
    }
}
