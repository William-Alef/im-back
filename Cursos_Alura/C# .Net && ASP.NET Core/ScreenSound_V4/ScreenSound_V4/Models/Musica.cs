using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace ScreenSound_V4.Models;
internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public double Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    
    [JsonPropertyName("popularity")]
    public string? Popularidade { get; set; }

    [JsonPropertyName("year")]
    public string? AnoNaoConvertido { get; set; }
    public int Ano 
    {
        get 
        {
            return int.Parse(AnoNaoConvertido!);
        }
    }

    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade { 
        get 
        {
            return tonalidades[Key];
        } 
    }

    public Musica (){}
    public Musica (string nome, string artista, double duracao, string genero, string popularidade, string ano)
    {
        Nome = nome;
        Artista = artista;
        Duracao = duracao;
        Genero = genero;
        Popularidade = popularidade;
        AnoNaoConvertido = ano;
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine(
            $"Nome: {Nome}" +
            $"\nArtista: {Artista}" +
            $"\nDuração: {Duracao}" +
            $"\nGênero: {Genero}" +
            $"\nTonalidade: {Tonalidade}\n"
        );
    }
}
