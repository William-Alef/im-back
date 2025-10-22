namespace DadosDePassageiros.Models;
internal abstract class Pessoa
{
    protected string Nome {get;}
    protected int Idade {get;}
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
