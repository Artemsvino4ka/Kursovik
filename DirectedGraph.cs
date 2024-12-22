using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kursovik
{
    class DirectedGraph : GraphBase
    {
        private readonly List<Node>[] _adjacencyList;

        public DirectedGraph(int vertices) : base(vertices)
        {
            _adjacencyList = new List<Node>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                _adjacencyList[i] = new List<Node>();
            }
        }

        public override void AddEdge(int start, int end)
        {
            var node = new Node(end);
            _adjacencyList[start].Add(node);
        }

        public override List<Node>[] GetAdjacencyList()
        {
            return _adjacencyList;
        }
    }
}
