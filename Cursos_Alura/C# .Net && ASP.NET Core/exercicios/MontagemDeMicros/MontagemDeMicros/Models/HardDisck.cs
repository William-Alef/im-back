namespace MontagemDeMicros.Models;

internal class HardDisck : Peca
{
    public string Capacidade { get; }
    public HardDisck(string fabricante, string modelo, string especificacoes , string capacidade) : base(fabricante, modelo, especificacoes)
    {
        Capacidade = capacidade;
    }
    public override string ToString()
    {
        return base.ToString() +
            $"{Capacidade}";
    }
}
