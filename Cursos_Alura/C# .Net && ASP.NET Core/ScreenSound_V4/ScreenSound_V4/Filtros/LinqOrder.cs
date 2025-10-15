using ScreenSound_V4.Models;
namespace ScreenSound_V4.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasAscendente(List<Musica> musicas)
    {
        var artistas = musicas.OrderBy(m => m.Artista)
            .Select(m => m.Artista)
            .Distinct()
            .ToList();
        foreach (var artista in artistas) Console.WriteLine(artista);
    }
    public static void ExibirArtistasDecrescente(List<Musica> musicas)
    {
        var Artistas = musicas.Select(m => m.Artista)
            .Distinct()
            .OrderDescending()
            .ToList();

        foreach (var artista in Artistas) Console.WriteLine(artista);
    }
}
