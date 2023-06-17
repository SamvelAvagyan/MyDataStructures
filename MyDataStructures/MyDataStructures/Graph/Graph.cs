using System.Collections.Generic;

namespace MyDataStructures.Graph
{
    class Graph
    {
        private List<Vertex> Vertexes = new List<Vertex>();
        private List<Edge> Edges = new List<Edge>();

        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertex(Vertex v)
        {
            Vertexes.Add(v);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            Edges.Add(new Edge(from, to));
        }

        public int[,] GetMatrix()
        {
            int[,] matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach(var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexList(Vertex vertex)
        {
            var list = new List<Vertex>();

            foreach(var edge in Edges)
            {
                if(edge.From == vertex)
                {
                    list.Add(edge.To);
                }
            }

            return list;
        }
    }
}
