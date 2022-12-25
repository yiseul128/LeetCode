using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _797.All_Paths_From_Source_to_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        const int MAX = 100;
        IList<IList<int>> answer;

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            answer = new List<IList<int>>();
            int target = graph.Length - 1;

            bool[] visited = new bool[graph.Length];
            int[] prev = new int[graph.Length];
            int[] dists = new int[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                dists[i] = MAX;
            }
            for (int i = 0; i < graph.Length; i++)
            {
                prev[i] = -1;
            }
            dists[0] = 0;

            RecurFind(graph, dists, prev, visited, 0);
            return answer;
        }

        public void RecurFind(int[][] graph, int[] dists, int[] prev, bool[] visited, int curr)
        {
            // base for finding path
            if (graph.Length - 1 == curr)
            {
                int walk = graph.Length - 1;
                List<int> path = new List<int>();

                while (prev[walk] != -1)
                {
                    path.Add(walk);
                    walk = prev[walk];
                }
                path.Add(0);
                path.Reverse();
                answer.Add(path);
                return;
            }

            int[] adj = graph[curr];
            for (int i = 0; i < adj.Length; i++)
            {
                if (visited[adj[i]])
                {
                    continue;
                }

                visited[adj[i]] = true;

                int newDist = dists[curr] + 1;
                dists[adj[i]] = newDist;
                prev[adj[i]] = curr;

                // recur
                RecurFind(graph, dists, prev, visited, adj[i]);

                visited[adj[i]] = false;
            }
        }

        public bool HasUnvisited(bool[] visited, int[] dists)
        {
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i] && dists[i] < MAX)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetLowest(bool[] visited, int[] dists)
        {
            int idx = -1;
            int lowest = MAX;

            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                if (dists[i] < lowest)
                {
                    lowest = dists[i];
                    idx = i;
                }
            }

            return idx;
        }
    }
}
