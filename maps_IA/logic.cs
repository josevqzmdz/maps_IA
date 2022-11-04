using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maps_IA
{
    internal class logic
    {
        public logic()
        {

        }

        // https://www.koderdojo.com/blog/depth-first-search-algorithm-in-csharp-and-net-core
        public List<node> DFS(List<node> graph, node first)
        {
            List<node> traversedNodes = new List<node>();

            if (!graph.Contains(first))
            {
                return traversedNodes;
            }

            var stack = new Stack<node>();
            stack.Push(first);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();
                if (traversedNodes.Contains(vertex))
                {
                    continue;
                }
                traversedNodes.Add(vertex);

                foreach (var neighbor in graph)
                {
                    if (!traversedNodes.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }

                foreach (var a in stack)
                {
                    Console.WriteLine(a.name + " - " + a.distance);
                }
            }
            return traversedNodes;
        }
    }
}
