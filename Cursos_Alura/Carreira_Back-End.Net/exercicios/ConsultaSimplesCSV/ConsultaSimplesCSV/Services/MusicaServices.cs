namespace ConsultaSimplesCSV.service;
internal class MusicaServices
{
    public static IEnumerable<Musica> LerMusica(string caminho)
    {
        using var arquivo = new FileStream(caminho, FileMode.Open, FileAccess.Read);
        using var stream = new StreamReader(arquivo);

        var linha = stream.ReadLine();
        while (linha != null)
        {
            var informacoes = linha.Split(';');
            var musica = new Musica(informacoes[0], informacoes[1], Convert.ToInt32(informacoes[2]));
            yield return musica;
            linha = stream.ReadLine();
        }
    }

    public static void ApresentarMusica(IEnumerable<Musica> musicas)
    {
        Console.WriteLine("Exibindo músicas: ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) ({musica.Duracao} seg.)");
        }
    }
}
