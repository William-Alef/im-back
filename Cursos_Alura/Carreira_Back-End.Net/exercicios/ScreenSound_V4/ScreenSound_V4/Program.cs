using ScreenSound_V4.Filtros;
using ScreenSound_V4.Models;
using System.Text.Json;
using GeradorDeRelatorios;
using System.Runtime.CompilerServices;
using ScreenSound_V4;

using (HttpClient cliente = new HttpClient()) 
{
    try 
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>> (resposta)!;
        
        LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        Console.WriteLine("--------------------------");

        LinqOrder.ExibirArtistasDecrescente(musicas);
        Console.WriteLine("--------------------------");

        LinqFilter.FiltrarMusicasDoArtista(musicas, "Kendrick Lamar");
        Console.WriteLine("--------------------------");

        LinqFilter.FiltrarMusicasPorAno(musicas, 2020);
        Console.WriteLine("--------------------------");

        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "F#");

        MusicasPreferidas musicasWilliam = new MusicasPreferidas("William");
        musicasWilliam.AdicionarMusicas(musicas[1]);
        musicasWilliam.AdicionarMusicas(musicas[2]);
        musicasWilliam.AdicionarMusicas(musicas[3]);
        musicasWilliam.AdicionarMusicas(musicas[4]);
        musicasWilliam.AdicionarMusicas(musicas[5]);

        musicasWilliam.GerarArquivoJson();

        List<Dictionary<string, string>> listaDoRelatorio = new List<Dictionary<string, string>>();

        foreach (var musica in musicas)
        {
            var dados = new Dictionary<string, string>
            {
                {"Título", musica.Nome},
                {"Artista", musica.Artista },
                {"Gênero", musica.Genero },
                {"Tonalidade", musica.Tonalidade},
                {"Lançamento", musica.AnoNaoConvertido}
            };
            listaDoRelatorio.Add(dados);
        }
        GeradorCSV relatorio = new GeradorCSV(listaDoRelatorio);
        Console.WriteLine(Path.GetFullPath(relatorio.CSVGenerator("RelatorioDeMusicas.csv")));
    }
    catch(Exception ex)
    {
        Console.WriteLine(
            "Houve um erro ao tentar processar a requisição." +
            $"\n[ERROR] {ex.Message}"
        );
    }
}
