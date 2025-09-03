using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 50, 5, 20, 2 };
            List<int> finalList = quicksort(list);
            foreach (var item in finalList)
            {
                System.Console.WriteLine(item);
            }
        }

        static List<int> quicksort(List<int> list)
        {
            if (list.Count < 2)
            {
                return list;
            }
            else
            {
                int middleIndex = list.Count / 2;
                int pivot = list[middleIndex];

                List<int> lower = new List<int> { };
                List<int> bigger = new List<int> { };

                for (int i = 0; i < list.Count; i++)
                {
                    if (i != middleIndex)
                    {
                        if (list[i] <= pivot)
                        {
                            lower.Add(list[i]);
                        }
                        else
                        {
                            bigger.Add(list[i]);
                        }    
                    }
                }

                List<int> sortedLower = quicksort(lower);
                List<int> sortedBigger = quicksort(bigger);
                List<int> sortedList = new List<int> { };
                sortedList.AddRange(sortedLower);
                sortedList.Add(pivot);
                sortedList.AddRange(sortedBigger);
                
                return sortedList;
            }
        }
    }
}