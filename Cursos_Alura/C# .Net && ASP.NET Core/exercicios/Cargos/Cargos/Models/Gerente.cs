namespace Cargos.Models;
internal class Gerente : Funcionario
{
    public string Setor { get; set; }
    public  Gerente(string nome, double salario, string setor) : base(nome, salario)
    {
        Setor = setor;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Setor: {Setor}";
    }
}
