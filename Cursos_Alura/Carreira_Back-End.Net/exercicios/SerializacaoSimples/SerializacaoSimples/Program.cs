using System.Text.Json;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
        var stream = new StreamReader(arquivo);
        var musica = ObterMusicas(stream);

        var artistas = ObterMusicas(stream)
            .GroupBy(g => g.Artista)
            .Select(g => new { g.Key, Musicas = g.OrderBy(m => m.Lancamento), Total = g.Count() })
            .ToList();

        var nomeDoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Artistas.json");
        using (var arquivoJson = new FileStream(nomeDoArquivo, FileMode.Create, FileAccess.Write))
        {
            JsonSerializer.Serialize(arquivoJson, artistas);
        }

        var caminhoJson = "Artistas.json";
        var json = File.ReadAllText(caminhoJson);
        IEnumerable<ArtistaMusicas> artistasDesserializados;
        using (var jsonSerializado = new FileStream(nomeDoArquivo, FileMode.Open, FileAccess.Read))
        {
           artistasDesserializados = JsonSerializer.Deserialize<IEnumerable<ArtistaMusicas>>(jsonSerializado)!;
        }

        if(artistasDesserializados != null)
        {
            foreach (var artista in artistasDesserializados)
            {
                Console.WriteLine(artista.Key);
            }
        }
    }

    public class Musica
    {
        public string Titulo{ get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public IEnumerable<string> Genero { get; set; }
        public DateTime Lancamento { get; set; }
    }

    public class ArtistaMusicas
    {
        public string Key { get; set; }
        public IEnumerable<Musica> Musicas { get; set; }
        public int Total { get; set; }
    }

    public static IEnumerable<Musica> ObterMusicas(StreamReader stream)
    {
        if (stream != null)
        {
            while (!stream!.EndOfStream)
            {
                var linha = stream.ReadLine();
                var dados = linha.Split(';');

                var match = Regex.Match(linha, @"(\d?\d):(\d?\d)");
                var tempo = 0;

                if (match.Success)
                {
                    var minuto = int.TryParse(match.Groups[1].Value, out int minutoConvertido) ? minutoConvertido : int.MinValue;
                    var segundo = int.TryParse(match.Groups[2].Value, out int segundoConvertido) ? segundoConvertido : int.MinValue;
                    tempo = (minuto * 60) + segundo;
                }
                else tempo = 0;

                yield return new Musica
                {

                    Titulo = string.IsNullOrEmpty(dados[0]) ? "Titulo não identificado" : dados[0],
                    Artista = string.IsNullOrEmpty(dados[1]) ? "Artista não identificado" : dados[1],
                    Duracao = tempo,
                    Genero = dados[3].Split(",", StringSplitOptions.TrimEntries),
                    Lancamento = DateTime.TryParse(dados[4], out DateTime data) ? data : DateTime.MinValue,
                };
            }
        }
    }

    public static void ApresentarMusicas(IEnumerable<Musica> lista)
    {
        foreach (var musica in lista)
        {
            Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) ({musica.Duracao} segundos), lançada em {musica.Lancamento}");
        }
    }

    public static void MusicasComLetrasRomanas(StreamReader musicas)
    {
        var regex = new Regex(@"\b[IVXLCDM]+\b");
        var listaDeMusias = ObterMusicas(musicas)
            .Where(m => regex.IsMatch(m.Titulo));

        ApresentarMusicasEmTabela(listaDeMusias);
    }

    public static void MusicasComLetrasRepetidas(StreamReader musicas)
    {
        var regex = new Regex(@"\w*(\w)\1{1,}\w");
        var listaDeMusicas = ObterMusicas(musicas)
            .Where(m => regex.IsMatch(m.Titulo));
        ApresentarMusicasEmTabela(listaDeMusicas);
    }

    public static void MusicasQueComecamETerminamComMesmaPalavra(StreamReader musicas)
    {
        var regex = new Regex(@"^(\w+).*\1$");
        var ListaDeMusicas = ObterMusicas(musicas)
            .Where(m => regex.IsMatch(m.Titulo));
        ApresentarMusicasEmTabela(ListaDeMusicas);
    }

    public static void MusicasComDuasPalavras(StreamReader musicas)
    {
        var regex = new Regex(@"^\w+ \w+$");
        var listaDeMusicas = ObterMusicas(musicas)
            .Where(m => regex.IsMatch(m.Titulo));

        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine(musica.Titulo);
        }
    }

    public static void ArtistasComCaracteresEspeciais(StreamReader musicas)
    {
        var regex = new Regex(@"[^a-zA-Z0-9 ]");
        var artistas = ObterMusicas(musicas)
           .Where(m => regex.IsMatch(m.Artista))
           .Select(m => m.Artista)
           .Distinct()
           .OrderBy(a => a);

        foreach (var artista in artistas)
        {
            Console.WriteLine(artista);
        }
    }

    public static void ApresentarMusicasEmTabela(IEnumerable<Musica> musicas)
    {
        var titulo = "\nMúsicas do arquivo:";
        Console.WriteLine(titulo);

        var colunaTitulo = "Titulo:".PadRight(40);
        var colunaArtista = "Artista:".PadRight(30);
        var colunaDuracao = "Duração:".PadRight(10);
        var colunaLancamento = "Lançada em:".PadRight(15);
        var borda = "".PadRight(97, '=');

        Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
        Console.WriteLine(borda);

        foreach (var musica in musicas)
        {
            Console.WriteLine($"{musica.Titulo,-40}{musica.Artista,-30}{musica.Duracao / 60.0,-10:f2}{musica.Lancamento,-15:dd/MM/yyyy}");
        }
    }
}