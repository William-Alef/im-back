public class Bolsista : Aluno
{
    private string Bolsa{get; set;}
    public Bolsista(string nome, int idade, string sexo, int matricula, string curso, string bolsa) : base(nome, idade, sexo, matricula, curso)
    {
        this.Bolsa = bolsa;
    }
    public void renovarBolsa()
    {
        System.Console.WriteLine($"Renovando a bolsa do(a) aluno(a) {Nome}");
    }
    override public void pagarMensalidade()
    {
        System.Console.WriteLine($"Por se trata-se de um aluno bolsista o pagamento foi facilitado!");
        System.Console.WriteLine();
    }
} 