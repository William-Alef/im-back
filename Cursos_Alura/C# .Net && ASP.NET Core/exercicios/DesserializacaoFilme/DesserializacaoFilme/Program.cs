using DesserializacaoFilme.Models;
using DesserializacaoFilme.Services;
using System.Text.Json;
namespace DesserializacaoFilme;
public class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        try
        {
            string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
            List<Filme> filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
            
            FilmeService verificacoes = new FilmeService();
            verificacoes.ApresentarElenco(filmes);
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Houve um erro durante a execução do programa." +
                $"\n[Erro]: {ex.Message}"
            );
        }
    }
}