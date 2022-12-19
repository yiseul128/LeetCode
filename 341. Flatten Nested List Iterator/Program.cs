using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _341.Flatten_Nested_List_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /* This is the interface that allows for creating nested lists.
       You should not implement it, or speculate about its implementation
    */
    public interface NestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }
    public class NestedIterator
    {
        Queue<int> flatList = new Queue<int>();

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            flattenList(nestedList);
        }

        public void flattenList(IList<NestedInteger> nestedList)
        {
            foreach (NestedInteger ni in nestedList)
            {
                if (ni.IsInteger())
                {
                    flatList.Enqueue(ni.GetInteger());
                }
                else
                {
                    flattenList(ni.GetList());
                }
            }
        }

        public bool HasNext()
        {
            if (flatList.Count > 0)
            {
                return true;
            }
            return false;
        }

        public int Next()
        {
            return flatList.Dequeue();
        }
    }

    /**
     * Your NestedIterator will be called like this:
     * NestedIterator i = new NestedIterator(nestedList);
     * while (i.HasNext()) v[f()] = i.Next();
     */
}
