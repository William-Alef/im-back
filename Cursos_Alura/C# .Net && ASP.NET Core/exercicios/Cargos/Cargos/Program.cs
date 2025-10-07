using Cargos.Models;
namespace Cargos;

public class Program
{
    static void Main(string[] args)
    {
        Programador Mario = new Programador("Mario", 3400, "Back-End", "C#");
        Console.WriteLine(Mario);
    }
}