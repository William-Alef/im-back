using System.Text.Json.Serialization;
namespace DesserializacaoFilme.Models;

public class Filme
{
    [JsonPropertyName("title")]
    public string ?Titulo { get; set; }

    [JsonPropertyName("year")]
    public string ?Ano { get; set; }

    [JsonPropertyName("crew")]
    public string ?Elenco { get; set; }

    [JsonPropertyName("imDbRating")]
    public string ?Nota { get; set; }

    public override string ToString()
    {
        return 
            $"Ficha técnica:" +
            $"\nTítulo: {Titulo}" +
            $"\nAno: {Ano}" +
            $"\nElenco: {Elenco}" +
            $"\n NOTA: {Nota}";
    }
}
