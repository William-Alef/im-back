using System.Reflection.Metadata;
using System.Text;

namespace Graph
{
    public class Edge<T>
    {
        public T Destination { get; }
        public int Weight { get; }

        public Edge(T destination, int weight)
        {
            Destination = destination;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Destination} (weight: {Weight})";
        }
    }
    public class Graph<T> where T : notnull
    {
        private Dictionary<T, List<Edge<T>>> adjacentList;
        public Dictionary<T, List<Edge<T>>> AdjacentList => adjacentList;
        public Graph()
        {
            adjacentList = new Dictionary<T, List<Edge<T>>>();
        }
        public void AddNode(T node)
        {
            if (!adjacentList.ContainsKey(node))
            {
                adjacentList[node] = new List<Edge<T>>();
            }
        }
        public void AddEdge(T from, T to, int weight, bool isDirected = false)
        {
            AddNode(from);
            AddNode(to);
            if (!isDirected)
            {
                adjacentList[to].Add(new Edge<T>(from, weight));
            }
            adjacentList[from].Add(new Edge<T>(to, weight));
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Graph:");

            foreach (var node in adjacentList)
            {
                sb.Append($"{node.Key} ");
                sb.AppendLine(string.Join(", ", node.Value));
            }
            return sb.ToString();
        }
    }
}