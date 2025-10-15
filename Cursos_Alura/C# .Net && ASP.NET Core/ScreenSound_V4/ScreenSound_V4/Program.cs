using ScreenSound_V4.Filtros;
using ScreenSound_V4.Models;
using System.ComponentModel;
using System.Text.Json;

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

        LinqFilter.FiltrarMusicasDoArtista(musicas, "U2");
        Console.WriteLine("--------------------------");

        LinqFilter.FiltrarMusicasPorAno(musicas, 2020);
        Console.WriteLine("--------------------------");
       
        MusicasPreferidas musicasWilliam = new MusicasPreferidas("William");
        musicasWilliam.AdicionarMusicas(musicas[1]);
        musicasWilliam.AdicionarMusicas(musicas[2]);
        musicasWilliam.AdicionarMusicas(musicas[3]);
        musicasWilliam.AdicionarMusicas(musicas[4]);
        musicasWilliam.AdicionarMusicas(musicas[5]);

        musicasWilliam.GerarArquivoJson();


    }
    catch(Exception ex)
    {
        Console.WriteLine(
            "Houve um erro ao tentar processar a requisição." +
            $"\n[ERROR] {ex.Message}"
        );
    }
}