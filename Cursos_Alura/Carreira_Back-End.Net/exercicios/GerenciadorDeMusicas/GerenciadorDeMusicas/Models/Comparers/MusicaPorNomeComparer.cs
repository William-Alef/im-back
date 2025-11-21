namespace GerenciadorDeMusicas.Models.Comparers;    
internal class MusicaPorNomeComparer : IComparer<MusicaModel>
{
    public int Compare(MusicaModel? x, MusicaModel? y)
    {
        return string.Compare(x?.Nome, y?.Nome, StringComparison.OrdinalIgnoreCase);
    }
}
