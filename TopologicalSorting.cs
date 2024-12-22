using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik
{
    class TopologicalSorter
    {
        private readonly GraphBase _graph;

        public TopologicalSorter(GraphBase graph)
        {
            _graph = graph;
        }

        public List<int> Sort()
        {
            var visited = new bool[_graph.GetVertexCount()];
            var stack = new Stack<int>();

            for (int i = 0; i < _graph.GetVertexCount(); i++)
            {
                if (!visited[i])
                {
                    TopologicalSortUtil(i, visited, stack);
                }
            }

            var result = new List<int>();

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }

            return result;
        }

        private void TopologicalSortUtil(int v, bool[] visited, Stack<int> stack)
        {
            visited[v] = true;

            foreach (var neighbor in _graph.GetAdjacencyList()[v])
            {
                if (!visited[neighbor.Value])
                {
                    TopologicalSortUtil(neighbor.Value, visited, stack);
                }
            }

            stack.Push(v);
        }
    }
}
