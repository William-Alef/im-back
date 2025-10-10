namespace MontagemDeMicros.Models;

internal class Fonte : Peca
{
    public string Certificacao { get;}

    public Fonte(string fabricante, string modelo, string especificacoes, string certificacao) : base(fabricante, modelo, especificacoes)
    {
        Certificacao = certificacao;
    }
    public override string ToString()
    {
        return base.ToString() + 
            $" - {Certificacao}";
    }
}
