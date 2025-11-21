using GerenciadorDeMusicas.Models;
namespace GerenciadorDeMusicas.Services;
internal class MaisTocadas
{
    private Dictionary<MusicaModel, int> Ranking = [];

    public void ContarPlaylist(PlaylistModel playlist1, PlaylistModel playlist2)
    {
        foreach (var musica in playlist1)
        {
            Ranking[musica] = Ranking.GetValueOrDefault(musica) + 1;
        }

        foreach (var musica in playlist2)
        {
            Ranking[musica] = Ranking.GetValueOrDefault(musica) + 1;
        }

        foreach (var musica in Ranking.OrderByDescending(m => m.Value))
        {
            Console.WriteLine($"{musica.Key.Nome} {musica.Value}");
        }
    }
}
