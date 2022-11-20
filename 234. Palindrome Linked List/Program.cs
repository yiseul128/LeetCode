using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234.Palindrome_Linked_List
{
    internal class Program
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
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> firstHalf = new Stack<int>();

            int count = 0;
            ListNode walk = head;
            while (walk != null)
            {
                walk = walk.next;
                count++;
            }

            Console.WriteLine(count);

            walk = head;
            for (int i = 0; i < count / 2; i++)
            {
                firstHalf.Push(walk.val);
                walk = walk.next;
            }

            if (count % 2 == 1)
            {
                walk = walk.next;
            }

            while (walk != null)
            {
                // Console.WriteLine("walk: " + walk.val + ", first: " + firstHalf.Peek());
                if (firstHalf.Pop() != walk.val)
                {
                    return false;
                }
                walk = walk.next;
            }

            return true;
        }
    }
}
