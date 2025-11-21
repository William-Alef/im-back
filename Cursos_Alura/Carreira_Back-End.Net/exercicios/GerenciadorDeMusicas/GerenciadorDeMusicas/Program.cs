using GerenciadorDeMusicas.Models;
using GerenciadorDeMusicas.Services;
using System.Runtime.CompilerServices;

namespace GerenciadorDeMusicas;

public class Program
{
    static void Main(string[] args)
    {
        var artista1 = new ArtistaModel("Lobo Guará", 28);
        var artista2 = new ArtistaModel("DJ Maritaca", 31);
        var artista3 = new ArtistaModel("Sabiá Sonoro", 22);

        var musica1 = new MusicaModel("Batida Selvagem", 180, artista1);
        var musica2 = new MusicaModel("Noite na Floresta", 215, artista1);
        var musica3 = new MusicaModel("Chamado da Maritaca", 150, artista2);
        var musica4 = new MusicaModel("Ritmo Tropical", 200, artista2);
        var musica5 = new MusicaModel("Melodia do Vento", 175, artista3);

        PlaylistModel playlist1 = new PlaylistModel("Natureza Beats", "Músicas inspiradas na fauna brasileira", musica1);
        playlist1.Add(musica1);
        playlist1.Add(musica5);

        PlaylistModel playlist2 = new PlaylistModel("Mix do Cerrado", "Ritmos variados", musica2);
        playlist2.Add(musica4);
        playlist2.Add(musica5);
        playlist2.Add(musica3);
        

        PlaylistModel playlist3 = new PlaylistModel("Relax Brasil", "Músicas calmas para concentração", musica5);
        playlist3.Add(musica1);
        playlist3.Add(musica2);
        playlist3.Add(musica3);
        playlist3.Add(musica5);

        Console.WriteLine(playlist2);
        Console.WriteLine();
        MaisTocadas top3 = new MaisTocadas();
        top3.ContarPlaylist(playlist2, playlist3);
        Console.WriteLine();
        Console.WriteLine();

        PlayerDeMusicaModel WinPlayer = new PlayerDeMusicaModel();
        WinPlayer.AdicionarNaFila(musica1);
        WinPlayer.AdicionarNaFila(musica4);
        WinPlayer.AdicionarNaFila(playlist1);
    }
}