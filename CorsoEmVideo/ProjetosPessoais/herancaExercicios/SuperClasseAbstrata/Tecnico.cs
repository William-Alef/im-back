public class Tecnico : Aluno
{
    private string RegistroProfissional;
    public Tecnico(string nome, int idade, string sexo, int matricula, string curso, string registroProfissional) : base(nome, idade, sexo, matricula, curso)
    {
        this.RegistroProfissional = registroProfissional;
    }
    public void Praticar()
    {
        System.Console.WriteLine($"O profissional {Nome} tem permissão para exercer o seu serviço");
    }
}