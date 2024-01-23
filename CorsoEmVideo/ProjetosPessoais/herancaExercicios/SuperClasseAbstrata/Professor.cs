public class Professor : Pessoa
{
    private string Especialidade;
    private int Salario;
    public Professor(string nome, int idade, string sexo, string especialidade, int salario) : base(nome, idade, sexo)
    {
        this.Especialidade = especialidade;
        this.Salario = salario;
    }
}