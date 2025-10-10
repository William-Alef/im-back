namespace MontagemDeMicros.Models;
internal class PlacaDeVideo : Peca
{
    public PlacaDeVideo(string fabricante, string modelo, string especificacoes) : base(fabricante, modelo, especificacoes)
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }
}
