using ManipulandoStrings.Models;
namespace ManipulandoStrings.Services;
internal static class MusicaServices
{
    public static IEnumerable<Musica> ObterMusica(StreamReader stream)
    {
        while(!stream.EndOfStream)
        {
            var linha = stream.ReadLine();
            var dados = linha!.Split(';');
           
            if(dados.Length == 5) 
            {
                yield return new Musica
                {
                    Titulo = string.IsNullOrWhiteSpace(dados[0]) ? "Titulo não identificado" : dados[0],
                    Artista = string.IsNullOrWhiteSpace(dados[1]) ? "Artista não identificado" : dados[0],
                    Duracao = int.TryParse(dados[2], out int duracao) ? duracao : 0,
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

    public static void AlterarTitulo(StreamReader listaDeMusicas, string novoTitulo)
    {
        var musica = ObterMusica(listaDeMusicas)
            .Where(m => m.Titulo.StartsWith('T'))
            .FirstOrDefault();

        Console.WriteLine($"Titulo da música: {musica!.Titulo}");
        musica.Titulo = novoTitulo;
        Console.WriteLine($"O 'novo' titulo é: {musica.Titulo}");
    }
}