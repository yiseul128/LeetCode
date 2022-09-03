using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _148.Sort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            ListNode n1 = new ListNode(4);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(1);
            ListNode n4 = new ListNode(3);
            ListNode n5 = new ListNode(-1);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            s.SortList(n1);

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
        public ListNode SortList(ListNode head)
        {

            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode n = head;

            Stack<Queue<int>> s1 = new Stack<Queue<int>>();
            Stack<Queue<int>> s2 = new Stack<Queue<int>>();

            while (n != null)
            {
                Queue<int> q = new Queue<int>();
                if (n != null)
                {
                    int n1 = n.val;
                    n = n.next;
                    if (n != null)
                    {
                        int n2 = n.val;

                        if (n2 > n1)
                        {
                            q.Enqueue(n1);
                            q.Enqueue(n2);
                        }
                        else
                        {
                            q.Enqueue(n2);
                            q.Enqueue(n1);
                        }

                        n = n.next;
                    }
                    else
                    {
                        q.Enqueue(n1);
                    }
                }
                s1.Push(q);
            }

            if (s1.Count == 1)
            {
                int n1 = head.val;
                int n2 = head.next.val;

                if (n1 > n2)
                {
                    head.val = n2;
                    head.next.val = n1;
                }
                return head;
            }

            bool turn = false;
            while (true)
            {
                if (turn)
                {
                    //s2 => s1
                    Queue<int> lq = s2.Pop();

                    if (s2.Count == 0)
                    {
                        s1.Push(lq);
                        turn = !turn;
                        continue;
                    }
                    Queue<int> rq = s2.Pop();

                    Queue<int> merged = new Queue<int>();
                    while (lq.Count != 0 || rq.Count != 0)
                    {
                        if (lq.Count != 0)
                        {
                            if (rq.Count != 0)
                            {
                                if (lq.Peek() < rq.Peek())
                                {
                                    merged.Enqueue(lq.Dequeue());
                                }
                                else
                                {
                                    merged.Enqueue(rq.Dequeue());
                                }
                            }
                            else
                            {
                                while (lq.Count != 0)
                                {
                                    merged.Enqueue(lq.Dequeue());
                                }
                            }
                        }
                        else
                        {
                            while (rq.Count != 0)
                            {
                                merged.Enqueue(rq.Dequeue());
                            }
                        }
                    }

                    s1.Push(merged);
                    if (s2.Count == 0)
                    {
                        if (s1.Count == 1)
                        {
                            Queue<int> sorted = s1.Pop();
                            ListNode walk = head;
                            while (sorted.Count != 0)
                            {
                                walk.val = sorted.Dequeue();
                                walk = walk.next;
                            }
                            return head;
                        }
                        turn = !turn;
                    }
                }
                else
                {
                    //s1 => s2
                    Queue<int> lq = s1.Pop();

                    if (s1.Count == 0)
                    {
                        s2.Push(lq);
                        turn = !turn;
                        continue;
                    }
                    Queue<int> rq = s1.Pop();

                    Queue<int> merged = new Queue<int>();
                    while (lq.Count != 0 || rq.Count != 0)
                    {
                        if (lq.Count != 0)
                        {
                            if (rq.Count != 0)
                            {
                                if (lq.Peek() < rq.Peek())
                                {
                                    merged.Enqueue(lq.Dequeue());
                                }
                                else
                                {
                                    merged.Enqueue(rq.Dequeue());
                                }
                            }
                            else
                            {
                                while (lq.Count != 0)
                                {
                                    merged.Enqueue(lq.Dequeue());
                                }
                            }
                        }
                        else
                        {
                            while (rq.Count != 0)
                            {
                                merged.Enqueue(rq.Dequeue());
                            }
                        }
                    }

                    s2.Push(merged);

                    if (s1.Count == 0)
                    {
                        if (s2.Count == 1)
                        {
                            Queue<int> sorted = s2.Pop();
                            ListNode walk = head;
                            while (sorted.Count != 0)
                            {
                                walk.val = sorted.Dequeue();
                                walk = walk.next;
                            }
                            return head;
                        }
                        turn = !turn;
                    }
                }
            }

            return head;
        }
    }
}
