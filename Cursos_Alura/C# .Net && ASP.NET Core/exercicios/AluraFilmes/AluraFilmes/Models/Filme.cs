using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Filmes;

public class Filme(string nome, double duracao, List<Artista> elenco)
{
    public string Nome { get;} = nome;
    public double Duracao { get;} = duracao;
    public List<Artista> Elenco { get; } = elenco;   
        
    public void AdicionarArtista(Artista artista)
    {
        Elenco.Add(artista);
        artista.AdicionarFilme(this);
    }

    public void ApresentarFilme()
    {
        Console.WriteLine(
            $"Filme: {Nome}." +
            $"\nDuração: {Duracao}." +
            $"\nElenco: {string.Join(", ", Elenco.Select(e => e.Nome))}"
        );
    }
}
