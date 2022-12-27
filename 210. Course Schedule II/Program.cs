using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210.Course_Schedule_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            if (!CanFinish(numCourses, prerequisites))
            {
                return new int[0];
            }

            int[] answer = new int[numCourses];

            List<int>[] prereqs = new List<int>[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                prereqs[i] = new List<int>();
            }

            for (int i = 0; i < prerequisites.Length; i++)
            {
                prereqs[prerequisites[i][0]].Add(prerequisites[i][1]);
                // Console.WriteLine(prerequisites[i][0]+", "+prerequisites[i][1]);
            }

            List<int> courses = new List<int>();
            bool[] visited = new bool[numCourses];
            Stack<int> courseStack = new Stack<int>();
            int currCourse = -1;
            while (true)
            {
                if (courseStack.Count == 0)
                {
                    currCourse = GiveUnvisited(visited);

                    if (currCourse == -1)
                    {
                        break;
                    }

                    courses.Add(currCourse);
                }
                else
                {
                    currCourse = courseStack.Pop();
                }

                // Console.WriteLine(currCourse);
                visited[currCourse] = true;
                foreach (int i in prereqs[currCourse])
                {
                    courseStack.Push(i);
                    if (visited[i])
                    {
                        courses.Remove(i);
                    }
                    courses.Insert(0, i);
                    visited[i] = true;
                }
            }

            int count = 0;
            foreach (int i in courses)
            {
                answer[count] = i;
                count++;
            }
            return answer;
        }

        public int GiveUnvisited(bool[] visited)
        {
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // from 207. Course Schedule
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int l = numCourses > prerequisites.Length ? numCourses : prerequisites.Length;
            List<int>[] courses = new List<int>[l];
            int[] visited = new int[l];

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
                if (!dfs(i, visited, courses))
                {
                    return false;
                }
            }

            return true;
        }

        public bool dfs(int i, int[] visited, List<int>[] courses)
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
                if (!dfs(j, visited, courses))
                    return false;
            }

            visited[i] = 1;

            return true;
        }
    }
}
