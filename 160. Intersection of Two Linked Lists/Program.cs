using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160.Intersection_of_Two_Linked_Lists
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
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            ListNode a = headA;
            ListNode b = headB;

            int al = 0;
            int bl = 0;
            string strA = "";
            string strB = "";

            while (a != null)
            {
                al++;
                strA = a.val.ToString() + strA;
                a = a.next;
            }

            while (b != null)
            {
                bl++;
                strB = b.val.ToString() + strB;
                b = b.next;
            }

            if (strA[0] != strB[0])
            {
                return null;
            }

            int c = 0;
            int lim = al < bl ? al : bl;
            for (int i = 0; i < lim; i++)
            {
                c = i + 1;
                if (strA[i] != strB[i])
                {
                    break;
                }
            }

            int ac = al - c;
            for (int i = 0; i < ac; i++)
            {
                headA = headA.next;
            }

            int bc = bl - c;
            for (int i = 0; i < bc; i++)
            {
                headB = headB.next;
            }

            //check ref match
            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }

            return headA;
        }
    }
}
