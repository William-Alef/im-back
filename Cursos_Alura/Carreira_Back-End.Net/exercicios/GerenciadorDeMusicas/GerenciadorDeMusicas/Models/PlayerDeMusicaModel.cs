using System.Collections.ObjectModel;

namespace GerenciadorDeMusicas.Models;
internal class PlayerDeMusicaModel()
{
    private Queue<MusicaModel> Fila { get; set; } = [];
    private Stack<MusicaModel> Historico { get; set; } = [];

    public void AdicionarNaFila(MusicaModel Musica)
    {
        Fila.Enqueue(Musica);
    }

    public void AdicionarNaFila(PlaylistModel Playlist)
    {
        foreach (var musica in Playlist)
        {
            Fila.Enqueue(musica);
        }
    }

    public MusicaModel? ProximaMusicaDaFila()
    {
        if (Fila.Count == 0) return null;
        var musica = Fila.Dequeue();
        Historico.Push(musica);
        return musica;
    }

    public MusicaModel? MusicaAnterior()
    {
        if(!Historico.Any()) return null;
        return Historico.Pop();  
    }
    
    public void HistoricoDeReproducao()
    {
        foreach (var musica in Historico) Console.WriteLine(musica.Nome);
    }

    public void FilaDeReproducao()
    {
        foreach (var musica in Fila) Console.WriteLine(musica.Nome);
    }
}
