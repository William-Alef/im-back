using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Cargos.Models;
internal class Analista : Funcionario
{
    public string Especialidade { get; set; }

    public Analista(string nome, double salario, string especialidade) : base(nome, salario)
    {
        Especialidade = especialidade;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Especialidade: {Especialidade}";
    }
}
