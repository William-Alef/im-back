namespace MontagemDeMicros.Models;
internal class SolidStateDrive : Peca
{
    public string Compatibilidade { get; }
    public string Capacidade { get; }
    public SolidStateDrive(string fabricante, string modelo, string especificacoes, string compatibilidade, string capacidade) : base(fabricante, modelo, especificacoes)
    {
        Compatibilidade = compatibilidade;
        Capacidade = capacidade;
    }
    public override string ToString()
    {
        return base.ToString() +
            $"{Capacidade}";
    }
}
