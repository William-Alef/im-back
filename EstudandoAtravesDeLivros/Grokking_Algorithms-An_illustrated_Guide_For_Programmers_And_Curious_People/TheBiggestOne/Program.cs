using System.Runtime.ExceptionServices;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 10, 20, 5, 2 };
            Console.WriteLine(FindTheBigger(numbers));
        }
        static int FindTheBigger(List<int> list)
        {
            if (list.Count == 1)
            {
                return list[0];
            }
            
            int first = list[0];
            List<int> rest = list.GetRange(1, list.Count - 1);
            int biggerInRest = FindTheBigger(rest);

            return first > biggerInRest ? first : biggerInRest;
        }
    }
}