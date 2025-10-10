namespace GestaoDeServicos.Models;
internal class Funcionario
{
    public string Nome { get;}
    public string Departamento { get; }

    public Funcionario(string nome, string departamento)
    {
        Nome = nome;
        Departamento = departamento;
    }
}
