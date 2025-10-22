namespace Cargos.Models;
internal class Programador : Funcionario
{
    public string TeamSide { get; set; }
    public string Linguagem { get; set; }
    
    public Programador(string nome, double salario, string teamSide, string linguagem) : base(nome, salario)
    {
        TeamSide = teamSide;
        Linguagem = linguagem;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Team Side: {TeamSide}" +
            $"\nLinguagem utilizada: {Linguagem}";
    }
}
