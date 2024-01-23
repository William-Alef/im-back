public class Professor : Pessoa
{
    private string Especialidade {get;set;}
    private float Salario {get; set;}

    public Professor(string nome, int idade, string sexo, string especialidade, float salario) : base (nome, idade, sexo)
    {
        this.Especialidade = especialidade;
        this.Salario = salario;
    }
    public void ReceberAumento(float aumento)
    {
        this.Salario += aumento;
        System.Console.WriteLine($"O novo salário será de {Salario}");
    }
}