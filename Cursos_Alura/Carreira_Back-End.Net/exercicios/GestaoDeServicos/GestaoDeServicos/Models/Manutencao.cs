using GestaoDeServicos.Interfaces;

namespace GestaoDeServicos.Models;
internal class Manutencao : IServico
{
    public string Titulo { get;}
    public Funcionario Funcionario { get;}
    public Manutencao(string titulo, Funcionario funcionario)
    {
        Titulo = titulo;
        Funcionario = funcionario;
    }
    public void ExecutarServico()
    {
        Console.WriteLine(
            $"Executando serviço de manutenção: {Titulo}" +
            $"\nResponsável: {Funcionario.Nome} - Departamento: {Funcionario.Departamento}"
        );
    }
}
