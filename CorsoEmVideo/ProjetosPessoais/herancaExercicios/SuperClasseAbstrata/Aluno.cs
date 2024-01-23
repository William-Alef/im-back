public class Aluno : Pessoa
{
    private int Matricula{get;set;}
    private string Curso{get;set;}
    public Aluno(string nome, int idade, string sexo, int matricula, string curso) : base(nome, idade, sexo)
    {
        this.Matricula = matricula;
        this.Curso = curso;
    }
    virtual public void pagarMensalidade()
    {
        System.Console.WriteLine($"Pagando mensalidade do(a) aluno(a) {Nome}");
        System.Console.WriteLine();
    }
}
