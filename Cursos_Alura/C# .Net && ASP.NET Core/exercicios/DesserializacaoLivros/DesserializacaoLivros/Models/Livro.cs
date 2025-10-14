using System.Text.Json.Serialization;

namespace DesserializacaoLivros.Models;
public class Livro
{
    [JsonPropertyName("titulo")]
    public string ?Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string? Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int Ano { get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    [JsonPropertyName("editora")]
    public string? Editora { get; set; }

    public override string ToString()
    {
        return 
            $"Titulo: {Titulo}" +
            $"\nAutor: {Autor}" +
            $"\nAno: {Ano}" +
            $"\nGênero: {Genero}" +
            $"\nPaginas: {Paginas}" +
            $"\nEditora: {Editora}";
    }
}
