
namespace UtilizandoYield.Models;

public class Produto
{
    public string  Nome { get;}
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void atualizarPreco (int valor)
    {
        Preco = valor;
    }
}
