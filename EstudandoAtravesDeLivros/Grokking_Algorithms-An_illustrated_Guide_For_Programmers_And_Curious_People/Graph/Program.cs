using System.Reflection.Metadata;
using Class;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> friends = new Graph<string>();
            friends.AddEdge("I", "Bob");
            friends.AddEdge("I", "Claire");
            friends.AddEdge("I", "Alice");
            friends.AddEdge("Claire", "Thom");
            friends.AddEdge("Claire", "Jonny");
            friends.AddEdge("Alice", "Peggy");
            friends.AddEdge("Bob", "Peggy");
            friends.AddEdge("Bob", "Anuj");

            System.Console.WriteLine(friends.ToString());
            System.Console.WriteLine("'Bob' and 'I' are conected: " + friends.CheckConection("I", "Bob"));
            System.Console.WriteLine("'Jonny' and 'I' are conected: " + friends.CheckConection("I", "Jonny"));
        }
    }
}