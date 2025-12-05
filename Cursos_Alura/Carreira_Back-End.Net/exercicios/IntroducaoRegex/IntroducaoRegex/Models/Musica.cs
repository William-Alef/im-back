namespace ManipulandoStrings.Models;
internal class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Genero { get; set; }
    public DateTime Lancamento { get; set; }
}