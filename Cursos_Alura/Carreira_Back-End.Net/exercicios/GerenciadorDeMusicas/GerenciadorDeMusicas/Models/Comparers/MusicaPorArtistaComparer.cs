using System;

namespace GerenciadorDeMusicas.Models.Comparers;

internal class MusicaPorArtistaComparer : IComparer<MusicaModel>
{
    public int Compare(MusicaModel? x, MusicaModel? y)
    {
        if (x is null || y is null) return 0;
        return string.Compare(x.Artista.Nome, y.Artista.Nome, StringComparison.OrdinalIgnoreCase);
    }
}
