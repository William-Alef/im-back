using System.ComponentModel;
using UtilizandoYield.Models;
namespace UtilizandoYield;
public class Program
{
    static void Main(string[] args)
    {

        Produto p1 = new Produto("Notebook", 4500.00);
        Produto p2 = new Produto("Mouse", 120.00);
        Produto p3 = new Produto("Teclado", 250.00);
        Produto p4 = new Produto("Monitor", 900.00);

        Carrinho carrinho1 = new Carrinho();
        Carrinho carrinho2 = new Carrinho();

        carrinho1.AdicionarProduto(p1);
        carrinho1.AdicionarProduto(p2);
        carrinho1.AdicionarProduto(p3);

        carrinho2.AdicionarProduto(p2);
        carrinho2.AdicionarProduto(p4);

        carrinho1.RemoverProduto("Mouse");

        carrinho2.RemoverProduto("Teclado");

        Carrinho carrinhoVazio = new Carrinho();
        carrinhoVazio.RemoverProduto("Mouse");

        //carrinho1.ApresentarItensCarrinhoFor();
        //carrinho1.ApresentarItensCarrinhoForEach();

        Semana primeiraSemana = new Semana();

        foreach (var dias in primeiraSemana)
        {
            Console.WriteLine(dias);
        }

        foreach (var item in NumerosPares(5))
        {
            Console.WriteLine(item);
        }

    }
    public static IEnumerable<int> NumerosPares(int quantidadeLimite)
    {
        var i = 1;
        while (true)
        {
            if (i > quantidadeLimite) { yield break; }
            yield return i * 2;
            i++;
        }
    }
}