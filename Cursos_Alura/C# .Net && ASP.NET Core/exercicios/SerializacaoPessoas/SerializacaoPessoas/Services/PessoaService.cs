using SerializacaoPessoas.Models;
using System.Text.Json;
namespace SerializacaoPessoas.Services;

internal class PessoaService
{
    Pessoa? Pessoa { get; set; }
    private List<Pessoa>? pessoaList { get; set; } = [];
    
    public PessoaService(Pessoa pessoa)
    {
        Pessoa = pessoa;
    }

    public PessoaService(List<Pessoa> listaPessoas)
    {
        pessoaList = listaPessoas;
    }
    public void AdicionarUmaPessoa(Pessoa pessoa)
    {
        pessoaList.Add(pessoa);
    }
    public void AdicionarPessoas(List<Pessoa> listaPessoas)
    {
        pessoaList = listaPessoas;
    }

    public void SerializarPessoa()
    {
        string json = JsonSerializer.Serialize(Pessoa);
        string nomeDoArquivo = $"arquivo-{Pessoa?.Nome}-serializado.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Os dados do(a) {Pessoa.Nome} foram serializados com sucesso.");
    }
    public void SerializarPessoas()
    {
        string json = JsonSerializer.Serialize(pessoaList);
        string nomeDoArquivo = $"arquivo-de-pessoas-serializadas.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine("A lista fornecida foi serializada, com os dados das pessoas abaixo:" +
            $"\n{string.Join(", ", pessoaList
            .Select(p => p.Nome))}."
        );
    }
}
