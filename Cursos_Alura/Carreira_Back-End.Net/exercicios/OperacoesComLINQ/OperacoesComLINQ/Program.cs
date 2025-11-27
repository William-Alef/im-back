using OperacoesComLINQ.Services;
namespace OperacoesComLINQ;
public class Program
{
    static void Main(string[] args)
    {
        var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
        var stream = new StreamReader(arquivo);
        var musicas = MusicasServices.ObterMusicas(stream);

        //MusicasServices.ApresentarMusicas(musicas);
        //MusicasServices.ApresentaMusicasDoArtista(musicas, "Dua Lipa");
        //MusicasServices.MusicasMaisLongas(musicas);
        //MusicasServices.ApresentaMusicasMaioresQueXDuracao(musicas, 300);
        //MusicasServices.PaginacaoDasMusicas(musicas, 6);
        //MusicasServices.ColecaoDeArtistas(musicas);
        //MusicasServices.ColecaoDeGeneros(musicas);
        //MusicasServices.EstatisticasGerais(musicas);
        //MusicasServices.AgrupamentoPorArtistas(musicas);
        //MusicasServices.ObtendoOPrimeiroMaior(musicas, 350);
        //MusicasServices.ObtendoOPrimeiroMaior(musicas, 350);
    }
}