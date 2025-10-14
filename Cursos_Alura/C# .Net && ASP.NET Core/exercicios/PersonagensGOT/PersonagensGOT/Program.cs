using PersonagensGOT.Models;
using PersonagensGOT.Services;
using System.Text.Json;
namespace PersonagensGOT;
public class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            using HttpClient cliente = new HttpClient();
            var resposta = await cliente.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

            Personagem personagem = JsonSerializer.Deserialize<Personagem>(resposta);

            PersonagemService personagemService = new PersonagemService();
            personagemService.ApresentarPersonagens(personagem);
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Ocorreu um erro no momento de consumir e utilizar o endpoint." +
                $"\n[ERRO]: {ex.Message}"
            );
        }
    }
}