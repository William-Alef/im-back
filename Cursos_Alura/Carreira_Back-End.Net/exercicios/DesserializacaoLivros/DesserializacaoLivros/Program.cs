using DesserializacaoLivros.Models;
using DesserializacaoLivros.Services;
using System.Text.Json;

namespace DesserializacaoLivros;
public class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient clente = new HttpClient();
        string resposta = await clente.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        List<Livro> livros = JsonSerializer.Deserialize<List<Livro>>(resposta);
        
        LivroServices livroServices = new LivroServices();
        livroServices.ApresentarLivros(livros);
        Console.WriteLine("-------");
        livroServices.FiltrarPorEditora(livros, "Leya");
        Console.WriteLine("-------");
        livroServices.FiltrarPorAno(livros, 1954);
    }
}