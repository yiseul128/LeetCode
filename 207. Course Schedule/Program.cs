using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207.Course_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] arr = new int[][]
            {
                new int[] {1,0},
                new int[] {0,2},
                new int[] {2, 1}
            };
            s.CanFinish(3,arr );
        }
    }
    public class Solution
    {
        int[] visited;
        List<int>[] courses;

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int l = numCourses > prerequisites.Length ? numCourses : prerequisites.Length;
            courses = new List<int>[l];
            visited = new int[l];

            for (int i = 0; i < l; i++)
            {
                courses[i] = new List<int>();
            }

            for (int i = 0; i < prerequisites.Length; i++)
            {
                courses[prerequisites[i][0]].Add(prerequisites[i][1]);
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (!dfs(i))
                {
                    return false;
                }
            }

            return true;
        }

        public bool dfs(int i)
        {
            //visiting
            if (visited[i] == 1)
            {
                return true;
            }
            //visited
            if (visited[i] == -1)
            {
                return false;
            }

            visited[i] = -1;

            foreach (int j in courses[i])
            {
                if (!dfs(j))
                    return false;
            }

            visited[i] = 1;

            return true;
        }
    }
}
