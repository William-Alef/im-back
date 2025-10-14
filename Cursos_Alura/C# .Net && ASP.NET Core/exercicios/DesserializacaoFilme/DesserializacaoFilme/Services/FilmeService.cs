using DesserializacaoFilme.Models;
namespace DesserializacaoFilme.Services;

public class FilmeService
{
    public void ApresentarFilmesPorRanque(List<Filme> filmes)
    {
        if (filmes.Count == 0 || filmes == null)
        {
            Console.WriteLine("No moment, a lista está vazia.");
            return;
        }
        var filmesOrdenados = filmes
            .OrderByDescending(f => f.Nota)
            .ToList();

        foreach (var filme in filmesOrdenados)
        {
            Console.WriteLine(
                $"Filme: {filme.Titulo}" +
                $"\nNota: {filme.Nota}\n"
            );
        }
    }

    public void ApresentarFilmesPorAno(List<Filme> filmes)
    {
        if (filmes.Count == 0 || filmes == null)
        {
            Console.WriteLine("No moment, a lista está vazia.");
            return;
        }
        var filmesOrdenados = filmes
            .OrderByDescending(f => f.Ano)
            .ToList();

        foreach (var filme in filmesOrdenados)
        {
            Console.WriteLine(
                $"Filme: {filme.Titulo}" +
                $"\nAno: {filme.Ano}\n"
            );
        }
    }

    public void ApresentarElenco(List<Filme> filmes)
    {
        if (filmes.Count == 0 || filmes == null)
        {
            Console.WriteLine("No moment, a lista está vazia.");
            return;
        }
        var filmesOrdenados = filmes
            .ToList();

        foreach (var filme in filmesOrdenados)
        {
            Console.WriteLine(
                $"Filme: {filme.Titulo}" +
                $"\nAno: {filme.Ano}" +
                $"\nElenco: {filme.Elenco}\n"
            );
        }
    }
}
