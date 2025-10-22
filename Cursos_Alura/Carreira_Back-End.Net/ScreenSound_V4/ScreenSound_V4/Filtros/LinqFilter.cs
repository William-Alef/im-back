using ScreenSound_V4.Models;
namespace ScreenSound_V4.Filtros;

internal class LinqFilter
{
    public static void FiltrarArtistasPorGenero(List<Musica> listaMusicas, string generoInformado)
    {
        var ArtistasPorGenero = listaMusicas.Where(m => m.Genero.Contains(generoInformado))
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        foreach (var artista in ArtistasPorGenero) Console.WriteLine(artista);   
    }

    public static void FiltrarMusicasDoArtista(List<Musica> listaMusicas, string nomeArtista)
    {
        var musicasDoArtista = listaMusicas.Where(m => m.Artista!.Equals(nomeArtista))
            .Distinct()
            .ToList();
        Console.WriteLine($"Músicas do(a) {nomeArtista}:\n");
        foreach (var musicas in musicasDoArtista) Console.WriteLine(musicas.Nome);
    }

    public static void FiltrarMusicasPorAno(List<Musica> listaMusicas, int ano)
    {
        var musicasDoAno = listaMusicas.Where(m => m.Ano == ano)
            .Distinct()
            .OrderBy(m => m.Nome)
            .Select(m => m.Nome)
            .ToList();
        Console.WriteLine($"Músicas do ano {ano}:\n");
        foreach (var musica in musicasDoAno) Console.WriteLine(musica);
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> listaMusicas, string tom)
    {
        var musicasDaTonalidade = listaMusicas.Where(m => m.Tonalidade!.Equals(tom))
            .Distinct()
            .OrderBy(m => m.Nome)
            .Select(m => m.Nome)
            .ToList();
        Console.WriteLine($"Músicas em {tom}:\n");
        foreach (var musica in musicasDaTonalidade) Console.WriteLine(musica);

    }
}
