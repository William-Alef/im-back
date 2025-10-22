using GestaoDeServicos.Interfaces;

namespace GestaoDeServicos.Models;
internal class Consultoria : IServico
{
    public string Titulo;
    public Funcionario Funcionario;

    public Consultoria(string titulo, Funcionario funcionario)
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
