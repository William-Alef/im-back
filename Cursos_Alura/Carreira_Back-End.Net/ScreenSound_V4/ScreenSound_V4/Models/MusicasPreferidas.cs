using System.Text.Json;

namespace ScreenSound_V4.Models;
internal class MusicasPreferidas
{
    public string Nome { get; set; }
    private List<Musica> ListaDeMusicas { get; set; } = [];

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusicas(Musica musica)
    {
        ListaDeMusicas.Add(musica);
    }

    public void MusicasNaLista()
    {
        foreach (var musica in ListaDeMusicas)
        {
            Console.WriteLine($"{musica.Nome} - {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize( new
        {
            nome = Nome,
            musicas = ListaDeMusicas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso.");
    }
}
