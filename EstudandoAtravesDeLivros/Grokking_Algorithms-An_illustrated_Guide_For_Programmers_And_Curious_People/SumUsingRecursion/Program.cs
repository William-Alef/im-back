using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 5};
            Console.WriteLine(ReturnSun(numbers));

        }
        static int ReturnSun(List<int> numbers)
        {
            if (numbers.Count() == 0)
            {
                return 0;
            }
            
            int first = numbers[0];
            List<int> rest = numbers.GetRange(1, numbers.Count() - 1);
            return first + ReturnSun(rest);
        }
    }
}