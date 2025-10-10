namespace SistemaDePagamentos.Models;
internal class Pessoa
{
    public string Nome { get;}
    public string Email { get; }

    public Pessoa(string nome, string email)
    {
        Nome = nome; 
        Email = email;
    }
}
