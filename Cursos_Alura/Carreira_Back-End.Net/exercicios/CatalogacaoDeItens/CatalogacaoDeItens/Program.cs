using CatalogacaoDeItens.Models;

namespace CatalogacaoDeItens;
public class Program
{
    static void Main(string[] args)
    {
        Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
        pergaminhoAntigo.MostrarDetalhes();
    }
}