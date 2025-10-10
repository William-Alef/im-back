namespace TiposSalarios.Models;

internal class Freelancer : Funcionario
{
    protected double Salario {  get; set; }
    protected string Projeto { get; set; }
    public Freelancer(string nome, string cargo, int idade, string projeto, double salario) : base(nome, cargo, idade)
    {
        Salario = salario;
        Projeto = projeto;
    }
    public override string ToString()
    {
        return base.ToString() +
            $"\nProjeto atual e custo: {Projeto} - R${Salario}";
    }
}
