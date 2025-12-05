using ManipulandoStrings.Models;
using System.Text.RegularExpressions;
namespace ManipulandoStrings.Services;
internal static class MusicaServices
{
    public static IEnumerable<Musica> ObterMusica(StreamReader stream)
    {
        while(!stream.EndOfStream)
        {
            var linha = stream.ReadLine();
            var dados = linha!.Split(';');
            var combinacao = Regex.Match(linha, @"(\d?\d):(\d?\d)");

            int duracao = 0;
            if (combinacao.Success)
            {
                int minutos = int.Parse(combinacao.Groups[1].Value);
                int seguntos = int.Parse(combinacao.Groups[2].Value);
                duracao = (minutos * 60) + seguntos;
            }
            if(dados.Length == 5) 
            {
                yield return new Musica
                {
                    Titulo = string.IsNullOrWhiteSpace(dados[0]) ? "Titulo não identificado" : dados[0],
                    Artista = string.IsNullOrWhiteSpace(dados[1]) ? "Artista não identificado" : dados[0],
                    Duracao = duracao,
                    Genero = dados[3].Split(',', StringSplitOptions.TrimEntries),
                    Lancamento = DateTime.TryParse(dados[4], out DateTime data) ? data : DateTime.MinValue
                };           
            }
        }
    }

    public static void ApresentarMusicas(IEnumerable<Musica> listaDeMusicas)
    {
        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"{musica.Titulo} - {musica.Artista} - {string.Join(", ", musica.Genero)} - {musica.Duracao / 60:f2} - {musica.Lancamento:dd/MM/yyyy}");
        }
    }

    public static void ApresentarMusicasTabeladas(IEnumerable<Musica> listaDeMusicas)
    {
        var borda = "".PadRight(109, '=');

        Console.WriteLine($"{"Titulo", -30}{"Artista", -30}{"Gênero", -24}{"Duração"}{"Lançamento", +18}");
        Console.WriteLine(borda);
        Console.WriteLine();
        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"{musica.Titulo, -28}  {musica.Artista, -28}  {string.Join(", ", musica.Genero), -23} {(musica.Duracao / 60.0),-14:F2} {musica.Lancamento:dd/MM/yyyy}");
        }
    }

    public static void InicioEFimComMesmaPalavra(IEnumerable<Musica> listaDeMusicas)
    {
        Regex regex = new Regex(@"(^\w+).*(\1)$");
        foreach (var musica in listaDeMusicas)
        {
            Match match = regex.Match(musica.Titulo);
            if (match.Success) Console.WriteLine(musica.Titulo);
        }
    }

    public static void TituloComDuasPalavras(IEnumerable<Musica> listaDeMusicas)
    {
        Regex regex = new Regex(@"(^\w+\s\w+$)");
        foreach (var musica in listaDeMusicas)
        {
            var match = regex.Match(musica.Titulo);
            if (match.Success) Console.WriteLine(musica.Titulo);
        }
    }
}