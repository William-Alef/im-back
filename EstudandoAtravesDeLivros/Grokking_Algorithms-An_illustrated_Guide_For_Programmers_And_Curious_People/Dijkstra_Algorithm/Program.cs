using System.Xml.Serialization;
using Graph;
using Dijkstra;
using System.Runtime.InteropServices;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> Dij = new Graph<string>();
            Dij.AddEdge("Start", "a", 6);
            Dij.AddEdge("Start", "b", 2);
            Dij.AddEdge("a", "exit", 1);
            Dij.AddEdge("b", "a", 3);
            Dij.AddEdge("b", "exit", 5);

            System.Console.WriteLine(Dij.ToString());
            var solver = new Dijkstra<string>(Dij);
            (int shortestDistance, Dictionary<string, string> parents) = solver.FindShortestPath("Start", "exit");
            System.Console.WriteLine($"The lowest distance is: {shortestDistance}");

            if (shortestDistance != int.MaxValue)
            {
                var pathNodes = new List<string>();
                string currentNode = "exit";

                while (parents.ContainsKey(currentNode))
                {
                    pathNodes.Insert(0, currentNode);
                    currentNode = parents[currentNode];
                }
                pathNodes.Insert(0, "Start");
                System.Console.WriteLine($"The shortest path is: {string.Join(" -> ", pathNodes)}");
            }
            else
            {
                System.Console.WriteLine("No path for 'Exit' found.");
            }
        }
    }
}