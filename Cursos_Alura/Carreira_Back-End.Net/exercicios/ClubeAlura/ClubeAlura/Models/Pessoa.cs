namespace ClubeAlura.Models;
internal abstract class Pessoa
{
    protected string Nome { get; set; }
    protected int Idade { get; set; }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}
