using System.Security.Cryptography.X509Certificates;

namespace CatalogacaoDeItens.Models;
internal class Pergaminho : ItemDigital
{
    protected string Descricao { get; set; }

    public Pergaminho(string titulo, string descricao) : base(titulo) 
    {
        Descricao = descricao;
    }
    public void MostrarDetalhes()
    { 
        Console.WriteLine(
            $"Detalhes do pergaminho: " +
            $"\nTítulo: {Titulo}" +
            $"\nDescrição: {Descricao}"
        ); 
    }
}
