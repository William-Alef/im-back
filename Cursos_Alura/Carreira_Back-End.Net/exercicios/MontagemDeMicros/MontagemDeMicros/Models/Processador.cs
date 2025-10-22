namespace MontagemDeMicros.Models;

internal class Processador : Peca
{
    public Processador(string fabricante, string modelo, string especificacoes, string soquete) : base(fabricante,modelo, especificacoes)
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }
}
