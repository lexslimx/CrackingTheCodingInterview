using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {            
            /*
             * Create an adjacency list
             * From each node see if you can get to the end without htting a cycle.
             * 
             * 
             */
            Dictionary<int, List<int>>graph = new Dictionary<int, List<int>>();
            foreach(var pair in prerequisites)
            {
                if (graph.ContainsKey(pair[0]))
                {
                    graph[pair[0]].Add(pair[1]);
                }
                else
                {
                    graph.Add(pair[0],new List<int> { pair[1] });
                }

                if (!graph.ContainsKey(pair[1]))
                {
                    graph.Add(pair[1], new List<int>());
                }
            }


            //from each key see if we can get to the end with no cycles

            foreach(var node in graph)
            {
                if (CycleExists(node.Key, graph)) return false;
            }

            return true;
        }

        private bool CycleExists(int key, Dictionary<int, List<int>> graph)
        {
            HashSet<int> contains = new HashSet<int>();
            Queue<int> next = new Queue<int>();
            next.Enqueue(key);

            while(next.Count > 0)
            {
                var current = next.Dequeue();
                contains.Add(current);
                foreach(var node in graph[current])
                {
                    if (contains.Contains(node))
                    {
                        return true;
                    }
                    else
                    {
                        next.Enqueue(node);
                    }
                }
            }

            return false;
        }
    }
}
