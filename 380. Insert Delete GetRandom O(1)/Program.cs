using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _380.Insert_Delete_GetRandom_O_1_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class RandomizedSet
    {

        private HashSet<int> set;
        private Random random = new Random();

        public RandomizedSet()
        {
            set = new HashSet<int>();
        }

        public bool Insert(int val)
        {
            return set.Add(val);
        }

        public bool Remove(int val)
        {
            return set.Remove(val);
        }

        public int GetRandom()
        {
            return set.ElementAt(random.Next(set.Count));
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
