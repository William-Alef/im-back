using DesserializacaoPais.Models;
using DesserializacaoPais.Services;
using System.Text.Json;
namespace DesserializacaoProgram;

public class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient cliente = new HttpClient();

        try
        {
            var resposta = await cliente.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
            var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);

            PaisService paisService = new PaisService();
            paisService.CompararPopulacao(paises, "Índia", "Rússia");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Houve um erro ao tentar executar o programa." +
                $"\n[ERRO]: {ex.Message}"
            );
        }
    }
}