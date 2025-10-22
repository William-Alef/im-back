using SerializacaoPessoas.Models;
using SerializacaoPessoas.Services;
namespace SerializacaoProgram;

public class Program
{
    static void Main(string[] args)
    {
        Pessoa rafael = new Pessoa("Rafael", 29, "Rafael@gmail.com");
        Pessoa Maria = new Pessoa("Maria", 39, "maria@bol.com");
        Pessoa Antonia = new Pessoa("Antônia", 19, "Rafael@yahoo.com");
        Pessoa Milena = new Pessoa("Milena", 33, "Milena@gmail.com");

        List<Pessoa> PessoasEmSistema = [Maria,Antonia,Milena];
        PessoaService teste1 = new PessoaService(rafael);
        PessoaService teste2 = new PessoaService(PessoasEmSistema);
        teste1.SerializarPessoa();
        teste2.SerializarPessoas();
    }
}