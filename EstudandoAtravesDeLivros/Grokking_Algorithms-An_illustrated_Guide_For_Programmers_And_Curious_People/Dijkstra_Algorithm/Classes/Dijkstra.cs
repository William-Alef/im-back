using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Graph;
namespace Dijkstra
{
    public class Dijkstra<T> where T : notnull
    {
        private readonly Graph<T> _graph;
        public Dijkstra(Graph<T> graph)
        {
            _graph = graph;
        }
        public (int, Dictionary<T, T>) FindShortestPath(T startNode, T endNode)
        {
            var distances = new Dictionary<T, int>();
            var parents = new Dictionary<T, T>();
            var processed = new HashSet<T>();

            foreach (var node in _graph.AdjacentList.Keys)
            {
                distances[node] = int.MaxValue;
            }
            distances[startNode] = 0;

            T? currentNode = startNode;
            while (currentNode != null && !processed.Contains(endNode))
            {
                currentNode = GetNodeWithLowestDistance(distances, processed);
                if (currentNode == null) break;
                processed.Add(currentNode);

                foreach (var edge in _graph.AdjacentList[currentNode])
                {
                    if (!processed.Contains(edge.Destination))
                    {
                        int newDistance = distances[currentNode] + edge.Weight;
                        if (newDistance < distances[edge.Destination])
                        {
                            distances[edge.Destination] = newDistance;
                            parents[edge.Destination] = currentNode;
                        }
                    }
                }
            }
            return (distances[endNode], parents);
        }
        private T? GetNodeWithLowestDistance(Dictionary<T, int> distances, HashSet<T> processed)
        {
            T? lowestDistanceNode = default(T);
            int lowestDistance = int.MaxValue;

            foreach (var node in distances.Keys)
            {
                if (!processed.Contains(node) && distances[node] < lowestDistance)
                {
                    lowestDistance = distances[node];
                    lowestDistanceNode = node;
                }
            }
            return lowestDistanceNode;
        }
    }
}