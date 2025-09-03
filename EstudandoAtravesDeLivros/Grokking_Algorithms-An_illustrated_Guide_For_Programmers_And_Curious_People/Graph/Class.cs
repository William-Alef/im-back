using System.Security.Cryptography;
using System.Text;

namespace Class
{
    public class Graph<T> where T: notnull
    {
        private Dictionary<T, List<T>> adjacencyList;
        public Graph()
        {
            adjacencyList = new Dictionary<T, List<T>>();
        }
        public void AddNode(T node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<T>();
            }
        }
        public void AddEdge(T from, T to, bool isDirected = false)
        {
            AddNode(from);
            AddNode(to);

            adjacencyList[from].Add(to);
            if (!isDirected)
            {
                adjacencyList[to].Add(from);
            }
        }
        public bool CheckConection(T from, T to)
        {
            if (!adjacencyList.ContainsKey(from))
            {
                return false;
            }
            return adjacencyList[from].Contains(to);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Graph: ");

            foreach (var item in adjacencyList)
            {
                sb.AppendLine($"Node {item.Key}: ");
                sb.AppendLine(string.Join(", ", item.Value));
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }    
}