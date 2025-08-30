using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new() { "Jose", "maria", "Rafael", "Samanta" };
            Console.WriteLine(CountingItens(names));
        }
        static int CountingItens(List<string> values)
        {
            if (values.Count == 0)
            {
                return 0;
            }
            values.RemoveAt(0);
            List<string> TemporaryList = new List<string>(values);
            return 1 + CountingItens(TemporaryList);
        }
    }
}