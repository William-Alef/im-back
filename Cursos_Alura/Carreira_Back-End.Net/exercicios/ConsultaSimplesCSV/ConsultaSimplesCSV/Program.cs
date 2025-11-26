using ConsultaSimplesCSV.service;

public class Program
{
    static void Main(string[] args)
    {
        var musicas = MusicaServices.LerMusica(@"exercicios\ConsultaSimplesCSV\ConsultaSimplesCSV\Data\musicas.csv");
        var musicasComFiltros = musicas
            .Where(m => m.Artista == "Metallica")
            .Where(m => m.Duracao < 400)
            .Take(20);

        MusicaServices.ApresentarMusica(musicasComFiltros);
    }
}