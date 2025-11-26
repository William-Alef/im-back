namespace ConsultaSimplesCSV;

internal class Musica
{
    public string Titulo { get;}
    public string Artista { get;}
    public int Duracao { get;}

    public Musica(string titulo, string artista, int duracao)
    {
        Titulo = titulo;
        Artista = artista;
        Duracao = duracao;
    }
}
