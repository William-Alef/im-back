namespace MontagemDeMicros.Models;

internal class WaterCooler : Peca
{
    public string Compatibilidade { get;}
    public string Desempenho { get;}
    public WaterCooler(string fabricante, string modelo, string especificacoes, string compatibilidade, string desempenho) : base(fabricante, modelo, especificacoes)
    {
        Compatibilidade = compatibilidade;
        Desempenho = desempenho;
    }
    public override string ToString()
    {
        return base.ToString() +
            $"{Desempenho}";
    }
}
