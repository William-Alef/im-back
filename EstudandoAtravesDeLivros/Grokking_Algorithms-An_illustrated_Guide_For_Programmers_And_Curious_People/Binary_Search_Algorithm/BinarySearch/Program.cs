using System.Reflection.Metadata;
using Class;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = CheckInt.RequiestInt("Let's plat the guessing game!" +
            $"\nType how many numbers you want to include, and secretly pick one, but don't tell me!\nHow many numbers should we play with: ");
            CheckInt.BinarySearch(quantidade);
        }
    }
}
