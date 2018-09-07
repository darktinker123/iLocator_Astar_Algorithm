using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    class GraphAlgorithms
    {
        static public int Heuristic(Point a, Point b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        }

        public HashSet<T> AStar<T>(GraphAstar<T> graph, T start, T end, int[] h)
        {
            var a = new HashSet<T>();
            Dictionary<T, T> cameFrom = new Dictionary<T, T>();
            Dictionary<T, int> costSoFar = new Dictionary<T, int>();
            var closed = new HashSet<T>();
            var frontier = new PriorityQueue<T>();
            frontier.Enqueue(start, 0);

            cameFrom[start] = start;
            costSoFar[start] = 0;
            while (frontier.Count > 0)
            {
                var current = frontier.Dequeue();
                if (current.Equals(end))
                {
                    break;
                }
                foreach (var next in graph.AdjacencyList[current])
                {
                    int newCost;
                    try
                    {
                        newCost = costSoFar[current]
                                       + graph.withCost[Tuple.Create(current, next)] + h[int.Parse(next.ToString())];
                    }
                    catch (Exception)
                    {

                        newCost = costSoFar[current]
                                      + graph.withCost[Tuple.Create(next, current)] + h[int.Parse(next.ToString())];
                    }
                   
                    if (!costSoFar.ContainsKey(next) || newCost < costSoFar[next])
                    {
                        costSoFar[next] = newCost;
                        int priority = newCost + (Heuristic(graph.location[next], graph.location[end]) + h[int.Parse(current.ToString())]);
                        frontier.Enqueue(next, priority);
                        cameFrom[next] = current;
                    }
                }
            }
            //search path reversely using memory [camefrom]
            a.Add(end);
            T curr = end;
            while (!curr.Equals(start))
            {
                foreach (var item in cameFrom)
                {
                    if (item.Key.Equals(curr))
                    {
                        a.Add(item.Value);
                        curr = item.Value;
                    }
                }
            }
            return a;
        }
        public class PriorityQueue<T>
        {
            private List<Tuple<T, double>> elements = new List<Tuple<T, double>>();

            public int Count
            {
                get { return elements.Count; }
            }

            public void Enqueue(T item, double priority)
            {
                elements.Add(Tuple.Create(item, priority));
            }

            public T Dequeue()
            {
                int bestIndex = 0;

                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Item2 < elements[bestIndex].Item2)
                    {
                        bestIndex = i;
                    }
                }

                T bestItem = elements[bestIndex].Item1;
                elements.RemoveAt(bestIndex);
                return bestItem;
            }
        }
    }
}