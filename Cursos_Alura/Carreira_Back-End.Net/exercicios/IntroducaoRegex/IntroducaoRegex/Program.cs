using ManipulandoStrings.Services;

public class Program
{
    static void Main(string[] args)
    {
        var arquivo = new FileStream(@"IntroducaoRegex\Data\musicas.csv", FileMode.Open, FileAccess.Read);
        var stream = new StreamReader(arquivo);
        var musicas = MusicaServices.ObterMusica(stream);

        MusicaServices.InicioEFimComMesmaPalavra(musicas);
    }
}