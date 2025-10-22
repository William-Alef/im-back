using DesserializacaoLivros.Models;
using System.Drawing;

namespace DesserializacaoLivros.Services;
public class LivroServices
{
    public void ApresentarLivros(List<Livro> listaLivros)
    {
        foreach (var livro in listaLivros)
        {
            Console.WriteLine($"{livro}\n");
        }
    }

    public void FiltrarPorEditora(List<Livro> listaLivros, string editora)
    {
        if (listaLivros?.Any() == true && editora != null)
        {
            var livrosFiltrados = listaLivros.Where(l => l.Editora == editora)
                .ToList();
            if (livrosFiltrados.Count > 0)
            {
                Console.WriteLine(string.Join(", ", livrosFiltrados));
            }
            else Console.WriteLine($"Nenhum livro da editora {editora} foi encontrado.");
        }
        else Console.WriteLine("Um ou mais valores informados são inválidos por serem nulos ou vazios.");
    }

    public void FiltrarPorAno(List<Livro> listaLivros, int ano)
    {
        if (listaLivros?.Any() == true && ano != null)
        {
            var livrosFiltrados = listaLivros.Where(l => l.Ano == ano)
                .ToList();
            if (livrosFiltrados.Count > 0)
            {
                Console.WriteLine(string.Join(", ", livrosFiltrados));
            }
            else Console.WriteLine($"Nenhum livro lançado em {ano} foi encontrado.");
        }
        else Console.WriteLine("Um ou mais valores informados são inválidos por serem nulos ou vazios.");
    }
}
