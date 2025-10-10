namespace MontagemDeMicros.Models;
internal abstract class Peca
{
    public string Fabricante { get; }
    public string Modelo { get; }
    public string Especificacoes { get; }

    public Peca(string fabricante, string modelo, string especificacoes)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Especificacoes = especificacoes;
    }
    public override string ToString()
    {
        return $"{Fabricante} {Modelo}";
    }
}