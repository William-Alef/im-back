namespace GerenciadorDeMusicas.Models;
internal class MusicaModel : IComparable<MusicaModel>
{
    public string Nome { get;}
    public int Duracao { get;}
    public ArtistaModel Artista { get;}

    public MusicaModel (string Nome, int Duracao, ArtistaModel Artista)
    {
        this.Nome = Nome;
        this.Duracao = Duracao;
        this.Artista = Artista;
    }

    public int CompareTo(MusicaModel? other)
    {
        if (other is null) return -1;
        if (other is MusicaModel outraMusica) return this.Duracao.CompareTo(outraMusica.Duracao);
        else return -1;
    }

    public override bool Equals(object? obj)
    {
        if(obj != null &&
            obj is MusicaModel objMusica) return this.Nome.Equals(objMusica.Nome) &&
                this.Artista.Equals(objMusica.Artista);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Nome.GetHashCode() ^ this.Artista.GetHashCode();
    }
}
