using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovik
{
    abstract class GraphBase
    {
        protected int _vertices;

        protected GraphBase(int vertices)
        {
            _vertices = vertices;
        }

        public abstract void AddEdge(int start, int end);
        public abstract List<Node>[] GetAdjacencyList();
        public int GetVertexCount() => _vertices;
    }
}
