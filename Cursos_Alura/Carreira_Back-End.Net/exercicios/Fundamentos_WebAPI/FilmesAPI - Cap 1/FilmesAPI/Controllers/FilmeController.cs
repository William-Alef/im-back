using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = [];

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        Console.WriteLine($"{filme.Titulo}\n{filme.Genero}\n{filme.Duracao}");
        filmes.Add(filme);
    }
}
