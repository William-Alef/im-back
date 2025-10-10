namespace MontagemDeMicros.Models;
internal class AirCooler : Peca
{
    public string Compatibilidade { get; }
    public string Desempenho { get; }
    public AirCooler(string fabricante, string modelo, string especificacoes, string compatibilidade, string desempenho) : base(fabricante, modelo, especificacoes)
    {
        Compatibilidade = compatibilidade;
        Desempenho = desempenho;
    }
    public override string ToString()
    {
        return $"{Fabricante} - {Modelo}";
    }
}
