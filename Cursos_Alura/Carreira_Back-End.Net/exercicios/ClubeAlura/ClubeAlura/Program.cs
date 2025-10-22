using ClubeAlura.Models;

namespace ClubeAlura;
public class Program
{
    static void Main(string[] args)
    {
        ClienteVip rafael = new ClienteVip("Rafael", 19, "Ouro", "1212a" );
        Console.WriteLine(rafael);
    }
}