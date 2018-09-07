using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLocatorAstar
{
    class GraphAstar<T>
    {
        public GraphAstar() { }
        public void init(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }
        public Dictionary<T, HashSet<T>> AdjacencyList  = new Dictionary<T, HashSet<T>>();
        public Dictionary<Tuple<T, T>, int> withCost = new Dictionary<Tuple<T, T>, int>();
        public Dictionary<T, Point> location = new Dictionary<T, Point>();
        public void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new HashSet<T>();
        }
        public void setIndividualDistance(Tuple<T, T> edge, int cost)
        {
            withCost[edge] = cost;
        }
        public void setLocation(T index, Point p)
        {
            location.Add(index,p);
        }
        public void AddEdge(Tuple<T, T> edge)
        {
            if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);
                AdjacencyList[edge.Item2].Add(edge.Item1);

            }

        }

    }
}
