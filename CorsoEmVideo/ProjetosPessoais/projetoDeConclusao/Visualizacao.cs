public class Visualizacao
{
    private Gafanhoto Espectador {get; set;}
    private Video Filme {get; set;}

    public Visualizacao(Gafanhoto espectador, Video filme)
    {
        this.Espectador = espectador;
        this.Filme = filme;
        this.Espectador.modificaQuantVideosVistos();
        this.Filme.AdicionaView(); 
    }
    public void apresentar()
    {
        System.Console.WriteLine($"Espectador: {Espectador.ApresentaNome()}\nQuant filmes assistidos: {Espectador.ApresentaQuantVideos()}\nFilme: {Filme.NomeVideo()} com {Filme.ApresentarView()} views");
    }
}