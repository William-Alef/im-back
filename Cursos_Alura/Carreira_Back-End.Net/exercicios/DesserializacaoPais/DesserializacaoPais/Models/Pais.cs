using System.Text.Json.Serialization;

namespace DesserializacaoPais.Models;
public class Pais
{
    [JsonPropertyName("nome")]
    public string ?Nome { get; set; }
    
    [JsonPropertyName("capital")]
    public string ?Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string? Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public override string ToString()
    {
        return
            $"Nome: {Nome}" +
            $"\nCapital: {Capital}" +
            $"\nContinente: {Continente}" +
            $"\nPopulação: {Populacao}" +
            $"\nIdioma: {Idioma}";
    }
}
