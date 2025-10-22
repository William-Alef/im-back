namespace Cargos.Models;
internal class Funcionario
{
    public string Nome { get;}
    protected double Salario { get; set;}

    public Funcionario(string nome, double salario = 0)
    {
        Nome = nome;
        Salario = salario;
    }
    public void AumentarSalario(double aumento)
    {
        Salario += aumento;
    }

    public override string ToString()
    {
        return $"Funcionário: {Nome}" +
            $"\nSalário: R${Salario}\n";
    }
}
