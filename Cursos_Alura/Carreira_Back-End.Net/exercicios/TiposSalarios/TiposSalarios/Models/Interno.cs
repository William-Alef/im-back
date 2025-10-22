namespace TiposSalarios.Models;

internal class Interno : Funcionario
{
    protected double Salario { get; set; }
    public Interno(string nome, string cargo, int idade, double salario) : base(nome, cargo, idade)
    {
        Salario = salario;
    }

    public override string ToString()
    {
        return base.ToString() + 
            $"\nSalário: R${Salario}";
    }
}
