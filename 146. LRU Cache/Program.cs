using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _146.LRU_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class DLL
    {
        public Node head = null;
        public Node tail = null;

        public void Print()
        {
            Node curr = head;
            while (curr != null)
            {
                Console.Write("(" + curr.key + ", " + curr.val + ") ");
                curr = curr.next;
            }
            Console.WriteLine();
        }

        public void AddLast(Node n)
        {
            if (tail == null)
            {
                head = n;
                tail = n;
                return;
            }

            tail.next = n;
            n.prev = tail;
            n.next = null;
            tail = n;
        }

        public Node RemoveFirst()
        {
            Node n = head;

            if (head.next != null)
            {
                head.next.prev = null;
                head = head.next;
            }
            else
            {
                head = null;
                tail = null;
            }

            return n;
        }

        public void Relocate(Node n)
        {
            if (n.next == null)
            {
                return;
            }

            n.next.prev = n.prev;

            if (n.prev == null)
            {
                head = n.next;
            }
            else
            {
                n.prev.next = n.next;
            }

            tail.next = n;
            n.prev = tail;
            n.next = null;
            tail = n;
        }
    }

    public class Node
    {
        public int val;
        public int key;
        public Node prev;
        public Node next;

        public Node(int k, int v)
        {
            key = k;
            val = v;
        }
    }

    public class LRUCache
    {

        Dictionary<int, Node> cache = new Dictionary<int, Node>();
        DLL usedKeys = new DLL();
        int cap = 0;

        public LRUCache(int capacity)
        {
            cap = capacity;
        }

        public int Get(int key)
        {
            // Console.WriteLine("get " + key);

            if (cache.ContainsKey(key))
            {
                usedKeys.Relocate(cache[key]);
                return cache[key].val;
            }
            //usedKeys.Print();
            return -1;
        }

        public void Put(int key, int value)
        {
            //Console.WriteLine("put " + key);

            if (cache.ContainsKey(key))
            {
                cache[key].val = value;
                usedKeys.Relocate(cache[key]);
            }
            else
            {
                if (cache.Count == cap)
                {
                    Node nodeToRemove = usedKeys.RemoveFirst();
                    cache.Remove(nodeToRemove.key);    
                }
                Node newNode = new Node(key, value);
                usedKeys.AddLast(newNode);
                cache.Add(key, newNode);
                //usedKeys.Print();
            }

            // usedKeys.AddLast(key);


        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
