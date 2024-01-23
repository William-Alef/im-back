public class Aluno : Pessoa
{
    private int Matricula {get; set;}
    private string Curso {get; set;}
    public void CancelarMatr()
    {
        this.Matricula = 0;
    }
    public Aluno(string nome, int idade, string sexo, int matricula, string curso) : base (nome, idade, sexo)
    {
        this.Matricula = matricula;
        this.Curso = curso;
    }
}