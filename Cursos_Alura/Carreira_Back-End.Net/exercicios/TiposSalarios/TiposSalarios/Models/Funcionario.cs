namespace TiposSalarios.Models;
internal class Funcionario
{
    protected string Nome { get; set; }
    protected int Idade { get; set; }
    protected string Cargo { get; set; }

    public Funcionario(string nome, string cargo, int idade) 
    {
        Nome = nome;
        Cargo = cargo;
        Idade = idade;
    }
    public override string ToString()
    {
        return $"Funcionário: {Nome}" +
            $"\nIdade: {Idade}" +
            $"\nCargo: {Cargo}";
    }
}
