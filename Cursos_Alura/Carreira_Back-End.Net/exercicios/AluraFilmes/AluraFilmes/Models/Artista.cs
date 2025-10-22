using Alura.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Artista(string nome, int idade)
{
    public string Nome{ get;} = nome;
    public int IDade { get; set; } = idade;
    public List<Filme> Filmes { get; set; } = [];     
    
    public void AdicionarFilme(Filme filme) { Filmes.Add(filme);}
}
