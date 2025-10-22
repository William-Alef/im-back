namespace DadosDePassageiros.Models;
internal class Passageiro : Pessoa
{
    protected int QuantidadeBilhetes { get; }
    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }
    public void ApresentarDados() 
    {
        Console.WriteLine(
            $"Passageiro: {Nome}" +
            $"\nIdade: {Idade}" +
            $"\nBilhetes: {QuantidadeBilhetes}"
        );
    }
}
