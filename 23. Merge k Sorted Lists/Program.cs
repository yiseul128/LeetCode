using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Merge_k_Sorted_Lists
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            //empty list
            if (lists.Length == 0)
            {
                return null;
            }

            //one list
            ListNode head = lists[0];
            if (lists.Length == 1)
            {
                return head;
            }

            Stack<ListNode> heads1 = new Stack<ListNode>();
            Stack<ListNode> heads2 = new Stack<ListNode>();
            bool one = true;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    heads1.Push(lists[i]);
                }
            }

            //empty lists
            if (heads1.Count == 0 && heads2.Count == 0)
            {
                return lists[0];
            }

            while (heads1.Count != 1 && heads2.Count != 1)
            {

                //1 => 2
                if (one)
                {
                    while (heads1.Count > 1)
                    {
                        ListNode l1 = heads1.Pop();
                        ListNode l2 = heads1.Pop();
                        heads2.Push(MergeTwoLists(l1, l2));
                    }

                    if (heads1.Count == 1)
                    {
                        heads2.Push(heads1.Pop());
                    }
                }
                //2 => 1
                else
                {
                    while (heads2.Count > 1)
                    {
                        ListNode l1 = heads2.Pop();
                        ListNode l2 = heads2.Pop();
                        heads1.Push(MergeTwoLists(l1, l2));
                    }

                    if (heads2.Count == 1)
                    {
                        heads1.Push(heads2.Pop());
                    }
                }
                one = !one;
            }

            if (heads1.Count == 1)
            {
                return heads1.Pop();
            }
            return heads2.Pop();
        }

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
