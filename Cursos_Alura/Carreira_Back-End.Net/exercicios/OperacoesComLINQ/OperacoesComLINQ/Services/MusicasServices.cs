using OperacoesComLINQ.Model;

namespace OperacoesComLINQ.Services;

internal class MusicasServices
{
    public static IEnumerable<Musica> ObterMusicas(StreamReader stream)
    {
  
        while (!stream.EndOfStream)
        {
            var linha = stream.ReadLine();
            var dados = linha.Split(';');
            yield return new Musica
            {
                Titulo = dados[0],
                Artista = dados[1],
                Duracao = Convert.ToInt32(dados[2]),
                Generos = dados[3].Split(",").Select(g => g.Trim())
            };
        }
    }

    public static void ApresentarMusicas(IEnumerable<Musica> musicas)
    {
        Console.WriteLine("Exibindo as musicas:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) ({musica.Duracao} seg)");
        }
    }

    public static void ApresentaMusicasDoArtista(IEnumerable<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas
        .Where(m => m.Artista.Equals(artista))
        .OrderBy(m => m.Titulo);
        ApresentarMusicas(musicasDoArtista);
    }
    
    public static void MusicasMaisLongas(IEnumerable<Musica> musicas)
    {
        var maioresMusicas = musicas
            .OrderByDescending(m => m.Duracao)
            .Take(10);

        ApresentarMusicas(maioresMusicas);
    }

    public static void ApresentaMusicasMaioresQueXDuracao(IEnumerable<Musica>musicas, int duracao)
    {
        var musicasMaioresQueX = musicas
        .Where(m => m.Duracao >= duracao)
        .OrderByDescending(m => m.Duracao)
        .ThenBy(m => m.Titulo);
        ApresentarMusicas(musicasMaioresQueX);
    }

    public static void PaginacaoDasMusicas(IEnumerable<Musica> musicas, int paginas)
    {
        int qntMusicasPorPagina = 5;
        var pagina = musicas
            .Skip((paginas - 1) * qntMusicasPorPagina)
            .Take(qntMusicasPorPagina);

        Console.WriteLine($"Pagina {paginas}");

        foreach (var musica in pagina)
        {
            Console.WriteLine($" - {musica.Titulo} ({musica.Artista}) ({musica.Duracao} seg)");
        }
    }

    public static void ColecaoDeArtistas(IEnumerable<Musica> musicas)
    {
        var colecaoDeArtistas = musicas
            .Select(m => m.Artista)
            .Distinct()
            .OrderBy(a => a)
            .ToList();

        Console.WriteLine("Lista de artistas:");
        foreach (var artista in colecaoDeArtistas)
        {
            Console.WriteLine(artista);
        }
    }

    public static void ColecaoDeGeneros(IEnumerable<Musica> musicas)
    {
        var colecaoDeGeneros = musicas
        .SelectMany(g => g.Generos)
        .Distinct()
        .OrderBy(a => a)
        .ToList();


        Console.WriteLine("Lista de generos:");
        foreach (var genero in colecaoDeGeneros)
        {
            Console.WriteLine(genero);
        }
    }

    public static void EstatisticasGerais(IEnumerable<Musica> musicas)
    {
        var lista = musicas.ToList();
        var tempoTotal = lista.Sum(d => d.Duracao);
        var tempoMedio = lista.Average(d => d.Duracao);
        var maiorMusica = lista.MaxBy(d => d.Duracao);
        var menorMusica = lista.MinBy(d => d.Duracao);
        var quantidadeDeMusicas = lista.Count();

        Console.WriteLine(
            $"A lista é composta por {quantidadeDeMusicas} músicas." +
            $"\nUma pessoa levaria {(tempoTotal / 60) / 24} dias para ouvir toda a lista." +
            $"\nO tempo médio de duração da listas é de {tempoMedio:F0} segundos." +
            $"\nA maior música da lista é {maiorMusica?.Titulo} da(o) artista {maiorMusica?.Artista} com {maiorMusica?.Duracao} sg de duração." +
            $"\nA menor música da lista é {menorMusica?.Titulo} da(o) artista {menorMusica?.Artista} com {menorMusica?.Duracao} sg de duração."
        );
    }

    public static void AgrupamentoPorArtistas(IEnumerable<Musica> musicas)
    {
        var grupos = musicas
        .GroupBy(a => a.Artista)
        .OrderBy(a => a.Key);

        foreach (var artista in grupos)
        {
            Console.WriteLine($"{artista.Key}:");


            foreach (var musica in artista
            .OrderBy(d => d.Duracao)
            ){
                Console.WriteLine($"\t - {musica.Titulo} - {musica.Duracao} sg");
            }
            Console.WriteLine();
        }
    }
    
    public static void ObtendoOPrimeiroMaior(IEnumerable<Musica> musicas, int segundos)
    {
        var listaMusicas = musicas.ToList();
        var primeiroMaior = listaMusicas
            .FirstOrDefault(d => d.Duracao >= segundos);
        var maiorMusica = listaMusicas
            .MaxBy(d => d.Duracao);
        if(primeiroMaior != null || musicas.Any()) Console.WriteLine($"A primeira música apresentada igual ou maior que {segundos} é {primeiroMaior.Titulo} da(o) {primeiroMaior.Artista} com {primeiroMaior.Duracao} segundos de duração.");
        if (maiorMusica != null || musicas.Any()) Console.WriteLine($"Porém, a maior música da lista é {maiorMusica.Titulo} da(o) {maiorMusica.Artista} com {maiorMusica.Duracao} segundos de duração.");
    }
  
}