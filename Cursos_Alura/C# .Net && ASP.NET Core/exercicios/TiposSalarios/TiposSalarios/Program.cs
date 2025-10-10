using TiposSalarios.Models;

namespace TiposSalarios;
public class Program
{
    static void Main(string[] args)
    {
        Interno f1 = new Interno("Luciana", "Desenvolvedora", 28, 10000);
        Freelancer f2 = new Freelancer("Mario", "Designer", 33, "Criação gráfica para WOWd1", 3500);

        Console.WriteLine(f1);
        Console.WriteLine();
        Console.WriteLine(f2);
    }
}