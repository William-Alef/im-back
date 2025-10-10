namespace MontagemDeMicros.Models;
internal class PlacaMae : Peca
{
    public string Soquete { get; }

    public PlacaMae(string fabricante, string modelo, string especificacoes, string soquete) : base (fabricante, modelo, especificacoes)
    {
        Soquete = soquete;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
