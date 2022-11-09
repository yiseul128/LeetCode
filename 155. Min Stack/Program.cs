using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155.Min_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MinStack
    {

        private SortedDictionary<int, int> stackDict;
        private Stack<int> stack;

        public MinStack()
        {
            stackDict = new SortedDictionary<int, int>();
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (stackDict.ContainsKey(val))
            {
                stackDict[val]++;
            }
            else
            {
                stackDict.Add(val, 1);
            }

            stack.Push(val);
        }

        public void Pop()
        {
            int popped = stack.Pop();

            if (stackDict[popped] == 1)
            {
                stackDict.Remove(popped);
            }
            else
            {
                stackDict[popped]--;
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return stackDict.ElementAt(0).Key;
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
