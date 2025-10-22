using DesserializacaoCarro.Models;
using DesserializacaoCarro.Services;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desserializacao;
public class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient cliente = new HttpClient();
        try
        {
            string resposta = await cliente.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
            List<Carro> carro = JsonSerializer.Deserialize<List<Carro>>(resposta);

            CarroService carroService = new CarroService();
            carroService.ApresentarCarros(carro);
            Console.WriteLine("------");
            carroService.CompararMotor(carro, "Ford", "Honda");
            Console.WriteLine("------");
            carroService.FiltrarPorTipo(carro, "Honda");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Houve um erro ao tentar consumir o endpoint." +
                $"\n[Erro]: {ex.Message}"
            );
        }
    }
}