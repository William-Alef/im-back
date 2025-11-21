using System.Net.Http.Headers;
namespace UtilizandoYield.Models;

public class Carrinho
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void RemoverProduto(string nome)
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("O carrinho não possui itens para a remoção.");
        }
        else if (nome == null)
        {
            Console.WriteLine("Nome não informado ou null.");
        }
        else
        {
            var produto = produtos.Find(e => e.Nome.Equals(nome));
            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine($"{produto.Nome} removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não localizado.");
            }
        }
    }

    public void ApresentarItensCarrinhoFor()
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"{produtos[i].Nome} - R${produtos[i].Preco}");
        }
    }

    public void ApresentarItensCarrinhoForEach()
    {
        foreach(var produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - R${produto.Preco}");
        }
    }
}
