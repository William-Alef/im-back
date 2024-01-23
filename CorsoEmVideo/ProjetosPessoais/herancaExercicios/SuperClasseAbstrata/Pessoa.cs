public abstract class Pessoa
{
    protected string Nome {get; set;}
    protected int Idade {get; set;}
    protected string Sexo {get; set;}
    public Pessoa(string nome, int idade, string sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public void fazerAniversario()
    {
        Idade++;
    } 
    public void apresentarDados()
    {
        System.Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nSexo: {Sexo}");
        System.Console.WriteLine();
    }
}