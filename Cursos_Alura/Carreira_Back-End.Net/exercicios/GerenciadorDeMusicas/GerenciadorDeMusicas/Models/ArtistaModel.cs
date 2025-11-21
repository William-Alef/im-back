namespace GerenciadorDeMusicas.Models;
internal class ArtistaModel
{
    public string Nome { get;}
    public int Idade { get;}
    public List<MusicaModel> Musicas { get; } = [];

    public ArtistaModel(string Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }

    public override bool Equals(object? obj)
    {
        return obj is ArtistaModel other &&
            Nome == other.Nome;
    }
    public override int GetHashCode()
    {
        return Nome.GetHashCode();
    }
}
