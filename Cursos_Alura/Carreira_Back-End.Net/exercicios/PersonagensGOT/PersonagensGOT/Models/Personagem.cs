using System.Text.Json.Serialization;

namespace PersonagensGOT.Models;
public class Personagem
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("gender")]
    public string? Genero { get; set; }
    [JsonPropertyName("culture")]
    public string? Cultura { get; set; }
    [JsonPropertyName("born")]
    public string? Nascimento { get; set; }
    [JsonPropertyName("died")]
    public string? Morte { get; set; }
    [JsonPropertyName("titles")]
    public List<string>? Titulo { get; set; }
    [JsonPropertyName("aliases")]
    public List<string>? Aliados { get; set; }

    public override string ToString()
    {
        return 
            $"Informações detalhadas:" +
            $"\nNome: {Nome}" +
            $"\nGênero: {Genero}" +
            $"\nCultura: {Cultura}" +
            $"\nNascimento: {Nascimento}" +
            $"\nMorte: {(string.IsNullOrEmpty(Morte) ? "Personagem 'AINDA' não morreu" : Morte)}" +
            $"\nTitulo: {string.Join(", ", Titulo ?? new List<string>())}" +
            $"\nAliados: {string.Join(", ", Aliados ?? new List<string>())}";
    }
}
